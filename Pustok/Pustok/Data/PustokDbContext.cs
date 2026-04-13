using Microsoft.EntityFrameworkCore;
using Pustok.Data.Configurations;
using Pustok.Models;

namespace Pustok.Data;

public class PustokDbContext(DbContextOptions<PustokDbContext> options) : DbContext(options)
{
    public DbSet<Slider> Sliders { get; set; }
    
    public DbSet<Book> Books { get; set; }
    
    public DbSet<Author> Authors { get; set; }
    
    public DbSet<Tag> Tags { get; set; }
    
    public DbSet<BookTag> BookTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.ApplyConfigurationsFromAssembly(typeof(PustokDbContext).Assembly);
       base.OnModelCreating(modelBuilder);
    }
}


