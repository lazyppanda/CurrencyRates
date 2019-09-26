using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyRates.Models.externalAPIs
{
    //Abstract from the source of exchange rates
    public abstract class ExternalRates
    {
        protected CommonRate[] Rates { get; set; }
        protected DateTime LastUpdate { get; set; } 
        public abstract ExternalRates GetRates();
    }

    public class CommonRate
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Nominal { get; set; }
    }
}
