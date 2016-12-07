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
    public partial class hijos : System.Web.UI.Page
    {

        Decimal id;
        string idbene="";

        string stringConnection = "Data Source = xe; User Id = MARILLAC_DEF; Password = oracle";

        protected void Page_Load(object sender, EventArgs e)
        {
            //con("INSERT INTO COSA VALUES(100)");

            hijostabla.DataSource = conDatos("SELECT *  FROM HIJO");

            hijostabla.DataBind();
        }

        public DataSet conDatos(String consulta)
        {


            OracleConnection m = new OracleConnection();
            m.ConnectionString = stringConnection;
            m.Open();
            OracleDataAdapter con = new OracleDataAdapter(consulta, m);

            DataSet tabla = new DataSet();
            con.Fill(tabla);

            m.Close();

            return tabla;
            //tabla2.DataSource = tabla.Tables[0].DefaultView;
            //tabla2.DataBind();
       

        }


        public void con(string cmd)
        {
            OracleConnection con = new OracleConnection();
            OracleCommand query;

            try
            {
                con.ConnectionString = stringConnection;
                con.Open();
                query = new OracleCommand(cmd, con);
                try
                {
                    query.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }
      }

        protected void tabla2_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion_tablaHijos();
  
        }

        protected void tabla2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = hijostabla.Rows[e.NewSelectedIndex];

            id = Decimal.Parse(row.Cells[0].Text);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow r in hijostabla.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    r.ToolTip = "Click to select row";
                    r.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.hijostabla, "Select$" + r.RowIndex, true);
                }
            }


            foreach (GridViewRow r in beneficiariostabla.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    r.ToolTip = "Click to select row";
                    r.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.beneficiariostabla, "Select$" + r.RowIndex, true);
                }
            }

            base.Render(writer);


        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            hijostabla.SelectedIndex = -1;
        }

        protected void boton_limpiar_Click(object sender, EventArgs e)
        {

            limpiartodo();

         

        }

        public void limpiartodo()
        {
            hijostabla.SelectedIndex = -1;
            beneficiariostabla.SelectedIndex = -1;
            actividadestabla.SelectedIndex = -1;
            actividadestabla.DataSource = null;
            actividadestabla.DataBind();


            idbene = "";
            nombre.Text = "";
            paterno.Text = "";
            materno.Text = "";
            beneficiario.Text = "";
            fecha.Text = "";
            sexo.ClearSelection();
            TextBox1.Text="";


        }

        public void seleccion_tablaHijos()
        {


            GridViewRow row = hijostabla.SelectedRow;
            
            hijostabla.SelectedRowStyle.BackColor = System.Drawing.Color.Coral;
            nombre.Text = row.Cells[3].Text;
           
            paterno.Text= row.Cells[4].Text;
            materno.Text = row.Cells[5].Text;
            sexo.Text = row.Cells[6].Text;
            fecha.Text = row.Cells[7].Text;
            fecha.Text = fecha.Text.Substring(0, 10);
            idbene = row.Cells[1].Text;
            TextBox1.Text = idbene;
            idbene = TextBox1.Text;
            //beneficiario.Text = textoben(row.Cells[1].Text);

            actividadestabla.SelectedIndex = -1;
            actividaddatos(row.Cells[0].Text);
        


       }


        public string textoben(string text)
        {
            string cad = "SELECT paterno,materno,nombre  From BENEFICIARIO where idBeneficiario =" + text;

            return conDatos(cad).Tables[0].Rows[0].ItemArray[0].ToString() + " " + conDatos(cad).Tables[0].Rows[0].ItemArray[1].ToString() + " " + conDatos(cad).Tables[0].Rows[0].ItemArray[2].ToString();
            
        }

        protected void hijostabla_PreRender(object sender, EventArgs e)
        {
         


        }

        protected void boton_agregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        public void agregar()
        {
            if (nombre.Text != "" && paterno.Text != "" && materno.Text != "" && sexo.Text != "" && fecha.Text != "" && TextBox1.Text != "")
            {
                string query = "INSERT INTO HIJO (NOMBRE, PATERNO,MATERNO,SEXO, FECHANACIMIENTO ,IDBENEFICIARIO) VALUES('" + nombre.Text + "', '" + paterno.Text + "', '" + materno.Text + "', '" + sexo.Text + "', '" + fecha.Text + "', '" + TextBox1.Text + "')";
                con(query);
                limpiartodo();
                actDatos();
            }

        }

        public void modificar()
        {
            //
            if (nombre.Text != "" && paterno.Text != "" && materno.Text != "" && sexo.Text != "" && fecha.Text != "" && TextBox1.Text != "" && hijostabla.SelectedRow != null)
                
            {
                
                String idModificar = hijostabla.Rows[hijostabla.SelectedIndex].Cells[0].Text;
                string query = "UPDATE HIJO SET nombre='" + nombre.Text + "',IDBENEFICIARIO='" + TextBox1.Text + "', PATERNO='" + paterno.Text + "', MATERNO='" + materno.Text + "', SEXO='" + sexo.Text + "', FECHANACIMIENTO='" + fecha.Text +"' WHERE idHIJO=" + idModificar;
                con(query);
                limpiartodo();
                actDatos();
            }
        
        }

        public void actDatos()
        {
            hijostabla.DataSource = conDatos("SELECT *  FROM HIJO");
            hijostabla.DataBind();

        }

        protected void boton_modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        protected void boton_eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        public void eliminar()
        {
            string chey = "";
            if (nombre.Text != "" && paterno.Text != "" && materno.Text != "" && sexo.Text != "" && fecha.Text != "" && TextBox1.Text != "" && hijostabla.SelectedRow != null)
            {

                String idEliminar = hijostabla.Rows[hijostabla.SelectedIndex].Cells[0].Text;
                string query = "DELETE FROM HIJO WHERE IDHIJO=" + idEliminar;
                con(query);
                limpiartodo();
                actDatos();

            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            obtieneNombreBene();
        }


        public void obtieneNombreBene()
        {

            string cad = "SELECT PATERNO, MATERNO,NOMBRE, IDBENEFICIARIO From BENEFICIARIO";
            beneficiariostabla.DataSource = conDatos(cad);



            beneficiariostabla.DataBind();
            beneficiariostabla.SelectedIndex = -1;
            Panel1.Visible = !Panel1.Visible;


        }

        protected void beneficiariostabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = beneficiariostabla.SelectedRow;

            beneficiariostabla.SelectedRowStyle.BackColor = System.Drawing.Color.Coral;
            beneficiario.Text = row.Cells[0].Text + " " + row.Cells[1].Text + " " + row.Cells[2].Text;
            TextBox1.Text = row.Cells[3].Text;
        }

        protected void aceptar_beneficiario_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;

            beneficiariostabla.SelectedIndex = -1;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            beneficiario.Text = "";
            TextBox1.Text = "";
            beneficiariostabla.SelectedIndex = -1;
        }

        protected void beneficiariostabla_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = hijostabla.Rows[e.NewSelectedIndex];
        }


        public void actividaddatos(string idhijo1)
        {

            /*  string cad = "Select act.IDACTIVIDAD,act.NOMBREACTIVIDAD," +
              ",act.INSCRITOS,CONCAT(prof.NOMBRE, ' ', prof.PATERNO) as PROFESOR,inhijo.SALDO From ACTIVIDAD as act " +
              "inner join INSCRIPCIONHIJO as inhijo on inhijo.IDACTIVIDAD = act.IDACTIVIDAD " +
              "inner join PROFESOR as prof on act.IDPROFESOR = prof.IDPROFESOR where inhijo.IDHIJO =" + idhijo1;

              actividadestabla.DataSource = conDatos(cad);
              actividadestabla.DataBind();*/

           string cad = "Select act.NOMBREACTIVIDAD " +
           "From ACTIVIDAD  act " +
           "inner join INSCRIPCIONHIJO  inhijo on inhijo.IDACTIVIDAD = act.IDACTIVIDAD " +
           "inner join PROFESOR  prof on act.IDPROFESOR = prof.IDPROFESOR where inhijo.IDHIJO =" + idhijo1;

            actividadestabla.DataSource = conDatos(cad);
            actividadestabla.DataBind(); 


        }

        protected void boton_salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }
    }
}