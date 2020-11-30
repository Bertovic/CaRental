using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using CaRental.Models;


namespace CaRental
{
    public partial class CarDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Car> GetCar([QueryString("carID")] int? carId)
        {
            var _db = new CaRental.Models.CarContext();
            IQueryable<Car> query = _db.Cars;
            if(carId.HasValue && carId > 0)
            {
                query = query.Where(p => p.CarID == carId);
            }
            else
            {
                query = null;
            }
            return query;
        }

    }
}