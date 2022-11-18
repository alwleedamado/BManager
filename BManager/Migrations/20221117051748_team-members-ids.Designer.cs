﻿// <auto-generated />
using System;
using BManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BManager.Migrations
{
    [DbContext(typeof(BManagerDbContext))]
    [Migration("20221117051748_team-members-ids")]
    partial class teammembersids
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BManager.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BManager.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialityTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("SpecialityTypeId");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("BManager.Models.SpecialityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("SpecialityType");
                });

            modelBuilder.Entity("BManager.Models.Telephone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("UpdatedOn")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Telephone");
                });

            modelBuilder.Entity("BManager.Models.Speciality", b =>
                {
                    b.HasOne("BManager.Models.Person", null)
                        .WithMany("Specialities")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BManager.Models.SpecialityType", "SpecialityType")
                        .WithMany()
                        .HasForeignKey("SpecialityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SpecialityType");
                });

            modelBuilder.Entity("BManager.Models.Telephone", b =>
                {
                    b.HasOne("BManager.Models.Person", null)
                        .WithMany("Telephones")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BManager.Models.Person", b =>
                {
                    b.Navigation("Specialities");

                    b.Navigation("Telephones");
                });
#pragma warning restore 612, 618
        }
    }
}
