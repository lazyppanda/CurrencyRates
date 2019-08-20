using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace CurrencyRates.Controllers
{
    public class CurrencyRateController : Controller
    {
        String ApiLink = "https://www.cbr-xml-daily.ru/daily_json.js";
        // GET: /<controller>/
        public IActionResult Index()
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(ApiLink);
                ViewData["Json"] = json;
            }
            return View();
        }
    }
}
