using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.ProductInformation.Products.Dto
{
    [AutoMap(typeof(Product))]
    public class Dto_Product: EntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
    }
}
