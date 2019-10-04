﻿// <auto-generated />
using System;
using BDSA2019.Lecture06.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BDSA2019.Lecture06.Entities.Migrations
{
    [DbContext(typeof(SuperheroContext))]
    [Migration("20191004090959_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("BDSA2019.Lecture06.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BDSA2019.Lecture06.Entities.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("BDSA2019.Lecture06.Entities.Superhero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlterEgo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int?>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstAppearance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Occupation")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Superheroes");
                });

            modelBuilder.Entity("BDSA2019.Lecture06.Entities.SuperheroPower", b =>
                {
                    b.Property<int>("SuperheroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PowerId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SuperheroId", "PowerId");

                    b.HasIndex("PowerId");

                    b.ToTable("SuperheroPowers");
                });

            modelBuilder.Entity("BDSA2019.Lecture06.Entities.Superhero", b =>
                {
                    b.HasOne("BDSA2019.Lecture06.Entities.City", "City")
                        .WithMany("Superheroes")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("BDSA2019.Lecture06.Entities.SuperheroPower", b =>
                {
                    b.HasOne("BDSA2019.Lecture06.Entities.Power", "Power")
                        .WithMany("Superheroes")
                        .HasForeignKey("PowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDSA2019.Lecture06.Entities.Superhero", "Superhero")
                        .WithMany("Powers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
