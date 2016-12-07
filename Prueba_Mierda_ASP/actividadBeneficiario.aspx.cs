using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Oracle.ManagedDataAccess.Client;
//using Oracle.DataAccess.Client;

namespace Prueba_Mierda_ASP
{
    public partial class actividadBeneficiario : System.Web.UI.Page
    {

        string sConection = "Data Source=localhost; User Id=MARILLAC; Password=Mvaldes1";
        private int idBeneficiario;

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        protected void cargarDatos()
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

                string query = "SELECT a.* FROM actividad a" +
                " INNER JOIN beneficiario b " +
                "INNER JOIN inscripcionBeneficiario i ON " +
                "i.idBeneficiario=b.idBeneficiario AND b.idBeneficiario=" + idBeneficiario +
                " ON a.idActividad=i.idActividad";
                OracleDataAdapter con = new OracleDataAdapter(query, conexion);
                DataSet tabla = new DataSet();
                con.Fill(tabla);

                tabla.Tables[0].Columns.Remove("idActividad");
                tabla.Tables[0].Columns.Remove("idProfesor");
                tabla.Tables[0].Columns.Remove("cupo");
                tabla.Tables[0].Columns.Remove("inscritos");

                tabla.Tables[0].Columns[0].ColumnName = "Nombre actividad";
                tabla.Tables[0].Columns[1].ColumnName = "Costo";
                tabla.Tables[0].Columns[2].ColumnName = "Días de actividad";
                tabla.Tables[0].Columns[3].ColumnName = "Hora inicia";
                tabla.Tables[0].Columns[4].ColumnName = "Hora termina";

                GridView1.DataSource = tabla.Tables[0].DefaultView;
                GridView1.DataBind();

            }
            catch
            {
                Response.Redirect("~/WebForM_Beneficiarios.aspx");
            }
        }

        protected void alta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForM_Beneficiarios.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GridView1.SelectedIndex;
            nombre.Text = GridView1.Rows[index].Cells[1].Text;
            dias.Text = GridView1.Rows[index].Cells[3].Text;
            inicia.Text = GridView1.Rows[index].Cells[4].Text;
            termina.Text = GridView1.Rows[index].Cells[5].Text;
            costo.Text = GridView1.Rows[index].Cells[2].Text;
        }
    }
}