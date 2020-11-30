using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.ComponentModel;

namespace CaRental.Models
{
    public class Car
    {
        [ScaffoldColumn(false)]
        public int CarID { get; set; }

        [Required,StringLength(50), Display(Name = "Name")]
        public string CarName { get; set; }

        [Required, StringLength(100), Display(Name = "Car Description"),
            DataType(DataType.MultilineText)]
        public string Description { get; set; }

       public string Images { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}