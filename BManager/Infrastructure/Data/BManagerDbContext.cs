using BManager.Application.Entites.FreelancerAggregate;
using BManager.Application.Entites.TeamAggregate;
using Microsoft.EntityFrameworkCore;

namespace BManager.Infrastructure.Data
{
    public class BManagerDbContext : DbContext
    {
        public DbSet<Freelancer> Freelancers { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public BManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("FreelancerId");
            modelBuilder.HasSequence<int>("ProjectId");
            modelBuilder.HasSequence<int>("TeamId");
            modelBuilder.HasSequence<int>("FreelancerId");


            modelBuilder.Entity<Telephone>().Property(e => e.PhoneType)
                .HasConversion<string>();


            base.OnModelCreating(modelBuilder);
        }


    }
}
