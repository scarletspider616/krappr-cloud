using api.Domain.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace api
{
    public class ApiDbContext : DbContext
    {
    
        public ApiDbContext(string connectionString) : base(connectionString)
        {
        }
        
        public DbSet<Bathroom> Bathrooms { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}