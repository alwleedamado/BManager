using BManager.Application.Entites.FreelancerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BManager.Infrastructure.Data.Config
{
    public class FreelancerConfiguration : IEntityTypeConfiguration<Freelancer>
    {
        public void Configure(EntityTypeBuilder<Freelancer> builder)
        {
            builder.Property(f => f.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(50);
            var specialities = builder.Metadata.FindNavigation(nameof(Freelancer.Specialities));
            specialities?.SetPropertyAccessMode(PropertyAccessMode.Field);
            var telephones = builder.Metadata.FindNavigation(nameof(Freelancer.Telephones));
            telephones?.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
