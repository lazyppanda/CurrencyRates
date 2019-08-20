using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyRates.Models
{
    public class CurrencyRatesContext : DbContext
    {
        public CurrencyRatesContext(DbContextOptions<CurrencyRatesContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CurrencyRate> CurrencyRates { get; set; }
    }
}