﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjP;

#nullable disable

namespace ProjP.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220604215031_Wypozyczalnia")]
    partial class Wypozyczalnia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjP.Data.Faktura", b =>
                {
                    b.Property<int>("FakturaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FakturaId"), 1L, 1);

                    b.Property<DateTime>("DataWystawienia")
                        .HasColumnType("datetime2");

                    b.Property<string>("NIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FakturaId");

                    b.ToTable("Faktura");
                });

            modelBuilder.Entity("ProjP.Data.Klient", b =>
                {
                    b.Property<string>("PeselKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Imię")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrTelefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("PeselKey");

                    b.ToTable("Klient");
                });

            modelBuilder.Entity("ProjP.Data.Pracownik", b =>
                {
                    b.Property<int>("PracownikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PracownikId"), 1L, 1);

                    b.Property<string>("ImięPracownik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazwiskoPracownik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrTelefonu")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Stanowisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PracownikId");

                    b.ToTable("Pracownik");
                });

            modelBuilder.Entity("ProjP.Data.Rower", b =>
                {
                    b.Property<int>("RowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RowerId"), 1L, 1);

                    b.Property<int>("Biegi")
                        .HasColumnType("int");

                    b.Property<string>("Kolor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RowerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("RozmiarOpon")
                        .HasColumnType("real");

                    b.Property<float>("RozmiarRamy")
                        .HasColumnType("real");

                    b.HasKey("RowerId");

                    b.ToTable("Rower");
                });

            modelBuilder.Entity("ProjP.Data.Wypożyczenie", b =>
                {
                    b.Property<int>("WypożyczenieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WypożyczenieId"), 1L, 1);

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataOddania")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataWypożyczenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("KlientPeselKey")
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("RowerId")
                        .HasColumnType("int");

                    b.HasKey("WypożyczenieId");

                    b.HasIndex("KlientPeselKey");

                    b.HasIndex("RowerId");

                    b.ToTable("Wypożyczenie");
                });

            modelBuilder.Entity("ProjP.Data.Wypożyczenie", b =>
                {
                    b.HasOne("ProjP.Data.Klient", null)
                        .WithMany("Wypożyczenia")
                        .HasForeignKey("KlientPeselKey");

                    b.HasOne("ProjP.Data.Rower", null)
                        .WithMany("Wypożyczenia")
                        .HasForeignKey("RowerId");
                });

            modelBuilder.Entity("ProjP.Data.Klient", b =>
                {
                    b.Navigation("Wypożyczenia");
                });

            modelBuilder.Entity("ProjP.Data.Rower", b =>
                {
                    b.Navigation("Wypożyczenia");
                });
#pragma warning restore 612, 618
        }
    }
}
