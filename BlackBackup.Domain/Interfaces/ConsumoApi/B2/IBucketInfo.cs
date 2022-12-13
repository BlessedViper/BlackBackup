using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.ConsumoApi.B2
{
    public interface IBucketInfo
    {
        Bucket GetInfo(Bucket bucket, B2Response response);
    }
}
