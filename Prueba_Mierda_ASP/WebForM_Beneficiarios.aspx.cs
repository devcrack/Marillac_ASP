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
    public partial class WebForM_Beneficiarios : System.Web.UI.Page
    {
        string sConection = "Data Source=localhost; User Id=MARILLAC; Password=Mvaldes1";

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        protected void cargarDatos()
        {
            OracleConnection conexion = new OracleConnection();
            conexion.ConnectionString = this.sConection;
            conexion.Open();

            string query = "SELECT * FROM BENEFICIARIO ORDER BY IDBENEFICIARIO";

            OracleDataAdapter con = new OracleDataAdapter(query, conexion);
            DataSet tabla = new DataSet();
            con.Fill(tabla);
            tabla.Tables[0].Columns.Remove("idPsicologo");
            tabla.Tables[0].Columns[0].ColumnName = "Id";
            tabla.Tables[0].Columns[1].ColumnName = "Nombre";
            tabla.Tables[0].Columns[2].ColumnName = "Apellido paterno";
            tabla.Tables[0].Columns[3].ColumnName = "Apellido materno";
            tabla.Tables[0].Columns[4].ColumnName = "Dirección";
            tabla.Tables[0].Columns[5].ColumnName = "Colonia";
            tabla.Tables[0].Columns[6].ColumnName = "Teléfono";
            tabla.Tables[0].Columns[7].ColumnName = "Sexo";
            tabla.Tables[0].Columns[8].ColumnName = "Fecha de nacimiento";
            tabla.Tables[0].Columns[9].ColumnName = "Edad";
            GridView1.DataSource = tabla.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }

        protected void alta_Click(object sender, EventArgs e)
        {
            if(nombre.Text!="" && paterno.Text!="" && materno.Text!="" && direccion.Text!="" && colonia.Text!="" && telefono.Text!="" && fechaNacimiento.Text!="")
            {
                try
                {
                    OracleConnection m = new OracleConnection();
                    OracleCommand cmd;
                    string query;
                    m.ConnectionString = sConection;
                    m.Open();
                    string sexo;
                    if (masculino.Checked == true)
                        sexo = "M";
                    else
                        sexo = "F";                                    
                    query = "INSERT INTO beneficiario(nombre, paterno, materno, direccion, colonia, telefono, sexo, fechaNacimiento)"+
                    " VALUES('"+nombre.Text+"', '"+paterno.Text+"', '"+materno.Text+"', '"+direccion.Text+"', '"+colonia.Text+"', "+telefono.Text+", '"+sexo+"', '"+fechaNacimiento.Text+"')";
                    cmd = new OracleCommand(query, m);
                    cmd.ExecuteNonQuery();
                    cargarDatos();
                    limpiarDatos(); 
                }
                catch (Exception ex) { Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true); }
            }
            else
            {
                string script = "alert(\"No se pueden dejar campos vacíos.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
                
            
        }

        protected void limpiarDatos()
        {
            nombre.Text = "";
            paterno.Text = "";
            materno.Text = "";
            direccion.Text = "";
            colonia.Text = "";
            telefono.Text = "";
            masculino.Checked = true;
            fechaNacimiento.Text = "";
            femenino.Checked = false;
        }

        protected void limpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        protected void masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (masculino.Checked == true)
                femenino.Checked = false;
            else
                femenino.Checked = true;   
        }

        protected void femenino_CheckedChanged(object sender, EventArgs e)
        {
            if (femenino.Checked == true)
                masculino.Checked = false;
            else
                masculino.Checked = true;
        }

        protected void fechaNacimiento_TextChanged(object sender, EventArgs e)
        {
            bool limpiar = false;
            if (fechaNacimiento.Text.Length != 10)
                limpiar = true;
            else
            {
                if (fechaNacimiento.Text[0] < 48 || fechaNacimiento.Text[0] > 51)
                    limpiar = true;
                if (fechaNacimiento.Text[2] != '-' || fechaNacimiento.Text[5] != '-')
                    limpiar = true;
                if (fechaNacimiento.Text[1] < 48 || fechaNacimiento.Text[1] > 57)
                    limpiar = true;
                if (fechaNacimiento.Text[3] != '0' && fechaNacimiento.Text[3] != '1')
                    limpiar = true;
                if (fechaNacimiento.Text[4] < 48 || fechaNacimiento.Text[4] > 57)
                    limpiar = true;
                if (fechaNacimiento.Text[6] < 48 || fechaNacimiento.Text[6] > 57 || fechaNacimiento.Text[7] < 48 || fechaNacimiento.Text[7] > 57 || fechaNacimiento.Text[8] < 48 || fechaNacimiento.Text[8] > 57 || fechaNacimiento.Text[9] < 48 || fechaNacimiento.Text[9] > 57)
                    limpiar = true;
            }

            if (limpiar == true)
                fechaNacimiento.Text = "";
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = GridView1.SelectedIndex;
            nombre.Text= GridView1.Rows[index].Cells[2].Text;
            paterno.Text = GridView1.Rows[index].Cells[3].Text;
            materno.Text = GridView1.Rows[index].Cells[4].Text;
            direccion.Text= GridView1.Rows[index].Cells[5].Text;
            colonia.Text = GridView1.Rows[index].Cells[6].Text;
            telefono.Text = GridView1.Rows[index].Cells[7].Text;

            string fecha = "";
            fecha += GridView1.Rows[index].Cells[9].Text[0].ToString();
            fecha += GridView1.Rows[index].Cells[9].Text[1].ToString();
            fecha += "-";
            fecha += GridView1.Rows[index].Cells[9].Text[3].ToString();
            fecha += GridView1.Rows[index].Cells[9].Text[4].ToString();
            fecha += "-";
            fecha += GridView1.Rows[index].Cells[9].Text[6].ToString();
            fecha += GridView1.Rows[index].Cells[9].Text[7].ToString();
            fecha += GridView1.Rows[index].Cells[9].Text[8].ToString();
            fecha += GridView1.Rows[index].Cells[9].Text[9].ToString();
            fechaNacimiento.Text = fecha;

            if(GridView1.Rows[index].Cells[8].Text=="M")
            {
                masculino.Checked = true;
                femenino.Checked = false;
            }
            else
            {
                masculino.Checked = false;
                femenino.Checked = true;
            }

        }

        protected void baja_Click(object sender, EventArgs e)
        {
            //Eliminar
            int index = GridView1.SelectedIndex;
            int idBeneficiario = int.Parse(GridView1.Rows[index].Cells[1].Text);

            try
            {
                OracleConnection m = new OracleConnection();
                OracleCommand cmd;
                string query;
                m.ConnectionString = sConection;
                m.Open();
                query = "DELETE FROM beneficiario WHERE idBeneficiario=" + idBeneficiario;
                cmd = new OracleCommand(query, m);
                cmd.ExecuteNonQuery();
                cargarDatos();
                limpiarDatos();
            }
            catch (Exception ex) { Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true); }
        }

        protected void modificar_Click(object sender, EventArgs e)
        {
            if (nombre.Text != "" && paterno.Text != "" && materno.Text != "" && direccion.Text != "" && colonia.Text != "" && telefono.Text != "" && fechaNacimiento.Text != "")
            {
                int index = GridView1.SelectedIndex;
                int idBeneficiario = int.Parse(GridView1.Rows[index].Cells[1].Text);

                try
                {
                    OracleConnection m = new OracleConnection();
                    OracleCommand cmd;
                    string query;
                    m.ConnectionString = sConection;
                    m.Open();
                    string sexo;
                    if (masculino.Checked == true)
                        sexo = "M";
                    else
                        sexo = "F";
                    query = "UPDATE beneficiario SET " +
                    "nombre='" + nombre.Text + "', paterno='" + paterno.Text + "', materno='" + materno.Text + "', direccion='" + direccion.Text + "', colonia='" + colonia.Text + "', telefono=" + telefono.Text + ", sexo='" + sexo + "', fechaNacimiento='"+fechaNacimiento.Text+"' "+

                    "WHERE idBeneficiario=" + idBeneficiario;
                    cmd = new OracleCommand(query, m);
                    cmd.ExecuteNonQuery();
                    cargarDatos();
                    limpiarDatos();
                }
                catch (Exception ex) { Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true); }
            }
            else
                {
                    string script = "alert(\"No se pueden dejar campos vacíos.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
        }
    }
}