using asvslabs.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication.API.Models
{
    public class IdentityContext : IdentityDbContext
    {
        public DbSet<JobModel> Jobs { get; set; }
        public DbSet<MessagesModel> Messages { get; set; }

        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }
    }
}