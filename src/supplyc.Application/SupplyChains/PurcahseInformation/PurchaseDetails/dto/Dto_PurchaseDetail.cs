using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Purchase;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.PurcahseInformation.PurchaseDetails.dto
{
    [AutoMap(typeof(PurchaseDetail))]
    public class Dto_PurchaseDetail : EntityDto<int>
    {
        public string Quantity { get; set; }

        public int Rate { get; set; }
        public string ExpiryDate { get; set; }
    }
}
