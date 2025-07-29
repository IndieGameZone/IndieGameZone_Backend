using IndieGameZone.Application.IServices;
using IndieGameZone.Domain.Constants;
using IndieGameZone.Domain.IRepositories;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndieGameZone.Application.BackgroundJobServices
{
    public class UpdateCommercialRegistrationStatusJob : IJob
    {
        private readonly IServiceManager serviceManager;

        public UpdateCommercialRegistrationStatusJob(IServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await serviceManager.CommercialPackageService.RunStatusUpdateAsync(context.CancellationToken);
        }
    }
}

