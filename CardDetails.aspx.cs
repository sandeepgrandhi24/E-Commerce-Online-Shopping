using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BAL;

namespace OnlineShopping
{
    public partial class CardDetails : System.Web.UI.Page
    {
        CraditCard Card = new CraditCard();
        Credicards_BAL CredObj = new Credicards_BAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LoginID"] != null)
                {
                    string ItemId = Request.QueryString["ItemId"];
                    string Qnt = Request.QueryString["Qnt"];
                    string Invt = Request.QueryString["Invt"];
                    OrderItemId.Value = ItemId;
                    OrderQuantity.Value = Qnt;
                }
                else {
                    Response.Redirect("Login.aspx");
                }
            
            }
        }

        protected void ConfirmOrder_Click(object sender, EventArgs e)
        {
            Card.CcNumber = CcNumber.Text;
            Card.CityID = CityID.Text;
            Card.CName = CName.Text;
            Card.CountryID = CountryID.Text;
            Card.Cvv = (Cvv.Text);
            Card.Exp = Exp.Text;
            Card.OrderID = Convert.ToInt32(OrderItemId.Value);
            Card.Qunt = OrderQuantity.Value;
            Card.StateID = StateID.Text;
            Card.Street = Street.Text;
            Card.Type = CardType.SelectedValue;
            Card.Zipcode = Convert.ToInt32(Zipcode.Text);
            Card.LoginID = Convert.ToInt32(Session["LoginID"]);

           int Status= CredObj.CreateCraditApp(Card);
           if (Status.Equals(1))
               Response.Redirect("Order.aspx");
           else
               TxtMsg.Text = "While creating Card information error. Please try agin.";
            }


    }
}