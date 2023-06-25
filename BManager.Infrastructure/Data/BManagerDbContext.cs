using BManager.Application.Entites;
using BManager.Application.Entites.FreelancerAggregate;
using BManager.Application.Entites.TeamAggregate;
using Microsoft.EntityFrameworkCore;

namespace BManager.Infrastructure.Data
{
    public class BManagerDbContext : DbContext
    {
        public DbSet<Freelancer> Freelancers => Set<Freelancer>();
        public DbSet<Speciality> Specialities => Set<Speciality>();
        public DbSet<Team> Teams => Set<Team>();
        public DbSet<Project> Projects => Set<Project>();
        public BManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("FreelancerId");
            modelBuilder.HasSequence<int>("ProjectId");
            modelBuilder.HasSequence<int>("TeamId");
            modelBuilder.HasSequence<int>("FreelancerId");
            base.OnModelCreating(modelBuilder);
        }


    }
}
