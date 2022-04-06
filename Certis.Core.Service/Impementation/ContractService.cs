using Certis.Core.Entities.Model;
using Certis.Core.Repository.Interface;
using Certis.Core.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certis.Core.Service.Impementation
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _repository;
        public ContractService(IContractRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Contract> GetContracts()
        {
            return _repository.GetContracts();
        }

        public Contract GetContract(int id)
        {
            return _repository.GetContract(id);
        }

        public Contract GetContractByCode(string contractCode)
        {
            return _repository.GetContractByCode(contractCode);
        }
    }
}
