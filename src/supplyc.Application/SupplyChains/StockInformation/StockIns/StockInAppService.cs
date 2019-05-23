using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Stocks.StockIs;
using supplyc.SupplyChains.StockInformation.StockIns.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.StockInformation.StockIns
{
    [AbpAuthorize]
    public class StockInAppService : AsyncCrudAppService<SupplyStockIn, Dto_StockIn, int, PagedResultRequestDto, Dto_StockIn, Dto_StockIn>
    {
        public StockInAppService(IRepository<SupplyStockIn, int> repository) : base(repository)
        {
        }
    }
}
