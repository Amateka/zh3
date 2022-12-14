using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace zh_AIYA4A.Models;

public partial class SoftengContext : DbContext
{
    public SoftengContext()
    {
    }

    public SoftengContext(DbContextOptions<SoftengContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Rendelesek> Rendeleseks { get; set; }

    public virtual DbSet<Személy> Személies { get; set; }

    public virtual DbSet<Termék> Terméks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=amateka.database.windows.net;Initial Catalog=SOFTENG;Persist Security Info=True;User ID=Amateka;Password=vevbim-moxnon-8geQqe123;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => new { e.PeopleId, e.ProductId });

            entity.Property(e => e.PeopleId).HasColumnName("PeopleID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SzemélyNév).HasMaxLength(50);
            entity.Property(e => e.Terméknév).HasMaxLength(50);

            entity.HasOne(d => d.People).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PeopleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_People");

            entity.HasOne(d => d.Product).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Product");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.TermékId);

            entity.ToTable("Product");

            entity.Property(e => e.TermékId)
                .ValueGeneratedNever()
                .HasColumnName("TermékID");
            entity.Property(e => e.Terméknév).HasMaxLength(50);
        });

        modelBuilder.Entity<Rendelesek>(entity =>
        {
            entity.HasKey(e => new { e.SzemélyId, e.TermékId });

            entity.ToTable("Rendelesek");

            entity.Property(e => e.SzemélyId).HasColumnName("SzemélyID");
            entity.Property(e => e.TermékId).HasColumnName("TermékID");
            entity.Property(e => e.Személynév).HasMaxLength(50);
            entity.Property(e => e.Terméknév).HasMaxLength(50);
        });

        modelBuilder.Entity<Személy>(entity =>
        {
            entity.ToTable("Személy");

            entity.Property(e => e.SzemélyId)
                .ValueGeneratedNever()
                .HasColumnName("SzemélyID");
            entity.Property(e => e.Név).HasMaxLength(50);
            entity.Property(e => e.RendelésId).HasColumnName("RendelésID");
        });

        modelBuilder.Entity<Termék>(entity =>
        {
            entity.ToTable("Termék");

            entity.Property(e => e.TermékId)
                .ValueGeneratedNever()
                .HasColumnName("TermékID");
            entity.Property(e => e.Terméknév).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
