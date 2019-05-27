using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Stocks.StockOs;
using supplyc.SupplyChains.StockInformation.StockOuts.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.StockInformation.StockOuts
{
    [AbpAuthorize]
    public class StockOutAppService : AsyncCrudAppService<SupplyStockOutt, Dto_StockOut, int, PagedResultRequestDto, Dto_StockOut, Dto_StockOut>
    {
        public StockOutAppService(IRepository<SupplyStockOutt, int> repository) : base(repository)
        {
        }
    }
}
