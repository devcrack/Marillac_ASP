using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
//using Oracle.DataAccess.Client;
using System.Data;

namespace Prueba_Mierda_ASP
{
    public partial class Actividad : System.Web.UI.Page
    {
        string stringConnection = "Data Source = localhost; User Id = MARILLAC; Password = Mvaldes1";
        string dias = "";
        int idA;
        int idB;
        int idH;
        int altaB;
        int altaH;


        //LO QUE SE HACE CUANDO SE CARGA LA PAGINA
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            
        }


        //SE CHECAN LOS DIAS MARCADOS EN LAS CHECK BOX
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
                str += "Domingo ";
            }
            if (CheckBox4.Checked == true)
            {
                str += "Miercoles ";
            }
            if (CheckBox5.Checked == true)
            {
                str += "Jueves ";
            }
            if (CheckBox6.Checked == true)
            {
                str += "Viernes ";
            }
            if (CheckBox7.Checked == true)
            {
                str += "Sabado ";
            }
            return str;
        }


        //BOTON PARA REGRESAR AL MENU PRINCIPAL
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx?param1=");
        }


        //SE CARGAN LOS DATOS EN CUANTO SE ABRE LA PAGINA
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
                string consulta2 = "SELECT IDACTIVIDAD, IDPROFESOR, NOMBREACTIVIDAD, CUPO, INSCRITOS, DIASIMPARTE, HORAINICIO, HORAFINAL FROM ACTIVIDAD";

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


        // BOTON PARA AGREGAR ACTIVIDADES
        // ALTA ACTIVIDAD
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                OracleCommand query;
                string cmd;
                con.ConnectionString = stringConnection;
                con.Open();
                dias = checaDias();

                if (TextBox6.Text == "&nbsp;")
                    TextBox6.Text = "NULL";
                cmd = "INSERT INTO ACTIVIDAD (IDPROFESOR, NOMBREACTIVIDAD, CUPO, DIASIMPARTE, HORAINICIO, HORAFINAL, INSCRITOS) VALUES ('" +TextBox6.Text + "' , '" + TextBox1.Text + "', " + TextBox4.Text + ", '" + dias + "', " +TextBox2.Text+ ", " + TextBox3.Text + ", " + 0 + ")";
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
            mostrarDatos();
            limpiar();
        }

        void limpiar()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            //TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";

            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            CheckBox6.Checked = false;
            CheckBox7.Checked = false;

            dias = "";
        }


        //FUNCION PARA SELECCIONAR RENGLON DE LA TABLA DE ACTIVIDADES 1/3
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView2.SelectedRow;
        }

        //FUNCION PARA SELECCIONAR RENGLON DE LA TABLA DE ACTIVIDADES 2/3
        protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = GridView2.Rows[e.NewSelectedIndex];
            idA = Convert.ToInt16(row.Cells[0].Text);
            TextBox7.Text = idA.ToString();
            TextBox6.Text = row.Cells[1].Text;
            TextBox1.Text = row.Cells[2].Text;
            TextBox4.Text = row.Cells[3].Text;
            TextBox2.Text = row.Cells[6].Text;
            TextBox3.Text = row.Cells[7].Text;
            string aux = "";
            aux = row.Cells[5].Text;

            if (aux.Contains("Lunes"))
                CheckBox1.Checked = true;
            else
                CheckBox1.Checked = false;
            if (aux.Contains("Martes"))
                CheckBox2.Checked = true;
            else
                CheckBox2.Checked = false;
            if (aux.Contains("Miercoles"))
                CheckBox4.Checked = true;
            else
                CheckBox4.Checked = false;
            if (aux.Contains("Jueves"))
                CheckBox5.Checked = true;
            else
                CheckBox5.Checked = false;
            if (aux.Contains("Viernes"))
                CheckBox6.Checked = true;
            else
                CheckBox6.Checked = false;
            if (aux.Contains("Sabado"))
                CheckBox7.Checked = true;
            else
                CheckBox7.Checked = false;
            if (aux.Contains("Domingo"))
                CheckBox3.Checked = true;
            else
                CheckBox3.Checked = false;

            seleccionaBeneficiario(idA);
            seleccionaHijo(idA);

            Label1.Text = "";
            Label2.Text = "";
        }


        void seleccionaBeneficiario(int W)
        {
            try
            {
                OracleConnection m2 = new OracleConnection();
                m2.ConnectionString = stringConnection;
                m2.Open();
                string consulta2 = "SELECT INSCRIPCIONBENEFICIARIO.IDACTIVIDAD, INSCRIPCIONBENEFICIARIO.IDBENEFICIARIO, BENEFICIARIO.NOMBRE, BENEFICIARIO.PATERNO FROM INSCRIPCIONBENEFICIARIO INNER JOIN BENEFICIARIO ON INSCRIPCIONBENEFICIARIO.IDBENEFICIARIO = BENEFICIARIO.IDBENEFICIARIO WHERE INSCRIPCIONBENEFICIARIO.IDACTIVIDAD = " + W;

                OracleDataAdapter con2 = new OracleDataAdapter(consulta2, m2);

                DataSet tabla2 = new DataSet();
                con2.Fill(tabla2);
                GridView3.DataSource = tabla2.Tables[0].DefaultView;
                GridView3.DataBind();
            }
            catch (OracleException ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }
        }

        void seleccionaHijo(int Y)
        {
            try
            {
                OracleConnection m2 = new OracleConnection();
                m2.ConnectionString = stringConnection;
                m2.Open();
                string consulta2 = "SELECT INSCRIPCIONHIJO.IDACTIVIDAD, INSCRIPCIONHIJO.IDHIJO, HIJO.NOMBRE, HIJO.PATERNO FROM INSCRIPCIONHIJO INNER JOIN HIJO ON INSCRIPCIONHIJO.IDHIJO = HIJO.IDHIJO WHERE INSCRIPCIONHIJO.IDACTIVIDAD = " + Y;

                OracleDataAdapter con2 = new OracleDataAdapter(consulta2, m2);

                DataSet tabla2 = new DataSet();
                con2.Fill(tabla2);
                GridView4.DataSource = tabla2.Tables[0].DefaultView;
                GridView4.DataBind();
            }
            catch (OracleException ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }
        }

        //FUNCION PARA SELECCIONAR RENGLON DE LA TABLA DE ACTIVIDADES 3/3
        protected override void Render(HtmlTextWriter writer)
        {
            foreach (GridViewRow r in GridView2.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    r.ToolTip = "Click to select row";
                    r.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.GridView2, "Select$" + r.RowIndex, true);
                }
            }

            foreach (GridViewRow r in GridView3.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    r.ToolTip = "Click to select row";
                    r.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.GridView3, "Select$" + r.RowIndex, true);
                }
            }

            foreach (GridViewRow r in GridView4.Rows)
            {
                if (r.RowType == DataControlRowType.DataRow)
                {
                    r.ToolTip = "Click to select row";
                    r.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.GridView4, "Select$" + r.RowIndex, true);
                }
            }

            base.Render(writer);
        }


        //BOTON PARA LIMPIAR EL FORMULARIO
        protected void Button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        //BOTON PARA ELIMINAR UNA ACTIVIDAD
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                OracleCommand query;
                string cmd;
                int exxx = Convert.ToInt16(TextBox7.Text);
                con.ConnectionString = stringConnection;
                con.Open();

                cmd = "DELETE FROM ACTIVIDAD WHERE IDACTIVIDAD = " + exxx;
                //     delete from ACTIVIDAD where IDACTIVIDAD = 24
                query = new OracleCommand(cmd, con);

                try
                {
                    query.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
                    Response.Write("Beneficiario y/o Hijo inscrito en la Actividad");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }
            mostrarDatos();
            limpiar();
        }


        //BOTON PARA MODIFICAR UNA ACTIVIDAD
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int exxx = Convert.ToInt16(TextBox7.Text);
                OracleConnection con = new OracleConnection();
                OracleCommand query;
                string cmd;
                con.ConnectionString = stringConnection;
                con.Open();
                dias = checaDias();

                if (TextBox6.Text == "&nbsp;")
                    TextBox6.Text = "NULL";
                cmd = "UPDATE ACTIVIDAD SET IDPROFESOR = " + TextBox6.Text + ", NOMBREACTIVIDAD = '" + TextBox1.Text + "', CUPO = " + TextBox4.Text + ", DIASIMPARTE = '" + dias + "', HORAINICIO = " + TextBox2.Text + ", HORAFINAL = " + TextBox3.Text + " WHERE IDACTIVIDAD = " + exxx;
                //IDPROFESOR,                                                                        NOMBREACTIVIDAD,                       CUPO,                                       DIASIMPARTE,                    HORAINICIO, HORAFINAL
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
            mostrarDatos();
            limpiar();
        }


        // SELECCION DEL BENEFICIARIO EN X ACTIVIDAD 1/2
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView3.SelectedRow;
        }

        // SELECCION DEL BENEFICIARIO EN X ACTIVIDAD 2/2
        protected void GridView3_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = GridView3.Rows[e.NewSelectedIndex];
            idB = Convert.ToInt16(row.Cells[1].Text);
            Label1.Text = idB.ToString();
        }


        // BAJA DE BENEFICIARIO DE X ACTIVIDAD
        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                OracleCommand query;
                string cmd;
                int exxx = Convert.ToInt16(Label1.Text);
                con.ConnectionString = stringConnection;
                con.Open();

                cmd = "DELETE FROM INSCRIPCIONBENEFICIARIO WHERE IDBENEFICIARIO = " + exxx;
                query = new OracleCommand(cmd, con);

                try
                {
                    query.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
                    Response.Write("Beneficiario y/o Hijo inscrito en la Actividad");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }
            seleccionaBeneficiario(idA);
            Label1.Text = "";
        }


        // SELECCION DE HIJO EN X ACTIVIDAD 1/2
        protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView4.SelectedRow;
        }

        // SELECCION DE HIJO EN X ACTIVIDAD 2/2
        protected void GridView4_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = GridView4.Rows[e.NewSelectedIndex];
            idH = Convert.ToInt16(row.Cells[1].Text);
            Label2.Text = idH.ToString();
        }


        // BAJA DE HIJO DE X ACTIVIDAD
        protected void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con = new OracleConnection();
                OracleCommand query;
                string cmd;
                int exxx = Convert.ToInt16(Label2.Text);
                con.ConnectionString = stringConnection;
                con.Open();

                cmd = "DELETE FROM INSCRIPCIONHIJO WHERE IDHIJO = " + exxx;
                query = new OracleCommand(cmd, con);

                try
                {
                    query.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
                    Response.Write("Beneficiario y/o Hijo inscrito en la Actividad");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert" + UniqueID, "alert('" + ex + "');", true);
            }
            seleccionaHijo(idH);
            Label2.Text = "";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("altaBeneficiarioActividad.aspx?parametro=" + TextBox7.Text);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("altaHijoActividad.aspx?parametro=" + TextBox7.Text);
        }
    }
}