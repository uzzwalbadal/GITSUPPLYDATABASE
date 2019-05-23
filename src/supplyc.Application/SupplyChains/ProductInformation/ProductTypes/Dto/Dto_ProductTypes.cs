using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using supplyc.Entity.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.ProductInformation.ProductTypes.Dto
{
    [AutoMap(typeof(ProductType))]
    public class Dto_ProductTypes : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
