using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.ConsumoApi.B2
{
    public interface IAutorizacaoB2
    {
        B2Response Autorizacao(string credencial);
    }
}
