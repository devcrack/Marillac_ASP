using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_Mierda_ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Menu mn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Ingresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx?param1="+this.TextBox1.Text + "&param2=" + this.TextBox2.Text);
        }
    }
}