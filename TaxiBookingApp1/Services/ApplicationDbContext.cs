using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaxiBookingApp1.Models;

namespace TaxiBookingApp1.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


     
        public DbSet<Booking> Bookings { get; set; }

    }
}
