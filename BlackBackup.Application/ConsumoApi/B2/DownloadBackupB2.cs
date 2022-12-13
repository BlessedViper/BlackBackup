using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.ConsumoApi.B2;
using RestSharp;
using System.Text;

namespace BlackBackup.Application.ConsumoApi.B2
{
    public class DownloadBackupB2 : IDownloadBackupB2
    {
        public void DownloadBackup(string ArquivoId, B2Response response, string caminhoDownload)
        {
            var client = new RestClient(response.DownloadUrl);
            var request = new RestRequest("/b2api/v2/b2_download_file_by_id", Method.Post);
            var body = Encoding.UTF8.GetBytes("{\"fileId\":\"" + ArquivoId + "\"}");

            request.AddHeader("Authorization", response.AuthorizationToken);
            request.AddHeader("Content-Length", body.Length);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");

            request.AddBody(body);
            byte[] respondeDownload = client.DownloadData(request);

            File.WriteAllBytes(caminhoDownload, respondeDownload);
        }
    }
}
