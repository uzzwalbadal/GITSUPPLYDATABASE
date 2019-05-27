using System;
using System.Collections.Generic;
using System.Text;

namespace supplyc.SupplyChains.CustomerInformation.Customers.Dto
{
    public class Dto_CustomerDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int Contact { get; set; }
        public int CustomerTypeId { get; set; }
        public string CustomerTypeName { get; set; }
    }
}
