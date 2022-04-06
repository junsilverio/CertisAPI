using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Certis.Core.Entities.Model;

namespace Certis.Core.Repository.Interface
{
    public interface IContractServiceTypeRepository : IDisposable
    {
        IQueryable<ContractServiceType> GetContractServiceTypes();
        
        ContractServiceType GetContractServiceType(int Id);

        ContractServiceType GetContractServiceTypeByServiceTypeId(int serviceTypeId);

        void Add(ContractServiceType contractServiceType);

        ContractServiceType Update(ContractServiceType contractServiceType);

        void Delete(ContractServiceType contractServiceType);
        
    }
}
