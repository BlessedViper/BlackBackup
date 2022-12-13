using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.ConsumoApi.ControleIaas
{
    public interface IGetDadosClientes
    {
        List<Clientes> GetClientes();
    }
}
