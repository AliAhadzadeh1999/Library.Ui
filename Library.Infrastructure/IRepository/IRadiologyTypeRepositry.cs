using Library.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.IRepository
{
    public interface IRadiologyTypeRepositry
    {
        public List<Radiology> GetAll();

        public Radiology GetByName(string name);
    }
}
