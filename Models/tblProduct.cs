using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductsProject.Models
{
    [Table("tblProduct")]
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name Is Required*")]
        public string ProductName { get; set; }
       
        [ForeignKey("CategoryId")]
        public virtual CategoryModel TblCategory{ get; set;}
        public int CategoryId { get; set; }
    }
}