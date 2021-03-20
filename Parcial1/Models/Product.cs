using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Introduzca entre 3 y 30 caracteres")]
        public string Description { get; set; }

        [Required]
        public float Price { get; set; }

        public DateTime LastBuy { get; set; }
    }
}