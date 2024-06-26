﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Staris.Domain.Entities;

namespace Staris.Infra.Data.Configurations
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.Property(v => v.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(v => v.Model)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(v => v.Manufacturer)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(v => v.Cost)
                .HasColumnType("real")
                .IsRequired();

            builder.Property(v => v.Lenght)
                .HasColumnType("real")
                .IsRequired();

            builder.Property(v => v.MaxSpeed)
                .HasColumnType("real")
                .IsRequired();

            builder.Property(v => v.Crew)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(v => v.Passengers)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(v => v.CargoCapacity)
                .HasColumnType("real")
                .IsRequired();

            builder.Property(v => v.Consumables)
                .HasColumnType("integer")
                .IsRequired();

            builder.Property(v => v.ConsumablesPeriod)
                .HasColumnType("text")
                .IsRequired(false);

            builder.Property(v => v.Class)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(v => v.Type)
                .HasColumnType("integer")
                .IsRequired();

            builder.HasKey(v => v.Id);

            builder.ToTable("Vehicles");
           
        }
    }
}
