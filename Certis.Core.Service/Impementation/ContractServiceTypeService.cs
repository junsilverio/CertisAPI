using Certis.Core.Entities.Model;
using Certis.Core.Repository.Interface;
using Certis.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certis.Core.Service.Impementation
{
    public class ContractServiceTypeService : IContractServiceTypeService
    {
        private readonly IContractServiceTypeRepository _repository;
        public ContractServiceTypeService(IContractServiceTypeRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<ContractServiceType> GetContractServiceTypes()
        {
            return _repository.GetContractServiceTypes();
        }

        public ContractServiceType GetContractServiceType(int id)
        {
            return _repository.GetContractServiceType(id);
        }

        public ContractServiceType GetGetContractServiceTypeByServiceTypeId(int serviceTypeId)
        {
            return _repository.GetContractServiceTypeByServiceTypeId(serviceTypeId);
        }
    }
}
