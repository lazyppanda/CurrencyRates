using CurrencyRates.Controllers;
using Newtonsoft.Json;
using Quartz;
using System.Net;
using System.Threading.Tasks;

namespace CurrencyRates.Models.externalAPIs.CBR
{
    public class CbrJson : IJob
    {
        private CbrJsonData Rates;
        private string ApiLink = "https://www.cbr-xml-daily.ru/daily_json.js";
        private static CbrJson cbrJson = null;

        public CbrJsonData GetRates()
        {
            return Rates;
        }
        private CbrJson()
        {
            GetNewData();
        }

        public static CbrJson Create()
        {
            if (cbrJson == null)
            {
                cbrJson = new CbrJson();
            }
            return cbrJson;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Factory.StartNew(() => GetNewData());
        }

        private void GetNewData()
        {
            WebClient wc = new WebClient();
            var json = wc.DownloadString(ApiLink);
            Rates = JsonConvert.DeserializeObject<CbrJsonData>(json);
        }
    }
}
