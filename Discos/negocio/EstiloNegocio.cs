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
                tabla_estilos.query("SELECT Id, Descripcion FROM ESTILOS");
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
    }
}
