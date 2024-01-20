using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConexionDB
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public AccesoDatos(string database)
        {
            this.conexion = new SqlConnection($"server=.\\SQLEXPRESS; database={database}; integrated security=true;");
            this.comando = new SqlCommand();
        }
        public SqlDataReader Lector
        {
            get { return this.lector; }
        }

        //Procedimiento para solicitar la consulta a la db
        public void query(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void insertarConsulta()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Procedimiento para ejecutar la lectura de los datos 
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Procedimiento para cerrar la conexion
        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            
            conexion.Close();

        }

    }
}
