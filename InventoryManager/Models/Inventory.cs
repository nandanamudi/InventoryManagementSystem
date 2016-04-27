using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManager.Models
{
    public class Inventory
    {
        [Key]
        public int ID { get; set; }
        public int SKU { get; set; }
        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public int QuantityWarningLevel { get; set; }

        public int QuantityRefill { get; set; }

        public int QuantityBehavior { get; set; }
    }
}