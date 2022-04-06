using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Certis.Core.WebApi.Request;
using Certis.Core.Service.Interface;

namespace Certis.Core.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class SchedulerController : ControllerBase
    {
        private readonly ISchedulerService _schedulerService;

        public SchedulerController(ISchedulerService schedulerService)
        {
            _schedulerService = schedulerService;
        }

        [HttpPost("scheduler/create")]
        public bool Create()
        {
            return _schedulerService.CreateJob();
        }

        [HttpPost("scheduler/{customerid}/{contractid}/{branchid}/{scheduleid}/update")]
        public bool Update(int customerId, int contractId, int branchId, int scheduleId)
        {
            return _schedulerService.UpdateJobs(customerId, contractId, branchId, scheduleId);
        }

        [HttpPost("scheduler/{customerid}/{contractid}/{branchid}/update")]
        public bool Update(int customerId, int contractId, int branchId)
        {
            return _schedulerService.UpdateJobs(customerId, contractId, branchId);
        }

        [HttpPost("scheduler/{customerid}/{contractid}/update")]
        public bool Update(int customerId, int contractId)
        {
            return _schedulerService.UpdateJobs(customerId, contractId);
        }

        [HttpPost("scheduler/{customerid}/update")]
        public bool Update(int customerId)
        {
            return _schedulerService.UpdateJobs(customerId);
        }
    }
}
