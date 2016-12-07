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
        //private string sConection = "Data Source=localhost; User Id=MARILLAC; Password=Mvaldes1";
        private string sConection = "Data Source=xe; User Id=MARILLAC_DEF; Password=oracle";
        private int idBeneficiario;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Params["idBeneficiario"] != null)
                {
                    string aux;
                    aux = Request.Params["idBeneficiario"];
                    idBeneficiario = Convert.ToInt16(aux);
                }
                OracleConnection conexion = new OracleConnection();
                conexion.ConnectionString = this.sConection;
                conexion.Open();

                string query = "SELECT p.nombre, p.paterno, p.materno, p.telefono FROM psicologo p" +
                " INNER JOIN beneficiario b ON" +
                " p.idPsicologo=b.idPsicologo AND b.idBeneficiario=" + idBeneficiario;
                OracleDataAdapter con = new OracleDataAdapter(query, conexion);
                DataSet tabla = new DataSet();
                con.Fill(tabla);
                conexion.Close();

                nombre.Text = tabla.Tables[0].Rows[0]["nombre"].ToString();
                paterno.Text = tabla.Tables[0].Rows[0]["paterno"].ToString();
                materno.Text = tabla.Tables[0].Rows[0]["materno"].ToString();
                telefono.Text = tabla.Tables[0].Rows[0]["telefono"].ToString();

            }
            catch { Response.Redirect("~/WebForM_Beneficiarios.aspx"); }          
        }

        protected void salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForM_Beneficiarios.aspx");
        }
    }
}