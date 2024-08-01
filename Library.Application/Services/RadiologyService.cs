using Library.Application.Contract.DTOs;
using Library.Application.Contract.IServices;
using Library.Infrastructure.IRepository;
using Library.Infrastructure.Repository;

namespace Library.Application.Services
{
    public class RadiologyService : IRadiologyService
    {
        private readonly IRadiologyRepositry radiologyRepository;
        public RadiologyService()
        {
            radiologyRepository = new RadiologyRepositry();
        }
        public List<KeyValue> GetKeyValues()
        {
            return radiologyRepository.GetAll()
                .OrderBy(x => x.Name)
                .Select(x => new KeyValue() { Key = x.Id , Value = x.Name})
                .ToList();
                ;
        }
    }
}
