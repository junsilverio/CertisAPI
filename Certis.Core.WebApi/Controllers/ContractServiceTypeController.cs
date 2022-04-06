using Certis.Core.Entities.Model;
using Certis.Core.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Certis.Core.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class ContractServiceTypeController : ControllerBase
    {
        private readonly IContractServiceTypeService _service;
        public ContractServiceTypeController(IContractServiceTypeService service)
        {
            _service = service;
        }
        
        [HttpGet("contractservicetypes")]
        public IEnumerable<ContractServiceType> GetIContractServiceTypes()
        {
            return _service.GetContractServiceTypes();
        }

        [HttpGet("contractservicetypes/id")]
        public ContractServiceType GetContractServiceTypes(int id)
        {
            return _service.GetContractServiceType(id);
        }

        [HttpGet("contractservicetypes/servicetypeid")]
        public ContractServiceType GetCustomerByCode(int servicetypeid)
        {
            return _service.GetGetContractServiceTypeByServiceTypeId(servicetypeid);
        }
    }
}
