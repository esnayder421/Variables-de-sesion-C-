using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_VariableSesion
{
    public partial class bienvenido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Lblusuario.Text = Session["usuario"].ToString();
            }
        }
    }
}