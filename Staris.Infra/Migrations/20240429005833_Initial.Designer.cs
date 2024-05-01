﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Staris.Infra.Data;

#nullable disable

namespace Staris.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429005833_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Staris.Domain.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BirthYear")
                        .HasColumnType("text");

                    b.Property<string>("BirthYearPeriod")
                        .IsRequired()
                        .HasColumnType("numeric");

                    b.Property<string>("EyeColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<short>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("HairColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HomeWorldId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mass")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SkinColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HomeWorldId");

                    b.ToTable("Characters", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.CharacterFilm", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FilmId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("CharacterFilms", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Episode")
                        .HasColumnType("integer");

                    b.Property<string>("OpeningCrawl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Films", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Climate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Diameter")
                        .HasColumnType("integer");

                    b.Property<decimal>("Gravity")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrbitalPeriod")
                        .HasColumnType("integer");

                    b.Property<long>("Population")
                        .HasColumnType("integer");

                    b.Property<int>("RotationPeriod")
                        .HasColumnType("integer");

                    b.Property<decimal>("SurfaceWater")
                        .HasColumnType("numeric");

                    b.Property<string>("Terrain")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Planets", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.PlanetCharacter", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlanetId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "PlanetId");

                    b.HasIndex("PlanetId");

                    b.ToTable("PlanetCharacters", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.PlanetFilm", b =>
                {
                    b.Property<int>("PlanetId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FilmId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlanetId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("PlanetFilm", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.Starship", b =>
                {
                    b.Property<int>("VehicleId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("HyperdriveRating")
                        .HasColumnType("real");

                    b.Property<int>("MaximumMegalights")
                        .HasColumnType("integer");

                    b.HasKey("VehicleId");

                    b.ToTable("Starships", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.StarshipFilm", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StartshipId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmId", "StartshipId");

                    b.HasIndex("StartshipId");

                    b.ToTable("StarshipFilms", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CargoCapacity")
                        .HasColumnType("real");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Consumables")
                        .HasColumnType("integer");

                    b.Property<decimal>("Cost")
                        .HasColumnType("real");

                    b.Property<int>("Crew")
                        .HasColumnType("integer");

                    b.Property<decimal>("Lenght")
                        .HasColumnType("real");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("MaxSpeed")
                        .HasColumnType("real");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Passengers")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Vehicles", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.VehicleFilm", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehicleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FilmId", "VehicleId");

                    b.HasIndex("VehicleId");

                    b.ToTable("VeichleFilms", (string)null);
                });

            modelBuilder.Entity("Staris.Domain.Entities.Character", b =>
                {
                    b.HasOne("Staris.Domain.Entities.Planet", "HomeWorld")
                        .WithMany()
                        .HasForeignKey("HomeWorldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Planets_Characters");

                    b.Navigation("HomeWorld");
                });

            modelBuilder.Entity("Staris.Domain.Entities.CharacterFilm", b =>
                {
                    b.HasOne("Staris.Domain.Entities.Character", "Character")
                        .WithMany("Movies")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_characters_films");

                    b.HasOne("Staris.Domain.Entities.Film", "Film")
                        .WithMany("Characters")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_films_characters");

                    b.Navigation("Character");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("Staris.Domain.Entities.PlanetCharacter", b =>
                {
                    b.HasOne("Staris.Domain.Entities.Character", "Character")
                        .WithMany("PlanetsOfResidence")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Characters_PlanetCharacters");

                    b.HasOne("Staris.Domain.Entities.Planet", "Planet")
                        .WithMany("Residents")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Planerts_PlanetCharacters");

                    b.Navigation("Character");

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("Staris.Domain.Entities.PlanetFilm", b =>
                {
                    b.HasOne("Staris.Domain.Entities.Film", "Film")
                        .WithMany("Planets")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_films_planets");

                    b.HasOne("Staris.Domain.Entities.Planet", "Planet")
                        .WithMany("Movies")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_planets_films");

                    b.Navigation("Film");

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("Staris.Domain.Entities.Starship", b =>
                {
                    b.HasOne("Staris.Domain.Entities.Vehicle", "Vehicle")
                        .WithOne("Starship")
                        .HasForeignKey("Staris.Domain.Entities.Starship", "VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Vechicles_Starships");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Staris.Domain.Entities.StarshipFilm", b =>
                {
                    b.HasOne("Staris.Domain.Entities.Film", "Film")
                        .WithMany("Starships")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staris.Domain.Entities.Starship", "Startship")
                        .WithMany("Films")
                        .HasForeignKey("StartshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Startship");
                });

            modelBuilder.Entity("Staris.Domain.Entities.VehicleFilm", b =>
                {
                    b.HasOne("Staris.Domain.Entities.Film", "Film")
                        .WithMany("Vehicles")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staris.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany("Films")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Staris.Domain.Entities.Character", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("PlanetsOfResidence");
                });

            modelBuilder.Entity("Staris.Domain.Entities.Film", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("Planets");

                    b.Navigation("Starships");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Staris.Domain.Entities.Planet", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Residents");
                });

            modelBuilder.Entity("Staris.Domain.Entities.Starship", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("Staris.Domain.Entities.Vehicle", b =>
                {
                    b.Navigation("Films");

                    b.Navigation("Starship");
                });
#pragma warning restore 612, 618
        }
    }
}
