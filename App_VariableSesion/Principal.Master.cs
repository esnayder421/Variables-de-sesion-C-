using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_VariableSesion
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["usuario"].ToString() == "")
            {
                cerrar.Visible = false;
                iniciar.Visible = true;
            }
            else
            {
                iniciar.Visible = false;
                cerrar.Visible = true;
            }
        }
    }
}