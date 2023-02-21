using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSimpleCRUD.Models
{
    public class Product_Ajax
    {
        public int Id { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        [RegularExpression("(^[a-zA-Z]+$)")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("(^[a-zA-Z]+$)")]
        public string Descrption { get; set; }
        [Required]
        [RegularExpression("(^[a-zA-Z]+$)")]
        public string Category { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public int Pric { get; set; }
    }
}
