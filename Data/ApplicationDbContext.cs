using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyPortfolio;
using MyPortfolio.Models;

namespace MyPortfolio.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Course>? Course { get; set; }
    public DbSet<Project>? Project { get; set; }
    public DbSet<Category>? Category { get; set; }
    public DbSet<SocialMedia>? SocialMedia { get; set; }
}
