using Library.Application.Contract.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Contract.IServices
{
    public interface IMedicineService
    {
        List<KeyValue> GetKeyValue();
    }
}
