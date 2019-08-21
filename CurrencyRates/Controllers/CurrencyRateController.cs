using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CurrencyRates.Controllers
{
    public class CurrencyRateController : Controller
    {
        string ApiLink = "https://www.cbr-xml-daily.ru/daily_json.js";
        // GET: /<controller>/
        public IActionResult Index()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(ApiLink);
                JsonApi jsonApi = JsonConvert.DeserializeObject<JsonApi>(json);
                ViewData["AUD"] = jsonApi.Valute["AUD"].ID;

            }
                return View();
        }
    }
}
