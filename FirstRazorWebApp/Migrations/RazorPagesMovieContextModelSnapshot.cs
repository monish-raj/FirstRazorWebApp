﻿// <auto-generated />
using System;
using FirstRazorWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirstRazorWebApp.Migrations
{
    [DbContext(typeof(RazorPagesMovieContext))]
    partial class RazorPagesMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("FirstRazorWebApp.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
