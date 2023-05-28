using Microsoft.EntityFrameworkCore;
using Pustok.Models;
using System.Dynamic;

namespace Pustok.DAL
{
    public class PustokDbContext : DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext> opt) : base(opt)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BookTag> BookTag { get; set; }
        public DbSet<BookImage> BookImage { get; set; }
        public DbSet<Settings> Settings { get; set; }   



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookTag>(x => x.HasKey(bt => new { bt.BookId,bt.TagId }));
            modelBuilder.Entity<Settings>(x => x.HasKey(s => s.Key));       
        }
    }
}
