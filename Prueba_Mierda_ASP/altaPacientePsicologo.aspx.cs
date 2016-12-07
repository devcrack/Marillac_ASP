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
    public partial class altaPacientePsicologo : System.Web.UI.Page
    {
        string sConection = "Data Source=localhost; User Id=MARILLAC; Password=Mvaldes1";
        private int idPsicologo;
        static int idInscrito;
        static int idNoInscrito;

        protected void Page_Load(object sender, EventArgs e)
        {       
            if (Request.Params["idPsicologo"] != null)
            {
                string aux;
                aux = Request.Params["idPsicologo"];
                idPsicologo = Convert.ToInt16(aux);
            }
            cargarTablas();
        }

        protected void cargarTablas()
        {
            if(beneficiarios.Checked==true)
            {
                OracleConnection conexion = new OracleConnection();
                conexion.ConnectionString = this.sConection;
                conexion.Open();

                string query = "SELECT idBeneficiario, idPsicologo, nombre, paterno, materno, telefono, edad FROM BENEFICIARIO WHERE idPsicologo="+idPsicologo;

                OracleDataAdapter con = new OracleDataAdapter(query, conexion);
                DataSet tabla = new DataSet();
                con.Fill(tabla);
                tabla.Tables[0].Columns[0].ColumnName = "Id Ben";
                tabla.Tables[0].Columns[1].ColumnName = "Id Psi";
                beneficiariosInscritos.DataSource = tabla.Tables[0].DefaultView;
                beneficiariosInscritos.DataBind();

                conexion.Close();

                query = "SELECT idBeneficiario, idPsicologo, nombre, paterno, materno, telefono, edad FROM BENEFICIARIO WHERE idPsicologo IS NULL";

                con = new OracleDataAdapter(query, conexion);
                tabla = new DataSet();
                con.Fill(tabla);
                tabla.Tables[0].Columns[0].ColumnName = "Id Ben";
                tabla.Tables[0].Columns[1].ColumnName = "Id Psi";
                beneficiariosNoInscritos.DataSource = tabla.Tables[0].DefaultView;
                beneficiariosNoInscritos.DataBind();
            }
            else
            {
                OracleConnection conexion = new OracleConnection();
                conexion.ConnectionString = this.sConection;
                conexion.Open();

                string query = "SELECT idBeneficiario, idPsicologo, nombre, paterno, materno, edad FROM hijo WHERE idPsicologo=" + idPsicologo;

                OracleDataAdapter con = new OracleDataAdapter(query, conexion);
                DataSet tabla = new DataSet();
                con.Fill(tabla);
                tabla.Tables[0].Columns[0].ColumnName = "Id Hijo";
                tabla.Tables[0].Columns[1].ColumnName = "Id Psi";
                beneficiariosInscritos.DataSource = tabla.Tables[0].DefaultView;
                beneficiariosInscritos.DataBind();

                conexion.Close();

                query = "SELECT idBeneficiario, idPsicologo, nombre, paterno, materno, edad  FROM hijo WHERE idPsicologo IS NULL";

                con = new OracleDataAdapter(query, conexion);
                tabla = new DataSet();
                con.Fill(tabla);
                tabla.Tables[0].Columns[0].ColumnName = "Id Hijo";
                tabla.Tables[0].Columns[1].ColumnName = "Id Psi";
                beneficiariosNoInscritos.DataSource = tabla.Tables[0].DefaultView;
                beneficiariosNoInscritos.DataBind();

            }
        }

        protected void alta_Click(object sender, EventArgs e)
        {
            if(beneficiarios.Checked==true)
            {
                try
                {
                    OracleConnection m = new OracleConnection();
                    OracleCommand cmd;
                    string query;
                    m.ConnectionString = sConection;
                    m.Open();
                    query = "UPDATE beneficiario SET idPsicologo=" + idPsicologo + " WHERE idBeneficiario="+idNoInscrito;
                    cmd = new OracleCommand(query, m);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true); }
            }
            else
            {
                OracleConnection m = new OracleConnection();
                OracleCommand cmd;
                string query;
                m.ConnectionString = sConection;
                m.Open();
                query = "UPDATE hijo SET idPsicologo=" + idPsicologo + " WHERE idBeneficiario=" + idNoInscrito;
                cmd = new OracleCommand(query, m);
                cmd.ExecuteNonQuery();
            }
            cargarTablas();
        }

        protected void beneficiarios_CheckedChanged(object sender, EventArgs e)
        {
            if (beneficiarios.Checked == true)
                hijos.Checked = false;
            else
                hijos.Checked = true;

            cargarTablas();
        }

        protected void hijos_CheckedChanged(object sender, EventArgs e)
        {
            if (hijos.Checked == true)
                beneficiarios.Checked = false;
            else
                beneficiarios.Checked = true;

            cargarTablas();
        }

        protected void baja_Click(object sender, EventArgs e)
        {
            if (beneficiarios.Checked == true)
            {
                try
                {
                    OracleConnection m = new OracleConnection();
                    OracleCommand cmd;
                    string query;
                    m.ConnectionString = sConection;
                    m.Open();
                    query = "UPDATE beneficiario SET idPsicologo=NULL WHERE idBeneficiario=" + idInscrito;
                    cmd = new OracleCommand(query, m);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true); }
            }
            else
            {
                OracleConnection m = new OracleConnection();
                OracleCommand cmd;
                string query;
                m.ConnectionString = sConection;
                m.Open();
                query = "UPDATE hijo SET idPsicologo=NULL WHERE idBeneficiario=" + idInscrito;
                cmd = new OracleCommand(query, m);
                cmd.ExecuteNonQuery();
            }
            cargarTablas();
        }

        protected void salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WForm_Psicologos.aspx");
        }

        protected void beneficiariosInscritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            idInscrito= int.Parse(beneficiariosInscritos.Rows[beneficiariosInscritos.SelectedIndex].Cells[1].Text);
        }

        protected void beneficiariosNoInscritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            idNoInscrito = int.Parse(beneficiariosNoInscritos.Rows[beneficiariosNoInscritos.SelectedIndex].Cells[1].Text);
        }
    }
}