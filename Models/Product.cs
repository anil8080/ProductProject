using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductsProject.Models
{
    [Table("tblProducts")]
    public class Product
    {  
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public virtual Category Category { get; set;}
        public int CategoryId { get; set; }
    }
}