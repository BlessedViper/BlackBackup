using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.ConsumoApi.ControleIaas
{
    public interface IGetDadosInstancia
    {
        Instancia GetInstancia(int id);
    }
}
