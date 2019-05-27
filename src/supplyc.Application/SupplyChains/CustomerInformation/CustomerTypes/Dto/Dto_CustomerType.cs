using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.CustomerInformation.CustomerTypes.Dto
{
    [AutoMap(typeof(CustomerType))]
    public class Dto_CustomerType : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
