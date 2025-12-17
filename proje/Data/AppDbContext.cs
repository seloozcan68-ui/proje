using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<JobPosting> JobPostings { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<Resume> Resumes { get; set; }

        // --- EKLEMEN GEREKEN KISIM BURASI ---
      
    }
}