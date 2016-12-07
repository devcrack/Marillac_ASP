using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Prueba_Mierda_ASP
{
    public partial class Actividad : System.Web.UI.Page
    {
        string stringConnection = "Data Source = xe; User Id = MARILLAC; Password = Mvaldes1";
        string dias = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        public string checaDias()
        {
            string str = "";
            if (CheckBox1.Checked == true)
            {
                str += "Lunes ";
            }
            if (CheckBox2.Checked == true)
            {
                str += "Martes ";
            }
            if (CheckBox3.Checked == true)
            {
                str += "Miercoles ";
            }
            if (CheckBox4.Checked == true)
            {
                str += "Jueves ";
            }
            if (CheckBox5.Checked == true)
            {
                str += "Viernes ";
            }
            if (CheckBox6.Checked == true)
            {
                str += "Sabado ";
            }
            if (CheckBox7.Checked == true)
            {
                str += "Domingo ";
            }
            return str;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx?param1=");
        }

        public void mostrarDatos()
        {
            //SE CARGA TABLA DE PROFESORES
            try
            {
                OracleConnection m = new OracleConnection();
                m.ConnectionString = stringConnection;
                m.Open();
                string consulta = "SELECT IDPROFESOR, NOMBRE, PATERNO, MATERNO, TELEFONO FROM PROFESOR";

                OracleDataAdapter con = new OracleDataAdapter(consulta, m);

                DataSet tabla = new DataSet();
                con.Fill(tabla);
                GridView1.DataSource = tabla.Tables[0].DefaultView;
                GridView1.DataBind();
            }
            catch (OracleException ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }

            //SE CARGA TABLA DE ACTIVIDADES
            try
            {
                OracleConnection m2 = new OracleConnection();
                m2.ConnectionString = stringConnection;
                m2.Open();
                string consulta2 = "SELECT IDACTIVIDAD, IDPROFESOR, NOMBREACTIVIDAD, CUPO, INSCRITOS FROM ACTIVIDAD";

                OracleDataAdapter con2 = new OracleDataAdapter(consulta2, m2);

                DataSet tabla2 = new DataSet();
                con2.Fill(tabla2);
                GridView2.DataSource = tabla2.Tables[0].DefaultView;
                GridView2.DataBind();
            }
            catch (OracleException ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}