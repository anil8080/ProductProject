using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductsProject.Models
{   
    [Table("tblCategory")]
    public class CategoryModel
    {  
        [Key]
        public int CategoryId { get; set;}

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category Name Is Required*")]
        public string CategoryName{ get; set;}
    }
}