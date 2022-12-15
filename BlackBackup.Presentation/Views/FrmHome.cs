using BlackBackup.Controller;
using BlackBackup.Controller.Conexoes;
using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Controller;
using BlackBackup.Domain.Interfaces.Controller.Conexoes;
using MaterialSkin;

namespace BlackBackup.Presentation.Views
{
    public partial class FrmHome : MaterialSkin.Controls.MaterialForm
    {
        public IRetornaConexoesController RetornaConexoes { get; set; }
        public IRetornaConexaoIdController RetornaConexoesId { get; set; }
        public IAtualizarListaConexoesController AtualizarListaConexoes { get; set; }
        public IExcluirConexaoController ExcluirConexaoController { get; set; }
        private int ListViewItem { get; set; }

        private MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private FrmAdicionarEditarConexoes _frmAdicionar;
        private Bucket _bucket;
        private IValidaBd _validaBd;



        public FrmHome()
        {
            InitializeComponent();
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            _materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Primary.DeepPurple700,
                Accent.DeepPurple700,
                TextShade.WHITE
                );
        }

        private async void FrmHome_Load(object sender, EventArgs e)
        {
            _validaBd = new ValidaBd();
            await Task.Run(() => _validaBd.VerificaExistenciaBd());
            RetornaConexoes = new RetornaConexoesController();
            var buckets = await RetornaConexoes.RetornaConexoes();
            FeedGrid(buckets);
        }
        private void FeedGrid(List<Bucket> buckets)
        {
            mlvConexoes.Items.Clear();
            try
            {
                foreach (var data in buckets)
                {
                    ListViewItem item = new ListViewItem(data.Id.ToString());
                    item.SubItems.Add(data.Apelido);
                    mlvConexoes.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message) { Source = ex.Source };
            }
        }
        private void mlvConexoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnEditar.Visible = true;
            this.btnExcluir.Visible = true;
            ListViewItem = mlvConexoes.FocusedItem.Index;
        }

        #region Ação dos botões
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _frmAdicionar = new FrmAdicionarEditarConexoes(_bucket);
            _frmAdicionar.ShowDialog();

            AtualizarFormularioAsync();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RetornaConexoesId = new RetornaConexaoIdController();
            var idBucket = mlvConexoes.Items[ListViewItem].Text.ToString();
            Int32.TryParse(idBucket, out int id);
            var bucketEditar = RetornaConexoesId.RetornaConexaoId(id);

            _frmAdicionar = new FrmAdicionarEditarConexoes(bucketEditar);
            _frmAdicionar.ShowDialog();

            AtualizarFormularioAsync();
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            RetornaConexoesId = new RetornaConexaoIdController();
            var idBucket = mlvConexoes.Items[ListViewItem].Text.ToString();
            Int32.TryParse(idBucket, out int id);
            var bucketExcluir = RetornaConexoesId.RetornaConexaoId(id);

            ExcluirConexaoController = new ExcluirConexaoController();
            await Task.Run(() => ExcluirConexaoController.ExcluirConexao(bucketExcluir));

            AtualizarFormularioAsync();
        }
        #endregion
        private async void AtualizarFormularioAsync()
        {
            RetornaConexoes = new RetornaConexoesController();
            var conexoes = await RetornaConexoes.RetornaConexoes();
            FeedGrid(conexoes);
        }
    }
}
