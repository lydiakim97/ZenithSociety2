using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebsite.Models
{
    public class ZenithContext : IdentityDbContext<ApplicationUser>
    {
        public ZenithContext(DbContextOptions<ZenithContext> options)
            : base(options) { }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Event> Events { get; set; }

    }
}
