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
        string[] valutes ={ "AUS",
                            "AZN",
                            "GBP",
                            "AMD",
                            "BYN",
                            "BGN",
                            "BRL",
                            "HUF",
                            "HKD",
                            "DKK",
                            "USD",
                            "EUR",
                            "INR",
                            "KZT",
                            "CAD",
                            "KGS",
                            "CNY",
                            "MDL",
                            "NOK",
                            "RLN",
                            "RON",
                            "XDR",
                            "SGD",
                            "TJS",
                            "TRY",
                            "TMT",
                            "UZS",
                            "UAH",
                            "CZK",
                            "SEK",
                            "CHF",
                            "ZAR",
                            "KRW",
                            "JPY",
        };
        string ApiLink = "https://www.cbr-xml-daily.ru/daily_json.js";
        // GET: /<controller>/
        public IActionResult Index()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(ApiLink);
                JsonApi Rates = JsonConvert.DeserializeObject<JsonApi>(json);
                ViewData["Valutes"] =  valutes;
                ViewData["Rates"] = Rates;
            }
                return View();
        }
    }
}
