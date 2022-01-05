using Microsoft.EntityFrameworkCore;
using Revanth.Services.CouponAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revanth.Services.CouponAPI.DbContexts
{
    public class RevanthDBContext:DbContext
    {
        public RevanthDBContext(DbContextOptions<RevanthDBContext> options) : base(options)
        {

        }
        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "10OFF",
                DiscountAmount = 10
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "20OFF",
                DiscountAmount = 20
            });

        }
    }
}
