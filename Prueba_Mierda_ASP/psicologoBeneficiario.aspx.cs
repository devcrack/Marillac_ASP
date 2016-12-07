using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Prueba_Mierda_ASP
{
    public partial class psicologoBeneficiario : System.Web.UI.Page
    {
        private string sConection = "Data Source=localhost; User Id=MARILLAC; Password=Mvaldes1";

        protected void Page_Load(object sender, EventArgs e)
        {
            /*OracleConnection conexion = new OracleConnection();
            conexion.ConnectionString = this.sConection;
            conexion.Open();

            string query = "SELECT nombre, patreno, materno, telefono FROM psicologo WHERE idPsicologo="+idPsicologo;
            OracleDataAdapter con = new OracleDataAdapter(query, conexion);
            DataSet tabla = new DataSet();
            con.Fill(tabla);
            conexion.Close();  
            */  
        }

        protected void salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForM_Beneficiarios.aspx");
        }
    }
}