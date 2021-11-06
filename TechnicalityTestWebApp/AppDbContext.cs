using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TechnicalityTestWebApp;

namespace TechnicalityTestWebApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Payment> Payments { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime PaymentDateTime { get; set; }
        public decimal Amount { get; set; }
        public int? CreditCardChargeId { get; set; }
    }

}

