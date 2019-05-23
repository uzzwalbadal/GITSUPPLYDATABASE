using Abp.Domain.Entities.Auditing;
using supplyc.Entity.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Purchase
{
    [Table("Supply_PurchaseDetails")]
    public class PurchaseDetail : FullAuditedEntity<int>
    {
        public string Quantity { get; set; }

        public int Rate { get; set; }
        public string ExpiryDate { get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }

        [ForeignKey("Purchase")]
        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }


    }
}
