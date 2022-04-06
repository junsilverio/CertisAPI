using Certis.Core.Entities.Model;
using Certis.Core.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Certis.Core.Repository.Implementation
{
    public class ContractRepository : IContractRepository
    {

        private readonly PCSBNRContext _context;
        public ContractRepository(PCSBNRContext context)
        {
            _context = context;
        }

        public void Add(Contract contract)
        {

            _context.Contracts.Add(contract);
            _context.SaveChanges();
            
        }

        public void Delete(Contract contract)
        {
            _context.Contracts.Remove(contract);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Contract GetContract(int Id)
        {
            return _context.Contracts.FirstOrDefault(x => x.Id == Id);
        }

        public Contract GetContractByCode(string contractCode)
        {
            return _context.Contracts.FirstOrDefault(x => x.ContractCode == contractCode);
        }

        public IQueryable<Contract> GetContracts()
        {
            return _context.Contracts.AsQueryable();
        }

        public Contract Update(Contract Contract)
        {
            var modified = _context.Contracts.Attach(Contract);
            modified.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Contract;
        }
    }
}
