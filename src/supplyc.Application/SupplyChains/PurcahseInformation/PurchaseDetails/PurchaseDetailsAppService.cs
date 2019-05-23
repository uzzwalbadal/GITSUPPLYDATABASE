using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Purchase;
using supplyc.SupplyChains.PurcahseInformation.PurchaseDetails.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.PurcahseInformation.PurchaseDetails
{
    [AbpAuthorize]
    public class PurchaseDetailsAppService : AsyncCrudAppService<PurchaseDetail, Dto_PurchaseDetail, int, PagedResultRequestDto, Dto_PurchaseDetail, Dto_PurchaseDetail>
    {
        public PurchaseDetailsAppService(IRepository<PurchaseDetail, int> repository) : base(repository)
        {
        }
    }
}
