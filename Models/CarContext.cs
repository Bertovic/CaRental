using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CaRental.Models
{
    public class CarContext : DbContext
    {
        public CarContext() : base("CaRental")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

    }
}