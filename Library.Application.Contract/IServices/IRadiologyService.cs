using Library.Application.Contract.DTOs;

namespace Library.Application.Contract.IServices;

public interface IRadiologyService
{ 
    public List<KeyValue> GetKeyValues();
}
