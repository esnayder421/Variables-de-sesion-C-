using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_VariableSesion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string us;
                string contr;
                us = TxtUsuario.Text;
                contr = TxtContrasena.Text;
                LogicaN objln = new LogicaN();
                objln.Usuario = us;
                objln.Contr = contr;

                if (!objln.consultar())
                {
                    Lblmensaje.Text = "error usuario o contraseña incorrecto " + objln.geterror;
                }
                SqlDataReader rstDatos; //Crear DataReader
                rstDatos = objln.GetReader;
                if (rstDatos.HasRows)
                {
                    rstDatos.Read();

                    Session["usuario"] = rstDatos.GetString(1);

                    rstDatos.Close();
                    this.Lblmensaje.Text = "";
                    Response.Redirect("bienvenido.aspx");
                }
                else
                {
                    this.Lblmensaje.Text = "El usuario o contraseña no existe favor verificar";

                    return;
                }

            }
            catch (Exception ex)
            {
                Lblmensaje.Text = ex.Message;
            }
        }
    }
}