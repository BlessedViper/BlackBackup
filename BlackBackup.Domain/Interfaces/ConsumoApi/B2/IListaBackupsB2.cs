using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.ConsumoApi.B2
{
    public interface IListaBackupsB2
    {
        List<Backups> Listar<Backups>(B2Response responseB2, string bucketId);
    }
}
