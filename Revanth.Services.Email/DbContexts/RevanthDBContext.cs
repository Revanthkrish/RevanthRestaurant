using Microsoft.EntityFrameworkCore;
using Revanth.Services.Email.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Revanth.Services.Email.DbContexts
{
    public class RevanthDBContext:DbContext
    {
        public RevanthDBContext(DbContextOptions<RevanthDBContext> options) : base(options)
        {

        }
        public DbSet<EmailLog> EmailLogs { get; set; }

    }
}
