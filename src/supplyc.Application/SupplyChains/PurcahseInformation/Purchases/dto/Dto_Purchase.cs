using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Purchase;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.PurcahseInformation.Purchases.dto
{
    [AutoMap(typeof(Purchase))]
   public class Dto_Purchase : EntityDto<int>
    {
        public string RefName { get; set; }

        public string Date { get; set; }
        public string BatchId { get; set; }
    }
}
