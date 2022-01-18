using Microsoft.EntityFrameworkCore;
using Revanth.Services.OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revanth.Services.OrderAPI.DbContexts
{
    public class RevanthDBContext:DbContext
    {
        public RevanthDBContext(DbContextOptions<RevanthDBContext> options) : base(options)
        {

        }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
