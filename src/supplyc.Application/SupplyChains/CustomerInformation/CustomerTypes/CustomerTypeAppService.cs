using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Customers;
using supplyc.SupplyChains.CustomerInformation.CustomerTypes.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.CustomerInformation.CustomerTypes
{
    [AbpAuthorize]
    public class CustomerTypeAppService : AsyncCrudAppService<CustomerType, Dto_CustomerType, int, PagedResultRequestDto, Dto_CustomerType, Dto_CustomerType>
    {
        public CustomerTypeAppService(IRepository<CustomerType, int> repository) : base(repository)
        {
        }
    }
}
