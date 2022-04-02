using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSIP.Models
{
    public class Inventories
    {
        public class Inventory
        {
            [Required(ErrorMessage = "Name is required")]
            public string Name { get; set; }
            public string Description { get; set; }

            [Required(ErrorMessage = "Unit price is required")]
            public decimal UnitPrice { get; set; }
            public string RecordedBy { get; set; }
            public int quantity { get; set; }
            public string ProductCode { get; set; }

            [Required(ErrorMessage = "Category is required")]
            public string Category { get; set; }
            public DateTime DateCreated { get; set; }
            public DateTime DateUpdated { get; set; }
            public DateTime DateDeleted { get; set; }

            public string Status { get; set; }
        }

        public class ProductInventory : Inventory
        {
            public int productID { get; set; }
            public Aircon aircondetails { get; set; }

            public ProductInventory()
            {
                aircondetails = new Aircon();
            }
        }

        public class EquipmentInventory : Inventory
        {
            public int EquipmentID { get; set; }
            public DateTime DatePurchased { get; set; }
        }
    }
}
