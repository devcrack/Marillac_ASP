using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_Mierda_ASP
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label2.Text += Request.QueryString["param1"].ToString();
            this.Label3.Text += Request.QueryString["param2"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button_psicologos_Click(object sender, EventArgs e)
        {

        }

        protected void Button_Beneficiarios_Click(object sender, EventArgs e)
        {

        }
    }
}