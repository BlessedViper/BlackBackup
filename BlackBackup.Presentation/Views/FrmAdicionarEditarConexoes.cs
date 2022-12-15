using BlackBackup.Controller.Conexoes;
using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Controller.Conexoes;
using MaterialSkin;

namespace BlackBackup.Presentation.Views
{
    public partial class FrmAdicionarEditarConexoes : MaterialSkin.Controls.MaterialForm
    {
        private MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        public IAdicionarConexaoController AdicionarConexao { get; set; }
        public IEditarConexaoController EditarConexao { get; set; }
        private Bucket _bucket;
        public FrmAdicionarEditarConexoes(Bucket bucket)
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
            txtApplicationKey.PasswordChar = '*';
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApplicationKey.Text) || string.IsNullOrEmpty(txtApplicationKeyId.Text) || string.IsNullOrEmpty(txtBucketName.Text))
            {
                MessageBox.Show("Os campos não podem ser vazios, por gentileza, verifique se preencheu todos os campos antes de gravar os dados de conexão", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (_bucket is null)
                {
                    BucketNovoAsync(_bucket);
                }
                else
                {
                    BucketExistenteAsync(_bucket);
                }
            }

        }
        private void FrmAdicionar_Load(object sender, EventArgs e)
        {

            if (_bucket is null)
                return;

            txtApplicationKey.Text = _bucket.ChaveAplicacao;
            txtApplicationKeyId.Text = _bucket.IdChaveAplicacao;
            txtBucketName.Text = _bucket.Apelido;
        }
        private async void BucketNovoAsync(Bucket bucket)
        {
            _bucket = new();
            _bucket.ChaveAplicacao = txtApplicationKey.Text;
            _bucket.IdChaveAplicacao = txtApplicationKeyId.Text;
            _bucket.Apelido = txtBucketName.Text;

            AdicionarConexao = new AdicionarConexaoController();
            await Task.Run(() => AdicionarConexao.Adicionar(_bucket));
            this.Hide();
            this.Parent = null;
        }
        private async void BucketExistenteAsync(Bucket bucket)
        {
            _bucket.ChaveAplicacao = txtApplicationKey.Text;
            _bucket.IdChaveAplicacao = txtApplicationKeyId.Text;
            _bucket.Apelido = txtBucketName.Text;

            EditarConexao = new EditarConexaoController();
            await Task.Run(() => EditarConexao.EditarConexao(_bucket));
            this.Hide();
            this.Parent = null;
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
    }
}
