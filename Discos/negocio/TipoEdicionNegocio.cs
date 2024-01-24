using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using ConexionDB;

namespace negocio
{
    public class TipoEdicionNegocio
    {
        public List<TipoEdicion> listaTiposEdicion()
        {
            AccesoDatos tabla_tipo_edicion = new AccesoDatos("DISCOS_DB");
            List<TipoEdicion> lista = new List<TipoEdicion>();
            try
            {
                tabla_tipo_edicion.consulta("SELECT Id, Descripcion FROM TIPOSEDICION");
                tabla_tipo_edicion.ejecutarLectura();
                while (tabla_tipo_edicion.Lector.Read())
                {
                    TipoEdicion nuevo = new TipoEdicion();
                    nuevo.Id = (int)tabla_tipo_edicion.Lector["Id"];
                    nuevo.Descripcion = (string)tabla_tipo_edicion.Lector["Descripcion"];
                    lista.Add(nuevo);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tabla_tipo_edicion.cerrarConexion();
            }
        }

        public int GetIdTipoEdicion(string Descripcion)
        {
            AccesoDatos t_tipoEdicion = new AccesoDatos("DISCOS_DB");
            int id = -1;
            try
            {
                t_tipoEdicion.consulta($"SELECT Id FROM TIPOSEDICION WHERE Descripcion = '{Descripcion}'");
                t_tipoEdicion.ejecutarLectura();
                if (t_tipoEdicion.Lector.Read())
                    id = (int)t_tipoEdicion.Lector["Id"];
                
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                t_tipoEdicion.cerrarConexion();
            }
        }
    }
}
