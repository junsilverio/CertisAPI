using Certis.Core.Entities.Model;
using Certis.Core.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Certis.Core.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IContractService _service;
        public ContractController(IContractService service)
        {
            _service = service;
        }
        
        [HttpGet("contract")]
        public IEnumerable<Contract> GetContracts()
        {
            return _service.GetContracts().AsEnumerable();
        }

        [HttpGet("contract/id")]
        public Contract GetCustomer(int id)
        {
            return _service.GetContract(id);
        }

        [HttpGet("contract/code")]
        public Contract GetContractsByCode(string contractCode)
        {
            return _service.GetContractByCode(contractCode);
        }

    }
}
