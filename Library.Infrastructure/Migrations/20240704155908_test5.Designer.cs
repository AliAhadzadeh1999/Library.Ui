﻿// <auto-generated />
using Library.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20240704155908_test5")]
    partial class test5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Library.Model.Models.Dr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MedicalEducationNumber")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Dr");
                });

            modelBuilder.Entity("Library.Model.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ExpireDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InsuranceTypeId")
                        .HasColumnType("int");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceTypeId")
                        .IsUnique();

                    b.HasIndex("PersonId");

                    b.ToTable("Insurance");
                });

            modelBuilder.Entity("Library.Model.Models.InsuranceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InsuranceType");
                });

            modelBuilder.Entity("Library.Model.Models.Labratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LabratoryTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LabratoryTypeId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("Labratory");
                });

            modelBuilder.Entity("Library.Model.Models.LabratoryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("LabratoryType");
                });

            modelBuilder.Entity("Library.Model.Models.LoginAccess", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoginAccess");
                });

            modelBuilder.Entity("Library.Model.Models.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MedicineTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicineTypeId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("Medicine");
                });

            modelBuilder.Entity("Library.Model.Models.MedicineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("MedicineType");
                });

            modelBuilder.Entity("Library.Model.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Library.Model.Models.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DrId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DrId");

                    b.HasIndex("PersonId");

                    b.ToTable("Prescription");
                });

            modelBuilder.Entity("Library.Model.Models.Radiology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("RadiologyTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrescriptionId");

                    b.HasIndex("RadiologyTypeId");

                    b.ToTable("Radiology");
                });

            modelBuilder.Entity("Library.Model.Models.RadiologyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("RadiologyType");
                });

            modelBuilder.Entity("Library.Model.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Library.Model.Models.Insurance", b =>
                {
                    b.HasOne("Library.Model.Models.InsuranceType", "InsuranceType")
                        .WithOne("Insurance")
                        .HasForeignKey("Library.Model.Models.Insurance", "InsuranceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Models.Person", "Person")
                        .WithMany("Insurances")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsuranceType");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Library.Model.Models.Labratory", b =>
                {
                    b.HasOne("Library.Model.Models.LabratoryType", "LabratoryType")
                        .WithMany("Labratorys")
                        .HasForeignKey("LabratoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Models.Prescription", "Prescription")
                        .WithMany("Labratories")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LabratoryType");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Library.Model.Models.LoginAccess", b =>
                {
                    b.HasOne("Library.Model.Models.User", "User")
                        .WithOne("LoginAccess")
                        .HasForeignKey("Library.Model.Models.LoginAccess", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Library.Model.Models.Medicine", b =>
                {
                    b.HasOne("Library.Model.Models.MedicineType", "MedicineType")
                        .WithMany("Medicine")
                        .HasForeignKey("MedicineTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Models.Prescription", "Prescription")
                        .WithMany("Medicines")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicineType");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Library.Model.Models.Prescription", b =>
                {
                    b.HasOne("Library.Model.Models.Dr", "Dr")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Models.Person", "Person")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dr");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Library.Model.Models.Radiology", b =>
                {
                    b.HasOne("Library.Model.Models.Prescription", "Prescription")
                        .WithMany("Radiologies")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Models.RadiologyType", "RadiologyType")
                        .WithMany("Radiologies")
                        .HasForeignKey("RadiologyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prescription");

                    b.Navigation("RadiologyType");
                });

            modelBuilder.Entity("Library.Model.Models.Dr", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Library.Model.Models.InsuranceType", b =>
                {
                    b.Navigation("Insurance");
                });

            modelBuilder.Entity("Library.Model.Models.LabratoryType", b =>
                {
                    b.Navigation("Labratorys");
                });

            modelBuilder.Entity("Library.Model.Models.MedicineType", b =>
                {
                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("Library.Model.Models.Person", b =>
                {
                    b.Navigation("Insurances");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Library.Model.Models.Prescription", b =>
                {
                    b.Navigation("Labratories");

                    b.Navigation("Medicines");

                    b.Navigation("Radiologies");
                });

            modelBuilder.Entity("Library.Model.Models.RadiologyType", b =>
                {
                    b.Navigation("Radiologies");
                });

            modelBuilder.Entity("Library.Model.Models.User", b =>
                {
                    b.Navigation("LoginAccess");
                });
#pragma warning restore 612, 618
        }
    }
}