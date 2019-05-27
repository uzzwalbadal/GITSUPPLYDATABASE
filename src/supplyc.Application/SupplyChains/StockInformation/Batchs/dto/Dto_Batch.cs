using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Stocks.Batchs;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.StockInformation.Batchs.dto
{
    [AutoMap(typeof(SupplyBatch))]
    public class Dto_Batch : EntityDto<int>
    {
        public int BatchNo { get; set; }
    }
}
