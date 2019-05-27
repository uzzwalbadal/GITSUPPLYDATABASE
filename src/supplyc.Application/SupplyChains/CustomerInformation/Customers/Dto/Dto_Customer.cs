using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.CustomerInformation.Customers
{
    [AutoMap(typeof(Customer))]
   public  class Dto_Customer : EntityDto<int>
    {
        public string Name { get; set; }

        public string Type { get; set; }
        public string Location { get; set; }
        public int Contact { get; set; }
        public int CustomerTypeId { get; set; }
    }
}
