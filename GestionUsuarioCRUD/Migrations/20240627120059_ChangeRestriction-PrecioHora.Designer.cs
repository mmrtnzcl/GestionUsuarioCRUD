﻿// <auto-generated />
using System;
using GestionUsuarioCRUD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionUsuarioCRUD.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240627120059_ChangeRestriction-PrecioHora")]
    partial class ChangeRestrictionPrecioHora
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GestionUsuarioCRUD.Models.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal?>("Bonificacion")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("HorasTrabajadas")
                        .HasColumnType("decimal(2,1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal?>("PrecioHora")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("SalarioBase")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("TipoEmpleado")
                        .HasColumnType("int");

                    b.Property<decimal?>("UltimoSalarioTotal")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
