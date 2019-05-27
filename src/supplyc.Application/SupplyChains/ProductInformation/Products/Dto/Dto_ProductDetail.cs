using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.ProductInformation.Products.Dto
{
    public class Dto_ProductDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
    }
}
