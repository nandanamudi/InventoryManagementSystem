using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManager.Models
{
        public class EmailFormModel
        {
            [Required, Display(Name = "Fernando")]
            public string FromName { get; set; }
            [Required, Display(Name = "inventory.manager@outlook.com"), EmailAddress]
            public string FromEmail { get; set; }
            [Required]
            public string Message { get; set; }
        }
    
    }
