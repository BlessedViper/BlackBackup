using BlackBackup.Controller;
using BlackBackup.Controller.Conexoes;
using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Controller;
using BlackBackup.Domain.Interfaces.Controller.Conexoes;
using MaterialSkin;
using System.Windows.Forms;

namespace BlackBackup.Presentation.Views
{
    public partial class FrmHome : MaterialSkin.Controls.MaterialForm
    {
        public IRetornaConexoesController RetornaConexoes { get; set; }

        private MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        private FrmAdicionar _frmAdicionar;
        private Bucket _bucket;
        private IValidaBd _validaBd;
        private readonly string _bancoDados = $@"{System.Windows.Forms.Application.StartupPath}\Data\Data.db";
        
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _frmAdicionar = new FrmAdicionar(_bucket);
            _frmAdicionar.ShowDialog();
        }
        private async void FrmHome_Load(object sender, EventArgs e) 
        {
            _validaBd = new ValidaBd();
            await Task.Run(() => _validaBd.VerificaExistenciaBd(_bancoDados));
            RetornaConexoes = new RetornaConexoesController();
            var buckets = await RetornaConexoes.RetornaConexoes();
            FeedGrid(buckets);
        }
        private void FeedGrid(List<Bucket> buckets)
        {
            try
            {  
                foreach (var data in buckets)
                {
                    ListViewItem item = new ListViewItem(data.Id.ToString());
                    item.SubItems.Add(data.Apelido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message) { Source = ex.Source };
            }
        }
    }
}
