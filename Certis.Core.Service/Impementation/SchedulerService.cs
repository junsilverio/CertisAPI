using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Certis.Core.Entities.Model;
using Certis.Core.Service.Interface;
using Certis.Core.Repository.Interface;


namespace Certis.Core.Service.Impementation
{
    public class SchedulerService : ISchedulerService
    {
        private readonly ICustomerRepository _customer;
        public SchedulerService(ICustomerRepository customer)
        {
            _customer = customer;
        }

        public bool CreateJob()
        {
            return true;
        }

        public bool UpdateJobs(int customerId, int contractId, int branchId, int scheduleId)
        {

            var updateCustomer = _customer.GetCustomer(customerId)
                        //.Contracts.Select(c => c.CustomerId == customerId)
                        ;

            var test = updateCustomer.Contracts.Select(x => x.ContractServiceTypes
                                                        .Where(y => y.StartDate <= DateTime.Now
                                                            && y.EndDate >= DateTime.Now
                                                            && y.ServiceTypeId == 84).Select(x => x.Contract));
            


            throw new NotImplementedException();
        }

        public bool UpdateJobs(int customerId, int contractId, int branchId)
        {

            var updateCustomer = _customer.GetCustomer(customerId)
                        //.Contracts.Select(c => c.CustomerId == customerId)
                        ;

            var test = updateCustomer.Contracts.Select(x => x.ContractServiceTypes
                                                        .Where(y => y.StartDate <= DateTime.Now
                                                            && y.EndDate >= DateTime.Now
                                                            && y.ServiceTypeId == 84).Select(x => x.Contract));



            throw new NotImplementedException();
        }

        public bool UpdateJobs(int customerId, int contractId)
        {

            var updateCustomer = _customer.GetCustomer(customerId)
                        //.Contracts.Select(c => c.CustomerId == customerId)
                        ;

            var test = updateCustomer.Contracts.Select(x => x.ContractServiceTypes
                                                        .Where(y => y.StartDate <= DateTime.Now
                                                            && y.EndDate >= DateTime.Now
                                                            && y.ServiceTypeId == 84).Select(x => x.Contract));



            throw new NotImplementedException();
        }

        public bool UpdateJobs(int customerId)
        {

            var updateCustomer = _customer.GetCustomer(customerId)
                        //.Contracts.Select(c => c.CustomerId == customerId)
                        ;

            var test = updateCustomer.Contracts.Select(x => x.ContractServiceTypes
                                                        .Where(y => y.StartDate <= DateTime.Now
                                                            && y.EndDate >= DateTime.Now
                                                            && y.ServiceTypeId == 84).Select(x => x.Contract));



            throw new NotImplementedException();
        }

        //private IEnumerable<Customer> GetCustomersJobCreate()
        //{
        //    var forCreate = _customer.GetCustomers();
        //    var x = forCreate
        //}
    }
}
