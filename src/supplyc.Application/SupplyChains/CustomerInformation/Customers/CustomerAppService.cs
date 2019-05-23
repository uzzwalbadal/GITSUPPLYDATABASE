using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.CustomerInformation.Customers
{
    [AbpAuthorize]
    public class CustomerAppService : AsyncCrudAppService<Customer, Dto_Customer, int, PagedResultRequestDto, Dto_Customer, Dto_Customer>
    {
        public CustomerAppService(IRepository<Customer, int> repository) : base(repository)
        {
        }
    }
}
