using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.SupplyTransactions
{
    [Table("Supply_Supplytransaction")]
    public class Supplytransaction : FullAuditedEntity<int>
    {
        public string Name { get; set; }

        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public string Type { get; set; }

        [ForeignKey("Supplytransactiontype")]
        public int SupplytransactiontypeId { get; set; }
        public virtual Supplytransactiontype Supplytransactiontype { get; set; }
    }
}
