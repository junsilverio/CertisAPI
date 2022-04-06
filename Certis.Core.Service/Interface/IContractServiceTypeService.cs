using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Certis.Core.Entities.Model;
using Certis.Core.Repository;

namespace Certis.Core.Service.Interface
{
    public interface IContractServiceTypeService
    {
        IQueryable<ContractServiceType> GetContractServiceTypes();

        ContractServiceType GetContractServiceType(int id);

        ContractServiceType GetGetContractServiceTypeByServiceTypeId(int serviceTypeId);
    }
}
