﻿// <auto-generated />
using System;
using Dominio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(WebApiContext))]
    partial class WebApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdstateFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdstateFk" }, "IX_city_IdstateFk");

                    b.ToTable("city", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("country", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateRegister")
                        .HasColumnType("date")
                        .HasColumnName("date_register");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdcityFk")
                        .HasColumnType("int");

                    b.Property<string>("Idcustomer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdTipoPersonaFk" }, "IX_customer_IdTipoPersonaFk");

                    b.HasIndex(new[] { "IdcityFk" }, "IX_customer_IdcityFk");

                    b.ToTable("customer", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.PersonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("person_type", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdcountryFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdcountryFk" }, "IX_state_IdcountryFk");

                    b.ToTable("state", (string)null);
                });

            modelBuilder.Entity("Dominio.Entities.City", b =>
                {
                    b.HasOne("Dominio.Entities.State", "IdstateFkNavigation")
                        .WithMany("Cities")
                        .HasForeignKey("IdstateFk")
                        .IsRequired();

                    b.Navigation("IdstateFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.Customer", b =>
                {
                    b.HasOne("Dominio.Entities.PersonType", "IdTipoPersonaFkNavigation")
                        .WithMany("Customers")
                        .HasForeignKey("IdTipoPersonaFk")
                        .IsRequired();

                    b.HasOne("Dominio.Entities.City", "IdcityFkNavigation")
                        .WithMany("Customers")
                        .HasForeignKey("IdcityFk")
                        .IsRequired();

                    b.Navigation("IdTipoPersonaFkNavigation");

                    b.Navigation("IdcityFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.State", b =>
                {
                    b.HasOne("Dominio.Entities.Country", "IdcountryFkNavigation")
                        .WithMany("States")
                        .HasForeignKey("IdcountryFk")
                        .IsRequired();

                    b.Navigation("IdcountryFkNavigation");
                });

            modelBuilder.Entity("Dominio.Entities.City", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Dominio.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Dominio.Entities.PersonType", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("Dominio.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}