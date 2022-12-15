using BlackBackup.Domain.Interfaces.Controller;
using BlackBackup.Domain.Interfaces.Infra;
using BlackBackup.Infra.ManipulacaoBd;

namespace BlackBackup.Controller
{
    public class ValidaBd : IValidaBd
    {
        public ICriaBd? CriaBancoDados { get; set; }
        private static string _caminhoBancoDados = @$"{System.Windows.Forms.Application.StartupPath}\Data";
        private readonly string _caminhoBancoDadosArquivo = @$"{_caminhoBancoDados}\Data.db";

        public void VerificaExistenciaBd()
        {
            if (File.Exists(_caminhoBancoDadosArquivo))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(_caminhoBancoDados);
                CriaBancoDados = new CriaBd();
                CriaBancoDados.CriaArquivoBd(_caminhoBancoDadosArquivo);
            }
        }
    }
}
