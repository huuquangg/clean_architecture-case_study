using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ParkingSlot.Infrastructure.Models;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Slot> Slots { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Slot>(entity =>
        {
            entity.ToTable("slot");

            entity.Property(e => e.FreeAt).HasColumnType("DATETIME");
            entity.Property(e => e.IsOccupied).HasColumnType("BIT");
            entity.Property(e => e.Name).HasColumnType("VARCHAR(255)");
            entity.Property(e => e.OccupiedAt).HasColumnType("DATETIME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
