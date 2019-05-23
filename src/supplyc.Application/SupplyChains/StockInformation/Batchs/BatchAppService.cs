using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Stocks.Batchs;
using supplyc.SupplyChains.StockInformation.Batchs.dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.StockInformation.Batchs
{
    [AbpAuthorize]
    public class BatchAppService : AsyncCrudAppService<SupplyBatch, Dto_Batch, int, PagedResultRequestDto, Dto_Batch, Dto_Batch>
    {
        public BatchAppService(IRepository<SupplyBatch, int> repository) : base(repository)
        {
        }
    }
}
