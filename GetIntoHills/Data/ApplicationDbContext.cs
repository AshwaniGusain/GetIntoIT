using GetIntoHills.shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetIntoHills.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserDetails> userDetails { get; set; }

        public DbSet<DriverDetails> driverDetails { get; set; }

        public DbSet<VehicleDetails> vehicleDetails { get; set; }

        public DbSet<ClassWaitTaxi> waittaxi { get; set; }

        public DbSet<RideOn> rideon { get; set; }

    }
}
