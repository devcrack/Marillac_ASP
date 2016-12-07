using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Oracle.DataAccess.Client;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Prueba_Mierda_ASP
{
    public partial class altaBeneficiarioActividad : System.Web.UI.Page
    {

        string stringConnection = "Data Source = xe; User Id = MARILLAC_2; Password = oracle";
        int id = 0;
        int altaB;

        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            if (Request.Params["parametro"] != null)
            {
                string aux;
                aux = Request.Params["parametro"];
                altaB = Convert.ToInt16(aux);
                Label2.Text = aux;
                altaBeneficiario();
            }
        }

        void altaBeneficiario()
        {
            try
            {
                OracleConnection con = new OracleConnection();
                OracleCommand query;
                string cmd;
                con.ConnectionString = stringConnection;
                con.Open();

                cmd = "INSERT INTO INSCRIPCIONBENEFICIARIO (IDACTIVIDAD, IDBENEFICIARIO) VALUES (" + Convert.ToInt16(Label2.Text) + " , " + Convert.ToInt16(Label1.Text) + ")";
                query = new OracleCommand(cmd, con);

                try
                {
                    query.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }
        }

        void mostrarDatos()
        {
            try
            {
                OracleConnection m = new OracleConnection();
                m.ConnectionString = stringConnection;
                m.Open();
                string consulta = "SELECT IDBENEFICIARIO, NOMBRE, PATERNO, MATERNO FROM BENEFICIARIO";

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

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.NewSelectedIndex];
            id = Convert.ToInt16(row.Cells[0].Text);
            Label1.Text = id.ToString();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow r in GridView1.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    r.ToolTip = "Click to select row";
                    r.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.GridView1, "Select$" + r.RowIndex, true);
                }
            }

            base.Render(writer);
        }

        // BOTON CANCELAR
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Actividad.aspx?");
        }

        // BOTON ACEPTAR
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Actividad.aspx?");
        }
    }
}