using Library.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Contract.DTOs.Prescriptions
{
    public class PrescriptionRadiologyAddDto
    {
        public PrescriptionRadiologyAddDto()
        {
            Selected = new List<int>();
        }
        public int Id { get; set; }
        public int DrId { get; set; }
        public Doctor Dr { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public ICollection<int> Selected;
    }
}
