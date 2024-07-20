using Library.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.IRepository
{
    public interface IRadiologyRepositry
    {
        public void Add(PrescriptionRadiology prescriptionRadiology);
    }
}
