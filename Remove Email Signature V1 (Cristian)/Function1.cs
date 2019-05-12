using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using HtmlAgilityPack;
using System;
namespace CheckIfIsSignaturePicture
{
    public static class CheckIfIsSignaturePicture
    {
        [FunctionName("CheckIfIsSignaturePicture")]
        [Obsolete]
        public static async Task<object> Run([HttpTrigger]HttpRequestMessage req, TraceWriter log)
        {
            log.Info($"Webhook was triggered!");
            bool isSignature = false;
            try
            {
                string jsonContent = await req.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(jsonContent);
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(data["EmailBody"].Value);
                var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//img");
                foreach (var node in htmlNodes)
                {
                    if (node.OuterHtml.Contains(data["PictureName"].Value))
                    {
                        isSignature = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Info(ex.Message);
            }
            JObject eval =
            new JObject(
            new JProperty("isSignature", isSignature));
            return req.CreateResponse(HttpStatusCode.OK, new
            {
                MsgEval = eval
            });
        }
    }
}

