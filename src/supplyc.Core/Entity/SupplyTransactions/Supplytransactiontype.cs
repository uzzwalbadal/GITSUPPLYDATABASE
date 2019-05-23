using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.SupplyTransactions
{
    [Table("Supply_Supplytransactiontype")]
    public class Supplytransactiontype : FullAuditedEntity<int>
    {
        public string Name { get; set; }
    }
}
