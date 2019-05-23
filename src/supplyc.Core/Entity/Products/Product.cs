using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace supplyc.Entity.Products
{
    [Table("Supply_Products")]
    public class Product : FullAuditedEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
