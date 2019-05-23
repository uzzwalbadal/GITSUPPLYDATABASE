using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Products;
using supplyc.SupplyChains.ProductInformation.Products.Dto;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace supplyc.SupplyChains.ProductInformation.Products
{
    [AbpAuthorize]
    public class ProductAppService : AsyncCrudAppService<Product, Dto_Product, int, PagedResultRequestDto, Dto_Product, Dto_Product>
    {
        private readonly IRepository<Product, int> _productRepo;

        public ProductAppService(IRepository<Product, int> repository) : base(repository)
        {
            _productRepo = repository;
        }

        public ListResultDto<Dto_ProductDetail> GetAllProductWithProductName(PagedResultRequestDto input)
        {
            var result = _productRepo.GetAll().Select(q => new Dto_ProductDetail()
            {
                Id = q.Id,
                Description = q.Description,
                Name = q.Name,
                ProductTypeId = q.ProductTypeId,
                ProductTypeName = q.ProductType.Name
            });

            return new ListResultDto<Dto_ProductDetail>(result.Skip(input.SkipCount).Take(input.MaxResultCount).ToList());
        }
    }
}
