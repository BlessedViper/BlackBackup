using BlackBackup.Domain.Interfaces.Infra;
using System.Data.SQLite;

namespace BlackBackup.Infra.ManipulacaoBd
{
    public class CriaTabelas : ICriaTabelas
    {
        private SQLiteConnection _sqliteConnection;
        public void CriaTabelasBd(string caminhoBanco)
        {
            try
            {
                _sqliteConnection = new SQLiteConnection(@$"Data Source={caminhoBanco}; Version=3");
                _sqliteConnection.Open();
                _sqliteConnection.CreateCommand();
                _sqliteConnection.CreateCommand().CommandText = "CREATE TABLE IF NOT EXISTS Buckets(id INT PRIMARYKEY, IdChaveAplicacao Varchar(200), ChaveAplicacao Varchar(200), NomeBucket Varchar(200), BucketId Varchar(200))";
                _sqliteConnection.CreateCommand().ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _sqliteConnection.Close();
            }

        }
    }
}
