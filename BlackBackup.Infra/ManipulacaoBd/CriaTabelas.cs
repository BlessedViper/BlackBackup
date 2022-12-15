using System.Data.SQLite;

namespace BlackBackup.Infra.ManipulacaoBd
{
    public class CriaTabelas
    {
        private static SQLiteConnection _sqliteConnection;

        private static SQLiteConnection Connection(string caminhoBanco)
        {
            _sqliteConnection = new SQLiteConnection(@$"Data Source={caminhoBanco}; Version=3");
            _sqliteConnection.Open();
            return _sqliteConnection;
        }
        public void CriaTabelasBd(string caminhoBanco)
        {
            try
            {
                using var cmd = Connection(caminhoBanco).CreateCommand();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS Buckets(id INTEGER PRIMARY KEY AUTOINCREMENT, IdChaveAplicacao Varchar(200), ChaveAplicacao Varchar(200), NomeBucket Varchar(200), BucketId Varchar(200), Apelido Varchar(200))";
                cmd.ExecuteNonQuery();
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
