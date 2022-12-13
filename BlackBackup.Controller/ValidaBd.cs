using BlackBackup.Domain.Interfaces.Controller;
using BlackBackup.Domain.Interfaces.Infra;
using BlackBackup.Infra.ManipulacaoBd;

namespace BlackBackup.Controller
{
    public class ValidaBd : IValidaBd
    {
        public ICriaBd? CriaBancoDados { get; set; }
        public void VerificaExistenciaBd(string caminhoBancoDados)
        {
            if (File.Exists(caminhoBancoDados))
            {
                return;
            }
            else
            {
                CriaBancoDados = new CriaBd();
                CriaBancoDados.CriaArquivoBd(caminhoBancoDados);
            }
        }
    }
}
