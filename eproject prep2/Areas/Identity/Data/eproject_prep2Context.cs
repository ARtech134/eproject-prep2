using eproject_prep2.Areas.Identity.Data;
using eproject_prep2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eproject_prep2.Data;

public class eproject_prep2Context : IdentityDbContext<eproject_prep2User>
{
    public eproject_prep2Context(DbContextOptions<eproject_prep2Context> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
