using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Stocks.StockIs;
using supplyc.Entity.Stocks.StockOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.StockInformation.StockOuts.dto
{
    [AutoMap(typeof(SupplyStockOutt))]
   public  class Dto_StockOut : EntityDto<int>
    {
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public string Stocked_To { get; set; }
    }
}
