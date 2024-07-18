﻿using Library.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Contexts
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    DateOfBirth = "13780624",
                    Family = "احدزاده",
                    FatherName = "عادل",
                    Name = "علی",
                    NationalId = "0312020244"
                });

            modelBuilder.Entity<Insurance>().HasData(
                new Insurance
                {
                    Id = 1,
                    InsuranceTypeId = 1,
                    PersonId = 1,
                    StartDate = "14010509",
                    ExpireDate = "14020509"
                });

            modelBuilder.Entity<InsuranceType>().HasData(
                new InsuranceType() { Id = 1, Name = "تامین اجتماعی" },
                new InsuranceType() { Id = 2, Name = "سلامت" }
                );

            modelBuilder.Entity<Medicine>().HasData(
                new Medicine { Id = 1, Name = "استامینوفن" },
                new Medicine { Id = 2, Name = "ژلوفن" },
                new Medicine { Id = 3, Name = "پروفن" }
                );

            modelBuilder.Entity<RadiologyType>().HasData(
                new RadiologyType { Id = 1, Name = "استخوان" },
                new RadiologyType { Id = 2, Name = "اعضای داخلی" },
                new RadiologyType { Id = 3, Name = "غضروف" }
                );
        }


    }
}

