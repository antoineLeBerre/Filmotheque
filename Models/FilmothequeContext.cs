using Filmotheque.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Filmotheque.Models
{
    public class FilmothequeContext : DbContext
    {
        protected FilmothequeContext()
        {
        }

        public FilmothequeContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurations());
        }
    }
}