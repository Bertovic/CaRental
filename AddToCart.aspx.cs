using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using CaRental.Logic;

namespace CaRental
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["CarID"];
            int carId;
            if(!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out carId))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                        
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart without a Car ID.");
                throw new Exception("ERROR : It is illegal to load AddToCart without setting a Car ID.");
            }
            Response.Redirect("ShoppingCart.aspx");

        }
    }
}