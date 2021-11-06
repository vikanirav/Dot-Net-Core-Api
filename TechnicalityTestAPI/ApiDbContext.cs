using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TechnicalityTestAPI
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
        : base(options)
        {
        }
        public DbSet<CreditCardCharge> CreditCardCharges { get; set; }
    }

    public class CreditCardCharge
    {

        public int CreditCardChargeId { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime ChargeDateTime { get; set; }

    }

}
