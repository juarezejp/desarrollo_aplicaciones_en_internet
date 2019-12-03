﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyecto.Data;

namespace proyecto.Migrations
{
    [DbContext(typeof(aeropuertoCollectionContext))]
    partial class aeropuertoCollectionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("proyecto.Models.Aerolinea", b =>
                {
                    b.Property<int>("IDAerolinea")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ruc");

                    b.HasKey("IDAerolinea");

                    b.ToTable("Aerolinea");
                });

            modelBuilder.Entity("proyecto.Models.Aeropuerto", b =>
                {
                    b.Property<int>("IDAeropuerto")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IDPais");

                    b.Property<string>("nombre")
                        .IsRequired();

                    b.HasKey("IDAeropuerto");

                    b.HasIndex("IDPais");

                    b.ToTable("Aeropuerto");
                });

            modelBuilder.Entity("proyecto.Models.Avion", b =>
                {
                    b.Property<int>("IDAvion")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IDAerolinea");

                    b.Property<int>("capacidad");

                    b.Property<string>("fabricante")
                        .IsRequired();

                    b.Property<string>("tipo")
                        .IsRequired();

                    b.HasKey("IDAvion");

                    b.HasIndex("IDAerolinea");

                    b.ToTable("Avion");
                });

            modelBuilder.Entity("proyecto.Models.Pais", b =>
                {
                    b.Property<int>("IDPais")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("nombre")
                        .IsRequired();

                    b.HasKey("IDPais");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("proyecto.Models.Pasajero", b =>
                {
                    b.Property<int>("IDPasajero")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IDPais");

                    b.Property<string>("amaterno")
                        .IsRequired();

                    b.Property<string>("apaterno");

                    b.Property<int>("clave");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<DateTime>("fecha_nacimiento");

                    b.Property<string>("nombre")
                        .IsRequired();

                    b.Property<int>("num_documento");

                    b.Property<int>("telefono");

                    b.Property<string>("tipo_documento")
                        .IsRequired();

                    b.HasKey("IDPasajero");

                    b.HasIndex("IDPais");

                    b.ToTable("Pasajero");
                });

            modelBuilder.Entity("proyecto.Models.Aeropuerto", b =>
                {
                    b.HasOne("proyecto.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("IDPais")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("proyecto.Models.Avion", b =>
                {
                    b.HasOne("proyecto.Models.Aerolinea", "Aerolinea")
                        .WithMany()
                        .HasForeignKey("IDAerolinea")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("proyecto.Models.Pasajero", b =>
                {
                    b.HasOne("proyecto.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("IDPais")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
