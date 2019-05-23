using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Stocks.Batchs
{
    [Table("Supply_SupplyBatchs")]
    public class SupplyBatch : FullAuditedEntity<int>
    {
        public int BatchNo { get; set; }
    }
}
