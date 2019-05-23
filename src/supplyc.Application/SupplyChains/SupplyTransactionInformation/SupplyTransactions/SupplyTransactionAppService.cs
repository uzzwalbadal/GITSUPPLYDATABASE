using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using supplyc.Entity.SupplyTransactions;
using supplyc.SupplyChains.SupplyTransactionInformation.SupplyTransactions.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.SupplyTransactionInformation.SupplyTransactions
{
    [AbpAuthorize]
    public class SupplyTransactionAppService : AsyncCrudAppService<Supplytransaction, Dto_SupplyTransaction, int, PagedResultRequestDto, Dto_SupplyTransaction, Dto_SupplyTransaction>
    {
        public SupplyTransactionAppService(IRepository<Supplytransaction, int> repository) : base(repository)
        {
        }
    }
}
