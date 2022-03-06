using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.ObserverPattern.Models;

namespace AspNetCoreDesignPatterns.BaseProject.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {
        }
        public DbSet<Discount> Discounts { get; set; }
    }
}
