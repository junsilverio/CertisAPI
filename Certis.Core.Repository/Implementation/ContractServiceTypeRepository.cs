using Certis.Core.Entities.Model;
using Certis.Core.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certis.Core.Repository.Implementation
{
    public class ContractServiceTypeRepository : IContractServiceTypeRepository
    {

        private readonly PCSBNRContext _context;
        public ContractServiceTypeRepository(PCSBNRContext context)
        {
            _context = context;
        }

        public void Add(ContractServiceType contractServiceType)
        {

            _context.ContractServiceTypes.Add(contractServiceType);
            _context.SaveChanges();
            
        }

        public void Delete(ContractServiceType contractServiceType)
        {
            _context.ContractServiceTypes.Remove(contractServiceType);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ContractServiceType GetContractServiceType(int Id)
        {
            return _context.ContractServiceTypes.FirstOrDefault(x => x.Id == Id);
        }

        public ContractServiceType GetContractServiceTypeByServiceTypeId(int serviceTypeId)
        {
            return _context.ContractServiceTypes.FirstOrDefault(x => x.ServiceTypeId == serviceTypeId);
        }

        public IQueryable<ContractServiceType> GetContractServiceTypes()
        {
            return _context.ContractServiceTypes.AsQueryable();
        }

        public ContractServiceType Update(ContractServiceType contractServiceType)
        {
            var modified = _context.ContractServiceTypes.Attach(contractServiceType);
            modified.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return contractServiceType;
        }
    }
}
