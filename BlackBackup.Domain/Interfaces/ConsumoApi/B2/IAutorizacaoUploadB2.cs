using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.ConsumoApi.B2
{
    public interface IAutorizacaoUploadB2
    {
        B2Response UploadB2Async(B2Response b2Response, string bucketId);
    }
}
