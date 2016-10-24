using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplicationBasic.Models;

namespace WebApplicationBasic.Migrations
{
    [DbContext(typeof(MusicContext))]
    partial class MusicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("WebApplicationBasic.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");
                });
        }
    }
}
