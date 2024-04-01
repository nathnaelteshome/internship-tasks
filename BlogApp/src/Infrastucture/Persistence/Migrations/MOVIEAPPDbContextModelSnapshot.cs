﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(MOVIEAPPDbContext))]
    partial class MOVIEAPPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entites.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address 1",
                            Location = "Location 1",
                            Name = "Cinema 1",
                            Phone = "Phone 1"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address 2",
                            Location = "Location 2",
                            Name = "Cinema 2",
                            Phone = "Phone 2"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Address 3",
                            Location = "Location 3",
                            Name = "Cinema 3",
                            Phone = "Phone 3"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Address 4",
                            Location = "Location 4",
                            Name = "Cinema 4",
                            Phone = "Phone 4"
                        });
                });

            modelBuilder.Entity("Domain.Entites.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseYear")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Genre 1",
                            ReleaseYear = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Movie 1"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Genre 2",
                            ReleaseYear = new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Movie 2"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Genre 3",
                            ReleaseYear = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Movie 3"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Genre 4",
                            ReleaseYear = new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Movie 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
