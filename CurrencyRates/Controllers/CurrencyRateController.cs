using CurrencyRates.Models;
using CurrencyRates.Models.externalAPIs.CBR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CurrencyRates.Controllers
{
    public class CurrencyRateController : Controller
    {
        CurrencyRatesContext db;
        CbrJson cbrJson;
        public CurrencyRateController(CurrencyRatesContext context)
        {
            db = context;
            cbrJson = CbrJson.Create(db);
        }

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
            CurrencyRate last = db.CurrencyRates.OrderByDescending(o => o.Id).FirstOrDefault();

            return View();
        }
    }
}
