using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;

namespace Prueba_Mierda_ASP
{
    public partial class WForm_Psicologos : System.Web.UI.Page
    {
        Connection_db connection = new Connection_db();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.show_info();
        }

        private void show_info()
        {
            this.GridView_Psico.DataSource = this.connection.query_get_data("PSICOLOGO").Tables[0].DefaultView;
            this.GridView_Psico.DataBind();
        }

        protected void GridView_Psico_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow rw in this.GridView_Psico.Rows)
            {
                if (rw.RowIndex == this.GridView_Psico.SelectedIndex)
                {
                    rw.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                    this.TextBox_Nombre.Text = rw.Cells[1].Text;
                    this.TextBox_ApP.Text = rw.Cells[2].Text;
                    this.TextBox_ApM.Text = rw.Cells[3].Text;
                    this.TextBox_Dir.Text = rw.Cells[4].Text;
                    this.TextBox_Colon.Text = rw.Cells[5].Text;
                    this.TextBox_Tel.Text = rw.Cells[6].Text;
                    this.radio_Button_Change(Convert.ToChar(rw.Cells[7].Text));
                    this.TextBox_LimitPac.Text = rw.Cells[8].Text;
                    this.TextBox_Fech_Nac.Text = rw.Cells[10].Text;
                    this.TextBox_Edad.Text = rw.Cells[11].Text;
                    this.TextBox_DiasL.Text = (string.Compare(rw.Cells[12].Text, "&nbsp;") == 0) ? "" : rw.Cells[12].Text;
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "No mames", "alert('Registro Seleccionado')", true);
                }
                else
                {
                    rw.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
        }

        protected void GridView_Psico_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
         
        }


        private void radio_Button_Change(char c)
        {
            if (c == 'M')
                this.radioButt_Male.Checked = true;
            else 
                this.radioButt_Female.Checked = true;
        }
        
        private char get_Sexo()
        {
            return (this.radioButt_Male.Checked) ? 'M' : 'F';
        }

        protected void GridView_Psico_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmmouseover"] = "this.style.cursor='pointer'; this.style.textDecoration='underline'; ";
                e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none'; ";
                e.Row.ToolTip = "Haga Click para seleccionar la fila";
                e.Row.Attributes["onclick"] = this.Page.ClientScript.GetPostBackClientHyperlink(this.GridView_Psico, "Select$" + e.Row.RowIndex);
            }
        }

        private bool check_values()
        {
            foreach(Control c in this.Controls)
            {
                if( c is TextBox)
                {
                    if(string.Compare(((TextBox)c).Text,string.Empty) == 0)
                    {
                        // string script = "alert(\"No deben existir campos vacios.\");";
                        //ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "No mames", "alert('NO DEBE DE HABER CAMPOS VACIOS')", true);
                        return false;
                    }
                }
                if(!this.radioButt_Female.Checked)
                {
                    if(!this.radioButt_Male.Checked)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "No mames", "alert('Seleccione el Sexo')", true);
                        return false;
                    }
                }
            }
            return true;
        }


        private bool check_fields()
        {
            if (string.Compare(this.TextBox_Nombre.Text, string.Empty) == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ServerControlScript", "alert('NO hay Nombre')", true);
                return false;
            }
            if (string.Compare(this.TextBox_ApP.Text, string.Empty) == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ServerControlScript", "alert('No hay Apellido Paterno')", true);

                return false;
            }
            if (string.Compare(this.TextBox_ApM.Text, string.Empty) == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ServerControlScript", "alert('No hay Apellido Materno')", true);
                return false;
            }
            if (string.Compare(this.TextBox_Dir.Text, string.Empty) == 0)
            { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ServerControlScript", "alert('No hay Direccion')", true);
                return false;
            }
            if (string.Compare(this.TextBox_Colon.Text, string.Empty) == 0)
                return false;
            if (string.Compare(this.TextBox_Tel.Text, string.Empty) == 0)
                return false;
            if (string.Compare(this.TextBox_DiasL.Text, string.Empty) == 0)
                return false;
            if (string.Compare(this.TextBox_LimitPac.Text, string.Empty) == 0)
                return false;
            if (!this.radioButt_Female.Checked)
            {
                if (!this.radioButt_Male.Checked)
                {
                    string script = "alert(\"Seleccione un Sexo.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    return false;
                }
            }
            return true;
        }

        private void manage_Days(bool is_check, string str)
        {
            if (is_check)
            {

                if (this.TextBox_DiasL.Text.Contains(str) == false)
                    this.TextBox_DiasL.Text += str;
            }
            else
            {
                if (this.TextBox_DiasL.Text.Contains(str) == true)
                {
                    string str_1 = this.TextBox_DiasL.Text;
                    str_1 = str_1.Replace(str, string.Empty);
                    this.TextBox_DiasL.Text = str_1;
                }
            }
        }

         public void sort_days()
        {
            string main_String = this.TextBox_DiasL.Text;
            string txt_Aux = string.Empty;
            string[] days = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            List<string> days_List = new List<string>();

            foreach (string m_day in days)
            {
                if(main_String.Contains(m_day) == true)
                {
                    days_List.Add(m_day);
                    main_String = main_String.Replace(m_day, string.Empty);                    
                }
            }
            this.TextBox_DiasL.Text = string.Empty;
            foreach(string str in days_List)
            {
                if (string.Compare(this.TextBox_DiasL.Text, string.Empty) == 0)
                    this.TextBox_DiasL.Text += str;
                else
                    this.TextBox_DiasL.Text += "-" + str;
            }
        }
       

        protected void CheckBox_Lunes_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.CheckBox_Lunes.Checked, "Lunes");
            this.sort_days();
        }

        protected void CheckBox_Martes_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.CheckBox_Martes.Checked, "Martes");
            this.sort_days();
        }

        protected void CheckBox_Miercoles_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.CheckBox_Miercoles.Checked, "Miercoles");
            this.sort_days();
        }

        protected void CheckBox_Jueves_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.CheckBox_Jueves.Checked, "Jueves");
            this.sort_days();
        }

        protected void CheckBox_Viernes_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.CheckBox_Viernes.Checked, "Viernes");
            this.sort_days();
        }

        protected void CheckBox_Sabado_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.CheckBox_Sabado.Checked, "Sabado");
            this.sort_days();
        }

        protected void CheckBox_Domingo_CheckedChanged(object sender, EventArgs e)
        {
            this.manage_Days(this.CheckBox_Domingo.Checked, "Domingo");
            this.sort_days();
        }

      
        protected void Button_Alta_Click(object sender, EventArgs e)
        {
            if (this.check_fields() == true)
            {
                char sexo = this.get_Sexo();
                string query =
                    "INSERT INTO PSICOLOGO (NOMBRE, PATERNO, MATERNO, DIRECCION,"
                    +
                    "COLONIA, TELEFONO, SEXO, LIMITEPACIENTES,FECHANACIMIENTO, DIASLABORALES VALUES ("
                    +
                    "'" + this.TextBox_Nombre.Text + "',"
                    +
                    "'" + this.TextBox_ApP.Text + "',"
                    +
                    "'" + this.TextBox_ApM.Text + "',"
                    +
                    "'" + this.TextBox_Dir.Text + "',"
                    +
                    "'" + this.TextBox_Colon.Text + "',"
                    +
                    this.TextBox_Tel.Text + ","
                    +
                    "'" + sexo + "',"
                    +
                    this.TextBox_LimitPac.Text + ","
                    +
                    "'" + this.TextBox_Fech_Nac.Text + "',"
                    +
                    "'" + this.TextBox_DiasL.Text + "')";

                this.connection.alter_data_CUSTOM_query(query);
                this.show_info();
                
            }
        }

        protected void Button_Eliminar_Click(object sender, EventArgs e)
        {

        }

        protected void Button_Modificacion_Click(object sender, EventArgs e)
        {

        }

        protected void Button_Pacientes_Click(object sender, EventArgs e)
        {
            int idPsicologo = -1;

            try
            {
                int index = GridView_Psico.SelectedIndex;
                idPsicologo = int.Parse(GridView_Psico.Rows[index].Cells[0].Text);
                if (idPsicologo > 0)
                    Response.Redirect("~/altaPacientePsicologo.aspx?idPsicologo=" + idPsicologo.ToString());
                else
                {
                    string script = "alert(\"Seleccione un psicologo.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }
            }
            catch
            {
                string script = "alert(\"Seleccione un psicologo.\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }

        protected void Button_Limpiar_Click(object sender, EventArgs e)
        {

        }

        protected void Button_Salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }

        protected void radioButt_Male_CheckedChanged1(object sender, EventArgs e)
        {
            this.radioButt_Male.Checked = true;
            if (radioButt_Female.Checked)
                this.radioButt_Female.Checked = false;
        }

        protected void radioButt_Female_CheckedChanged1(object sender, EventArgs e)
        {
            this.radioButt_Female.Checked = true;
            if (this.radioButt_Male.Checked)
                this.radioButt_Male.Checked = false;

        }
    }
}