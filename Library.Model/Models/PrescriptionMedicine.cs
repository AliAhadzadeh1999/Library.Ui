using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model.Models
{
    public class PrescriptionMedicine
    {
        public int Id { get; set; }
        public int PrescriptionId { get; set; }
        public Prescription? Prescription { get; set; }
        public int MedicineId { get; set; }
        public Medicine? Medicine { get; set; }
    }
}
