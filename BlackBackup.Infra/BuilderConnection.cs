using Microsoft.Data.SqlClient;

namespace BlackBackup.Infra
{
    public static class BuilderConnection
    {
        public static string GetConnection(string instancia, string banco, string user, string pass)
        {
            SqlConnectionStringBuilder builder = new();
            builder.DataSource = instancia;
            builder.InitialCatalog = banco;
            builder.UserID = user;
            builder.Password = pass;

            return builder.ConnectionString;
        }


    }
}
