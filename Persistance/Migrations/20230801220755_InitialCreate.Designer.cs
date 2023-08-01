﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Umb.Persistance.Context;

#nullable disable

namespace Umb.Persistance.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230801220755_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Umb.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedTime");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeletedTime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2023, 8, 2, 1, 7, 55, 469, DateTimeKind.Local).AddTicks(1454),
                            IsDeleted = false,
                            Name = "bora"
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2023, 8, 2, 1, 7, 55, 469, DateTimeKind.Local).AddTicks(1472),
                            IsDeleted = false,
                            Name = "cetin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}