using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Supplys;
using supplyc.SupplyChains.SupplyInformation.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.SupplyInformation
{
    [AbpAuthorize]
    public class SupplyAppService : AsyncCrudAppService<Supply, Dto_Supply, int, PagedResultRequestDto, Dto_Supply, Dto_Supply>
    {
        public SupplyAppService(IRepository<Supply, int> repository) : base(repository)
        {
        }
    }
}
