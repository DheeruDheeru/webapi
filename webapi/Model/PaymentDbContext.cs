using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Model;

namespace webapi.Model
{
    public class PaymentDbContext:DbContext
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options)
        {

        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
