using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Controller.ListaBackups
{
    public interface IAtualizarLista
    {
        void Atualizar(B2Response response, Bucket bucketId);
    }
}
