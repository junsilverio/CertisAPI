using System;
using System.Linq;
using Certis.Core.Entities.Model;

namespace Certis.Core.Repository.Interface
{
    public interface IContractRepository : IDisposable
    {
        IQueryable<Contract> GetContracts();

        Contract GetContract(int Id);

        Contract GetContractByCode(string contractCode);

        void Add(Contract contract);

        Contract Update(Contract contract);

        void Delete(Contract contract);
        
    }
}
