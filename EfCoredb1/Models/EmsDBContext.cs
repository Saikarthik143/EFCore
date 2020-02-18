using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EfCoredb1.Models
{
    public partial class EmsDBContext : DbContext
    {
        public EmsDBContext()
        {
        }

        public EmsDBContext(DbContextOptions<EmsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1UI4VQI\\SQLEXPRESS;Initial Catalog=EmsDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.HasIndex(e => e.ProjectId);

                entity.Property(e => e.Eid).HasMaxLength(5);

                entity.Property(e => e.Designation).HasMaxLength(20);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Joindate).HasColumnType("date");

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.ProjectId);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.IId);

                entity.Property(e => e.IId).HasColumnName("iId");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.IId);

                entity.Property(e => e.Oid).HasColumnName("OId");

                entity.Property(e => e.ArrDate).HasColumnType("date");

                entity.Property(e => e.IId).HasColumnName("iId");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.HasOne(d => d.I)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.IId);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__product__DD37D91A75B6CE7F");

                entity.ToTable("product");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.Enddate).HasColumnType("date");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
