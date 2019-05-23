using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Purchase;
using supplyc.SupplyChains.PurcahseInformation.Purchases.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.PurcahseInformation.Purchases
{
    [AbpAuthorize]
    public class PurchaseAppService : AsyncCrudAppService<Purchase, Dto_Purchase, int, PagedResultRequestDto, Dto_Purchase, Dto_Purchase>
    {
        public PurchaseAppService(IRepository<Purchase, int> repository) : base(repository)
        {
        }
    }
}
