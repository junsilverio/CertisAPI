using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Certis.Core.WebApi.Request
{
    public class SchedulerRequest
    {
        public int CustomerId { get; set; }

        public int ContractId { get; set; }

        public int BranchId { get; set; }

        public int ScheduleId { get; set; }

    }
}
