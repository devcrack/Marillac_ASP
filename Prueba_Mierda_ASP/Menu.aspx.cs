﻿using System;
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
        }

        protected void Button_psicologos_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/WForm_Psicologos.aspx?param1=" + this.TextBox_1.Text + "&param2=" + this.TextBox_2.Text);  
            Response.Redirect("~/WForm_Psicologos.aspx");
        }

        protected void Button_Beneficiarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForM_Beneficiarios.aspx");       
        }

        protected void Button_Actividades_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Actividad.aspx?");
        }

        protected void Button_Hijos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/hijos.aspx?");
        }

        protected void Button_Profesores0_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/profesores.aspx");
        }
    }
}