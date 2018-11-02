using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication4.Models
{
    public partial class Test1Context : DbContext
    {
        public Test1Context()
        {
        }

        public Test1Context(DbContextOptions<Test1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cats> Cats { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Initial> Initial { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CLL9FE8\\SQLEXPRESS;Initial Catalog=Test1;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cats>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId)
                    .HasColumnName("CatID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CatName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Custid);

                entity.Property(e => e.Custid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CustLastname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InitialCode).HasColumnName("initialCode");
            });

            modelBuilder.Entity<Initial>(entity =>
            {
                entity.HasKey(e => e.InitialCode);

                entity.Property(e => e.InitialCode)
                    .HasColumnName("initialCode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.InitialName)
                    .HasColumnName("initialName")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CatCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Descritption)
                    .HasColumnName("descritption")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Unitperprice).HasColumnName("unitperprice");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.UnitName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
