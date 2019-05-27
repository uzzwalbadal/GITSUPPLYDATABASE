using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Complaints;
using supplyc.SupplyChains.ComplaintInformation.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.ComplaintInformation
{
    [AbpAuthorize]
    public class ComplaintsAppService : AsyncCrudAppService<Complaint, Dto_Complaint, int, PagedResultRequestDto, Dto_Complaint, Dto_Complaint>
    {
        public ComplaintsAppService(IRepository<Complaint, int> repository) : base(repository)
        {
        }
    }
}
