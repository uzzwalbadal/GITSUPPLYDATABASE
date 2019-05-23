using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Products;
using supplyc.SupplyChains.ProductInformation.ProductTypes.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.ProductInformation.ProductTypes
{
    [AbpAuthorize]
    public class ProductTypeAppService : AsyncCrudAppService<ProductType, Dto_ProductTypes, int, PagedResultRequestDto, Dto_ProductTypes, Dto_ProductTypes>
    {
        public ProductTypeAppService(IRepository<ProductType, int> repository) : base(repository)
        {
        }
    }
}
