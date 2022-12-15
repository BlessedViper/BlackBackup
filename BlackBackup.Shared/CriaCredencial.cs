using System.Text;

namespace BlackBackup.Shared
{
    public static class CriaCredencial
    {
        public static string Credencial(string chaveAplicacaoId, string chaveAplicacao)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes($"{chaveAplicacaoId}:{chaveAplicacao}"));
        }
    }
}
