﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperHero.Data;

namespace SuperHero.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210604200313_addingrelationbetweenHeroAndInfoModels")]
    partial class addingrelationbetweenHeroAndInfoModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SuperHero.Models.HeroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Hero");
                });

            modelBuilder.Entity("SuperHero.Models.InfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alignment")
                        .HasColumnType("text");

                    b.Property<string>("Combat")
                        .HasColumnType("text");

                    b.Property<string>("EyeColor")
                        .HasColumnType("text");

                    b.Property<string>("FirstAppearance")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("HairColor")
                        .HasColumnType("text");

                    b.Property<string>("Height")
                        .HasColumnType("text");

                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Intelligence")
                        .HasColumnType("text");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("text");

                    b.Property<string>("Power")
                        .HasColumnType("text");

                    b.Property<string>("Race")
                        .HasColumnType("text");

                    b.Property<string>("Speed")
                        .HasColumnType("text");

                    b.Property<string>("Strength")
                        .HasColumnType("text");

                    b.Property<string>("Weight")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HeroId")
                        .IsUnique();

                    b.ToTable("Info");
                });

            modelBuilder.Entity("SuperHero.Models.InfoModel", b =>
                {
                    b.HasOne("SuperHero.Models.HeroModel", "Hero")
                        .WithOne("Info")
                        .HasForeignKey("SuperHero.Models.InfoModel", "HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
