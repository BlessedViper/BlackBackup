using BlackBackup.Domain.Interfaces.Infra;
using System.Data.SQLite;

namespace BlackBackup.Infra.ManipulacaoBd
{
    public class CriaBd : ICriaBd
    {
        public ICriaTabelas? CriaTabelas { get; set; }
        public void CriaArquivoBd(string caminhoBancoDados)
        {
            try
            {
                CriaTabelas = new CriaTabelas();
                SQLiteConnection.CreateFile(caminhoBancoDados);
                CriaTabelas.CriaTabelasBd(caminhoBancoDados);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
