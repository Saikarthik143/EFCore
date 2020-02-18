﻿// <auto-generated />
using System;
using Market.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Market.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200214110442_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Market.Models.Order", b =>
                {
                    b.Property<int>("OId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrDate")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("Date");

                    b.Property<int>("iId")
                        .HasColumnType("int");

                    b.HasKey("OId");

                    b.HasIndex("iId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Market.Models.item", b =>
                {
                    b.Property<int>("iId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("Itemprice")
                        .HasColumnType("int");

                    b.HasKey("iId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Market.Models.Order", b =>
                {
                    b.HasOne("Market.Models.item", "Item")
                        .WithMany()
                        .HasForeignKey("iId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
