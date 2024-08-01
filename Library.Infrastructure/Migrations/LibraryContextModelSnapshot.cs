﻿// <auto-generated />
using Library.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Library.Model.Models.Doctor", b =>
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

                    b.ToTable("Doctor");
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

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceTypeId")
                        .IsUnique();

                    b.HasIndex("PersonId");

                    b.ToTable("Insurance");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExpireDate = "14020509",
                            InsuranceTypeId = 1,
                            PersonId = 1,
                            StartDate = "14010509"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "تامین اجتماعی"
                        },
                        new
                        {
                            Id = 2,
                            Name = "سلامت"
                        });
                });

            modelBuilder.Entity("Library.Model.Models.Laboratory", b =>
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

                    b.ToTable("Laboratory");
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Medicine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "استامینوفن",
                            Price = 0L
                        },
                        new
                        {
                            Id = 2,
                            Name = "ژلوفن",
                            Price = 0L
                        },
                        new
                        {
                            Id = 3,
                            Name = "پروفن",
                            Price = 0L
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = "13780624",
                            Family = "احدزاده",
                            FatherName = "عادل",
                            Name = "علی",
                            NationalId = "0312020244"
                        });
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

            modelBuilder.Entity("Library.Model.Models.PrescriptionLaboratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LaboratoryTypeId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LaboratoryTypeId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionLaboratory");
                });

            modelBuilder.Entity("Library.Model.Models.PrescriptionMedicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionMedicine");
                });

            modelBuilder.Entity("Library.Model.Models.PrescriptionRadiology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("RadiologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrescriptionId");

                    b.HasIndex("RadiologyId");

                    b.ToTable("PrescriptionRadiology");
                });

            modelBuilder.Entity("Library.Model.Models.Radiology", b =>
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

                    b.ToTable("Radiology");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "استخوان",
                            Price = 0L
                        },
                        new
                        {
                            Id = 2,
                            Name = "اعضای داخلی",
                            Price = 0L
                        },
                        new
                        {
                            Id = 3,
                            Name = "غضروف",
                            Price = 0L
                        });
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

            modelBuilder.Entity("Library.Model.Models.LoginAccess", b =>
                {
                    b.HasOne("Library.Model.Models.User", "User")
                        .WithOne("LoginAccess")
                        .HasForeignKey("Library.Model.Models.LoginAccess", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Library.Model.Models.Prescription", b =>
                {
                    b.HasOne("Library.Model.Models.Doctor", "Dr")
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

            modelBuilder.Entity("Library.Model.Models.PrescriptionLaboratory", b =>
                {
                    b.HasOne("Library.Model.Models.Laboratory", "LaboratoryType")
                        .WithMany("Laboratories")
                        .HasForeignKey("LaboratoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Models.Prescription", "Prescription")
                        .WithMany("Labratories")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LaboratoryType");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Library.Model.Models.PrescriptionMedicine", b =>
                {
                    b.HasOne("Library.Model.Models.Medicine", "Medicine")
                        .WithMany("prescriptionMedicines")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionMedicines")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Library.Model.Models.PrescriptionRadiology", b =>
                {
                    b.HasOne("Library.Model.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionRadiologies")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Model.Models.Radiology", "Radiology")
                        .WithMany("Radiologies")
                        .HasForeignKey("RadiologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prescription");

                    b.Navigation("Radiology");
                });

            modelBuilder.Entity("Library.Model.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Library.Model.Models.InsuranceType", b =>
                {
                    b.Navigation("Insurance");
                });

            modelBuilder.Entity("Library.Model.Models.Laboratory", b =>
                {
                    b.Navigation("Laboratories");
                });

            modelBuilder.Entity("Library.Model.Models.Medicine", b =>
                {
                    b.Navigation("prescriptionMedicines");
                });

            modelBuilder.Entity("Library.Model.Models.Person", b =>
                {
                    b.Navigation("Insurances");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Library.Model.Models.Prescription", b =>
                {
                    b.Navigation("Labratories");

                    b.Navigation("PrescriptionMedicines");

                    b.Navigation("PrescriptionRadiologies");
                });

            modelBuilder.Entity("Library.Model.Models.Radiology", b =>
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
