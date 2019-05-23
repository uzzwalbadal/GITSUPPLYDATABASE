using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.SupplyTransactions;
using supplyc.SupplyChains.SupplyTransactionInformation.SupplyTransactionTypes.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.SupplyTransactionInformation.SupplyTransactionTypes
{
    [AbpAuthorize]
    public class SupplyTransactionTypeAppService : AsyncCrudAppService<Supplytransactiontype, Dto_SupplyTransactionTypes, int, PagedResultRequestDto, Dto_SupplyTransactionTypes, Dto_SupplyTransactionTypes>
    {
        public SupplyTransactionTypeAppService(IRepository<Supplytransactiontype, int> repository) : base(repository)
        {
        }
    }
}
