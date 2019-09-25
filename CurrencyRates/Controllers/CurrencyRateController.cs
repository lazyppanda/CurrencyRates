using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CurrencyRates.Models.externalAPIs.CBR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CurrencyRates.Controllers
{
    public class CurrencyRateController : Controller
    {

        CbrJson cbrJson = CbrJson.Create();
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

        // GET: /<controller>/
        public IActionResult Index()
        {
            CbrJsonData rates = cbrJson.GetRates();
            return View();
        }
    }
}
