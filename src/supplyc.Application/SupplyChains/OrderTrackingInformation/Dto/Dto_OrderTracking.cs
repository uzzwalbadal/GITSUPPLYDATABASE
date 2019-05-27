using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.OrderTrackings;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.OrderTrackingInformation.Dto
{
    [AutoMap(typeof(OrderTracking))]
    public class Dto_OrderTracking : EntityDto<int>
    {
        public int Quantity { get; set; }

        public DateTime Date { get; set; }
        public string OrderedBy { get; set; }
        public string Validity { get; set; }
    }
}
