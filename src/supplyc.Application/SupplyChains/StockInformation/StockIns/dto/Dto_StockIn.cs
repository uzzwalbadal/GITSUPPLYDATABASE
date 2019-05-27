using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Stocks.StockIs;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.StockInformation.StockIns.dto
{
    [AutoMap(typeof(SupplyStockIn))]
    public class Dto_StockIn : EntityDto<int>
    {
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Stocked_From { get; set; }
    }
}
