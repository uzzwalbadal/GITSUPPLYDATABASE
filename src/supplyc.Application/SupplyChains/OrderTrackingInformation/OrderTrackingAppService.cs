using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.OrderTrackings;
using supplyc.SupplyChains.OrderTrackingInformation.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.OrderTrackingInformation
{
    [AbpAuthorize]
    public class OrderTrackingAppService : AsyncCrudAppService<OrderTracking, Dto_OrderTracking, int, PagedResultRequestDto, Dto_OrderTracking, Dto_OrderTracking>
    {
        public OrderTrackingAppService(IRepository<OrderTracking, int> repository) : base(repository)
        {
        }
    }
}
