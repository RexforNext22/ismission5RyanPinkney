﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ismission5RyanPinkney.Models;

namespace ismission5RyanPinkney.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("ismission5RyanPinkney.Models.Category", b =>
                {
                    b.Property<int>("Category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("sCategory_name")
                        .HasColumnType("TEXT");

                    b.HasKey("Category_id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Category_id = 1,
                            sCategory_name = "Action/Adventure"
                        },
                        new
                        {
                            Category_id = 2,
                            sCategory_name = "Comedy"
                        },
                        new
                        {
                            Category_id = 3,
                            sCategory_name = "Drama"
                        },
                        new
                        {
                            Category_id = 4,
                            sCategory_name = "Family"
                        },
                        new
                        {
                            Category_id = 5,
                            sCategory_name = "Horror/Suspense"
                        },
                        new
                        {
                            Category_id = 6,
                            sCategory_name = "Miscellaneous"
                        },
                        new
                        {
                            Category_id = 7,
                            sCategory_name = "Television"
                        },
                        new
                        {
                            Category_id = 8,
                            sCategory_name = "VHS"
                        });
                });

            modelBuilder.Entity("ismission5RyanPinkney.Models.Movie", b =>
                {
                    b.Property<int>("movie_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Category_id")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("bIsEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("sDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sLentToName")
                        .HasColumnType("TEXT");

                    b.Property<string>("sNotes")
                        .HasColumnType("TEXT");

                    b.Property<string>("sRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sYear")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("movie_id");

                    b.HasIndex("Category_id");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            movie_id = 1,
                            Category_id = 1,
                            bIsEdited = false,
                            sDirector = "Joss Whedon",
                            sLentToName = "",
                            sNotes = "",
                            sRating = "PG-13",
                            sTitle = "Avenger, The",
                            sYear = "2012"
                        },
                        new
                        {
                            movie_id = 2,
                            Category_id = 1,
                            bIsEdited = false,
                            sDirector = "Tim Burton",
                            sLentToName = "",
                            sNotes = "",
                            sRating = "PG-13",
                            sTitle = "Batman",
                            sYear = "1989"
                        },
                        new
                        {
                            movie_id = 3,
                            Category_id = 1,
                            bIsEdited = false,
                            sDirector = "Joel Schumacher",
                            sLentToName = "",
                            sNotes = "",
                            sRating = "PG-13",
                            sTitle = "Batman & Robin",
                            sYear = "1997"
                        });
                });

            modelBuilder.Entity("ismission5RyanPinkney.Models.Movie", b =>
                {
                    b.HasOne("ismission5RyanPinkney.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
