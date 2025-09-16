using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExcelTest.Models;

public partial class saEntities : DbContext
{
    public saEntities()
    {
    }

    public saEntities(DbContextOptions<saEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<Pc> Pcs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=EMREKAYAYIKAN\\SQLEXPRESS;Database=sa;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pc>(entity =>
        {
            entity.Property(e => e.Açıklaması).IsFixedLength();
            entity.Property(e => e.Bilgisayar).IsFixedLength();
            entity.Property(e => e.Sorunu).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
