using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaRental.Models;
using System.Web.ModelBinding;


namespace CaRental
{
    public partial class CarList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Car> GetCars([QueryString("id")] int? categoryId)
        {
            var _db = new CaRental.Models.CarContext();
            IQueryable<Car> query = _db.Cars;
            if(categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }

    }
}