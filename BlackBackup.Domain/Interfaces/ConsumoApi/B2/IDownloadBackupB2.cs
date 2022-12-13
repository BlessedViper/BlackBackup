using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.ConsumoApi.B2
{
    public interface IDownloadBackupB2
    {
        void DownloadBackup(string ArquivoId, B2Response response, string caminhoDownload);
    }
}
