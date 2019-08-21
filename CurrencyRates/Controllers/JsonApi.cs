using System;
using System.Collections.Generic;

namespace CurrencyRates.Controllers
{
    internal class JsonApi
    {
        public DateTime Date { get; set; }
        public DateTime PreviousDate { get; set; }
        public string PreviousURL { get; set; }
        public DateTime Timestamp { get; set; }

        public IDictionary<string, Rate> Valute { get; set; }
    }

    public class Rate
    {
        public string ID { get; set; }
        public int NumCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double Previous { get; set; }
    }
}