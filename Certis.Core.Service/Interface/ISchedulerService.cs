using System;
using System.Collections.Generic;
using System.Text;

namespace Certis.Core.Service.Interface
{
    public interface ISchedulerService
    {
        bool CreateJob();

        bool UpdateJobs(int customerId, int contractId, int branchId, int scheduleId);

        bool UpdateJobs(int customerId, int contractId, int branchId);

        bool UpdateJobs(int customerId, int contractId);

        bool UpdateJobs(int customerId);

    }
}
