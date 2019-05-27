using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Supplys;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.SupplyInformation.Dto
{
    [AutoMap(typeof(Supply))]
    public class Dto_Supply : EntityDto<int>
    {
        public string Product { get; set; }
        public string SuppliedTo { get; set; }
        public string Quantity { get; set; }
        public DateTime Date { get; set; }
        public string Validity { get; set; }
    }
}
