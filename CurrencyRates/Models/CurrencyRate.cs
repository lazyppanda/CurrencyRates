using System;
using System.ComponentModel.DataAnnotations;


namespace CurrencyRates.Models
{
    public class CurrencyRate
    {
        public int Id { get; set; }
        public string Json { get; set; }
        public DateTime DateOfReceipt { get; set; }
    }
}
