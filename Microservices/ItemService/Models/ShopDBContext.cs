﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ItemService.Models
{
    public partial class ShopDBContext : DbContext
    {
        public ShopDBContext()
        {
        }

        public ShopDBContext(DbContextOptions<ShopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1UI4VQI\\SQLEXPRESS;Initial Catalog=ShopDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__items__56A22C920876C828");

                entity.ToTable("items");

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Orderid)
                    .HasName("PK__orders__080E37754649221E");

                entity.ToTable("orders");

                entity.Property(e => e.Orderid)
                    .HasColumnName("orderid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Itemid)
                    .HasColumnName("itemid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Itemid)
                    .HasConstraintName("FK__orders__itemid__1273C1CD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
