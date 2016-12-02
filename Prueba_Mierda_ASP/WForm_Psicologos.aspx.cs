using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_Mierda_ASP
{
    public partial class WForm_Psicologos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TextBox_1.Text = Request.QueryString["param1"].ToString();
            this.TextBox_2.Text = Request.QueryString["param2"].ToString();
        }
    }
}