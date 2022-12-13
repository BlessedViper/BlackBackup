using BlackBackup.Controller.Conexoes;
using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Controller.Conexoes;
using MaterialSkin;

namespace BlackBackup.Presentation.Views
{
    public partial class FrmAdicionar : MaterialSkin.Controls.MaterialForm
    {
        private MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        public IAdicionarConexaoController adicionarConexao { get; set; }
        private Bucket _bucket;
        public FrmAdicionar(Bucket bucket)
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
            _bucket = bucket;
        }

        private async void btnGravar_Click(object sender, EventArgs e)
        {
            _bucket = new(txtApplicationKeyId.Text, txtApplicationKey.Text);
            if (txtApplicationKey.Text.Equals("") || txtApplicationKeyId.Text.Equals(""))
            {
                MessageBox.Show("campo Application Key e Application Id não podem ser nulos", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                adicionarConexao = new AdicionarConexaoController();
                await Task.Run(() => adicionarConexao.Adicionar(_bucket));
                this.Hide();
                this.Parent = null;
            }

        }

        #region Close Form
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }

        private void FrmAdicionar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
        }
        #endregion

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {

            if (_bucket is null)
                return;

            txtApplicationKey.Text = _bucket.ChaveAplicacao;
            txtApplicationKeyId.Text = _bucket.IdChaveAplicacao;
        }
    }
}
