using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Products
{
    [Table("Supply_ProductType")]
    public class ProductType : FullAuditedEntity<int>
    {
        public string Name { get; set; }
    }
}
