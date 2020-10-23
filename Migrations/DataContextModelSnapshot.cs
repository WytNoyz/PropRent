﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PropertyRental.Models;

namespace PropertyRental.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("PropertyRental.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bathrooms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bedrooms")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherDetails")
                        .HasColumnType("TEXT");

                    b.Property<int>("PropertySize")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PropertyStories")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PropertyType")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
