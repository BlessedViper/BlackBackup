using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.ConsumoApi.B2
{
    public interface IUploadBackupB2
    {
        void UploadBackup(B2Response b2Response, string bucketId, string caminho, string arquivoNome);
    }
}
