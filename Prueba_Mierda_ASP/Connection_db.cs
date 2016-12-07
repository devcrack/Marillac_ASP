using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
namespace Prueba_Mierda_ASP
{
    /// <summary>
    /// Clase implementada por devcrack
    /// email: jaha.devcrack@gmail.com
    /// Descripcion: Esta clase trata de manipular y controlar todo acerca de la conexion con la base de datos en Oracle.
    /// </summary>
    public class Connection_db
    {
        private OracleConnection oracle_connect;
        private OracleCommand oracle_cmd;
        private OracleDataAdapter oracle_adapt;
        Page pg;

        public Connection_db()
        {
            this.oracle_connect = new OracleConnection();
            this.oracle_connect.ConnectionString = "Data Source = xe; User Id = MARILLAC_DEF; Password = oracle";
        }

        /// <summary>
        /// Obtiene el Conjunto de Datos de una consulta Select * from .... .|. 
        /// </summary>
        /// <param name="from_tabla">Nombre de la tabla de la que se quiere obtener los datos</param>
        /// <returns></returns>
        public DataSet query_get_data(String from_tabla)
        {
            DataSet dt_set = new DataSet();

            this.oracle_adapt = new OracleDataAdapter("SELECT * FROM " + from_tabla, this.oracle_connect);
            this.open_connect();
            this.oracle_adapt.Fill(dt_set);
            this.close_connect();
            return dt_set;
        }

        /// <summary>
        /// Obtiene solo el conjunto de datos especvificado de una tabla mediante una consulta select from  consulta 
        /// </summary>
        /// <param name="which_values">Que valores desea de la tabla</param>
        /// <param name="from_tabla">de que tabla se va a obtener los datos</param>
        /// <returns></returns>
        public DataSet query_get_data_CUSTOM(string which_values, string from_tabla)
        {
            DataSet dt_set = new DataSet();

            this.oracle_adapt = new OracleDataAdapter("SELECT " + which_values +  " FROM " + from_tabla, this.oracle_connect);
            this.open_connect();
            this.oracle_adapt.Fill(dt_set);
            this.close_connect();
            return dt_set;            
        }


        /// <summary>
        /// Obtiene el conjunto de datos mediante una consulta SELECT totalmente personalizada
        /// </summary>
        /// <param name="custom_query_select">Consulta SELECT totalmente personalizada</param>
        /// <returns></returns>
        public DataSet query_get_data_SUPER_Custom(string custom_query_select)
        {
            DataSet dt_set = new DataSet();

            this.oracle_adapt = new OracleDataAdapter(custom_query_select, this.oracle_connect);
            this.open_connect();
            this.oracle_adapt.Fill(dt_set);
            this.close_connect();
            return dt_set;

        }
 
        /// <summary>
        /// Permite utilizar consultas para insertar, modificar y borrar Datos.
        /// </summary>
        /// <param name="query">Cadena que contiene la consulta SQL</param>
        public void alter_data_CUSTOM_query(string query)
        {
            this.open_connect();
            this.oracle_cmd = new OracleCommand(query, this.oracle_connect);
            this.oracle_cmd.ExecuteNonQuery();
            this.close_connect();
        }

        public void open_connect(){ this.oracle_connect.Open(); }
        public void close_connect() { this.oracle_connect.Close(); }
    }

}