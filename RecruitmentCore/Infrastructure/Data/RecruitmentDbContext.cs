using Microsoft.EntityFrameworkCore;
using Recruitment.Domain.Entities;

namespace Recruitment.Infrastructure.Data
{
    public class RecruitmentDbContext : DbContext
    {
        public RecruitmentDbContext (DbContextOptions <RecruitmentDbContext> options) : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Feedback> Feedback { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Application>()
                .HasKey(a => new { a.CandidateID, a.JobID });

            //modelBuilder.Entity<Application>()
            //    .HasOne(a => a.Candidate)
            //    .WithMany(x => x.Applications)
            //    .HasForeignKey(y => y.CandidateID);

            //modelBuilder.Entity<Application>()
            //    .HasOne(a => a.Job)
            //    .WithMany(x => x.Applications)
            //    .HasForeignKey(y => y.JobID);

            //modelBuilder.Entity<Feedback>()
            //    .HasOne(fb => fb.Application)
            //    .WithMany(x => x.Feedbacks)
            //    .HasForeignKey(y => y.ApplicationID);

            modelBuilder.Entity<Job>()
            .HasKey(j => j.JobID);
        }
    }
}
