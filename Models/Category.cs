using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CaRental.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(50), Display(Name ="Name")]
        public string CategoryName { get; set; }

        [Display(Name ="Product Description")]
        public string Description { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

    }
}