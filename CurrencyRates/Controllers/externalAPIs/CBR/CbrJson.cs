using CurrencyRates.Controllers;
using Newtonsoft.Json;
using Quartz;
using System.Net;
using System.Threading.Tasks;

namespace CurrencyRates.Models.externalAPIs.CBR
{
    public class CbrJson : ExternalRates,IJob
    {
        private readonly string ApiLink = "https://www.cbr-xml-daily.ru/daily_json.js";
        private ExternalRates externalRates = null;

        
        private static CbrJson cbrJson = null;
        private CbrJson()
        {
            GetNewData();
        }

        public static CbrJson Create(CurrencyRatesContext context)
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
            using (WebClient wc = new WebClient())
            { 
                var json = wc.DownloadString(ApiLink);
                var parsedJson = JsonConvert.DeserializeObject<CbrJsonData>(json);

            }
        }

        public override ExternalRates GetRates()
        {
            foreach (CommonRate item in this.Rates)
            {

            }
            return null;
        }
    }
}
