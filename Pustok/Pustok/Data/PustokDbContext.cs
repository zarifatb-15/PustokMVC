// using Microsoft.EntityFrameworkCore;
// using Pustok.Data.Configurations;
// using Pustok.Models;
//
// namespace Pustok.Data;
//
// public class PustokDbContext: DbContext
// {
//     public PustokDbContext(DbContextOptions<PustokDbContext> options) : base(options)
//     {
//     }
//
//     public DbSet<Book> Books { get; set; }
//     public DbSet<Author> Authors { get; set; }
//
//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         modelBuilder.ApplyConfiguration(new BookConfiguration());
//         modelBuilder.ApplyConfiguration<BookTag>(new BookTagConfiguration());
//
//         base.OnModelCreating(modelBuilder);
//     }
// }
//
//
