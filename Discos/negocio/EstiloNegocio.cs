using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using ConexionDB;

namespace negocio
{
    public class EstiloNegocio
    {
        public List<Estilo> listaEstilos()
        {
            List<Estilo> estilos = new List<Estilo>();
            AccesoDatos tabla_estilos = new AccesoDatos("DISCOS_DB");

            try
            {
                tabla_estilos.consulta("SELECT Id, Descripcion FROM ESTILOS");
                tabla_estilos.ejecutarLectura();
                while (tabla_estilos.Lector.Read())
                {
                    Estilo nuevo = new Estilo();
                    nuevo.Id = (int)tabla_estilos.Lector["Id"];
                    nuevo.Descripcion = (string)tabla_estilos.Lector["Descripcion"];

                    estilos.Add(nuevo);
                }

                return estilos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tabla_estilos.cerrarConexion();
            }
        }

        public int GetIdEstilo(string Descripcion)
        {
            AccesoDatos tabla_estilos = new AccesoDatos("DISCOS_DB");
            int id = -1;
            try
            {
                tabla_estilos.consulta($"SELECT Id FROM ESTILOS WHERE Descripcion = '{Descripcion}'");
                tabla_estilos.ejecutarLectura();
                if (tabla_estilos.Lector.Read())
                    id = (int)tabla_estilos.Lector["Id"];

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tabla_estilos.cerrarConexion();
            }
        }
    }
}
