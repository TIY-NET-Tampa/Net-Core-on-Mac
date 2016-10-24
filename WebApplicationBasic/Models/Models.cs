using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplicationBasic.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./database.db");
        }

        public DbSet<Album> Albums { get; set; }
    }

    public class Album
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
    }
}