﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using supplyc.MultiTenancy.Dto;

namespace supplyc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

