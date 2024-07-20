﻿using Library.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.IRepository
{
    public interface IMedicineRepository
    {
        public void Add(PrescriptionMedicine prescriptionMedicine);
    }
}