using Newtonsoft.Json;
using NivelCashback_Integration.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace NivelCashback_Integration.Services
{
    public static class NivelCashbackIntegration
    {
        private static string GetURL(AmbienteTypes ambienteType)
        {
            string url = "";
            switch (ambienteType)
            {
                case AmbienteTypes.Producao:
                    url = "https://api.nivel.com.br/";
                    break;
                case AmbienteTypes.Homologacao:
                    url = "https://homologacaoapi.nivel.com.br/";
                    break;
                default:
                    url = "https://api.nivel.com.br/";
                    break;
            }
            return url;
        }
        public static async Task<StatusResponse> Status(StatusResquest ob, AmbienteTypes ambienteType = AmbienteTypes.Producao)
        {
            StatusResponse response = new StatusResponse();

            try
            {
                using (var client = new HttpClient())
                {
                    string URI = GetURL(ambienteType) + "ws/Status";
                    HttpResponseMessage responseHttp = await client.PostAsJsonAsync(URI, ob);
                    if (responseHttp.IsSuccessStatusCode)
                    {
                        var JsonString = await responseHttp.Content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<StatusResponse>(JsonString);
                        response.Sucesso = true;
                    }
                    else
                    {
                        response.Sucesso = false;
                    }
                }
            }
            catch
            {
                response.Sucesso = false;
            }

            return response;
        }
        public static async Task<BonificacaoResponse> Bonificacao(BonificacaoRequest ob, AmbienteTypes ambienteType = AmbienteTypes.Producao)
        {
            BonificacaoResponse response = new BonificacaoResponse();

            try
            {
                using (var client = new HttpClient())
                {
                    string URI = GetURL(ambienteType) + "ws/Bonificar";
                    HttpResponseMessage responseHttp = await client.PostAsJsonAsync(URI, ob);
                    if (responseHttp.IsSuccessStatusCode)
                    {
                        var JsonString = await responseHttp.Content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<BonificacaoResponse>(JsonString);
                    }
                    else
                    {
                        response.Sucesso = false;
                    }
                }
            }
            catch
            {
                response.Sucesso = false;
            }

            return response;
        }
    }
}
