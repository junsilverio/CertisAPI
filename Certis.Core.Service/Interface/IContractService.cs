using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Certis.Core.Entities.Model;
using Certis.Core.Repository;

namespace Certis.Core.Service.Interface
{
    public interface IContractService    
    {
        IQueryable<Contract> GetContracts();

        Contract GetContract(int id);

        Contract GetContractByCode(string customerCode);
    }
}
