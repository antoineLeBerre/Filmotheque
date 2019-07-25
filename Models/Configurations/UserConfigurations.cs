using Filmotheque.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Filmotheque.Models.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("f_User");
            builder.HasIndex(p => new { p.Email})
                .IsUnique(true);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
            
            builder.Property(p => p.Prenom)
                .HasMaxLength(25)
                .IsRequired();
            
            builder.Property(p => p.Nom)
                .HasMaxLength(75)
                .IsRequired();
            
            builder.Property(p => p.Ville)
                .HasMaxLength(75)
                .IsRequired();
            
            builder.Property(p => p.Pays)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(p => p.Age)
                .HasMaxLength(110)
                .IsRequired();
            
            builder.Property(p => p.Email)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}