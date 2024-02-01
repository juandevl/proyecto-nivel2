using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using ConexionDB;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> DiscosList()
        {
            List<Disco> discos = new List<Disco>();
            AccesoDatos tabla_discos = new AccesoDatos("DISCOS_DB");
            try
            {
                tabla_discos.consulta("SELECT D.Id, Activo, Titulo, CantidadCanciones, FechaLanzamiento, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato, D.IdEstilo idestilo, D.IdTipoEdicion idedicion FROM DISCOS D JOIN ESTILOS E ON D.IdEstilo = E.Id JOIN TIPOSEDICION T ON D.IdTipoEdicion = T.Id");
                tabla_discos.ejecutarLectura();

                while (tabla_discos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)tabla_discos.Lector["Id"];
                    aux.Activo = (bool)tabla_discos.Lector["Activo"];
                    //aux.Id = tabla_discos.Lector.GetInt32(0);
                    aux.Titulo = (string)tabla_discos.Lector["Titulo"];
                    //Para validar si la imagen celda de la tabla de la base de datos
                    // es null, debemos hacer de la siguiente manera
                    //##### FORMA 1
                    //if(!tabla_discos.Lector.IsDBNull(tabla_discos.Lector.GetOrdinal("UrlImagenTapa")))
                    //    aux.UrlImagenTapa = (string)tabla_discos.Lector["UrlImagenTapa"];

                    //##### FORMA 2
                    if (!(tabla_discos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)tabla_discos.Lector["UrlImagenTapa"];


                    aux.CantidadCanciones = (int)tabla_discos.Lector["CantidadCanciones"];
                    aux.Estilo.Id = (int)tabla_discos.Lector["idestilo"];
                    aux.Estilo.Descripcion = (string)tabla_discos.Lector["Genero"];

                    aux.TipoEdicion.Id = (int)tabla_discos.Lector["idedicion"];
                    aux.TipoEdicion.Descripcion = (string)tabla_discos.Lector["Formato"];
                    aux.FechaLanzamiento = (DateTime)tabla_discos.Lector["FechaLanzamiento"];

                    discos.Add(aux);
                }

                return discos;

            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                tabla_discos.cerrarConexion();
            }
        }

        public void insertarDisco(Disco disco)
        {
            AccesoDatos tabla_disco = new AccesoDatos("DISCOS_DB");

            //string query = $"INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) VALUES ('{disco.Titulo}','{fecha}',{disco.CantidadCanciones},'{disco.UrlImagenTapa}',{disco.Estilo.Id},{disco.TipoEdicion.Id})"; 

            string consultaParametros = "INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion, Activo) VALUES (@Titulo, @FechaLanzamiento, @CantidadCanciones, @UrlImagenTapa ,@IdEstilo ,@IdTipoEdicion, @Activo)";
            try
            {
                tabla_disco.consulta(consultaParametros);
                tabla_disco.setParametro("@Titulo", disco.Titulo);
                tabla_disco.setParametro("@FechaLanzamiento", disco.FechaLanzamiento);
                tabla_disco.setParametro("@CantidadCanciones", disco.CantidadCanciones);
                tabla_disco.setParametro("@UrlImagenTapa", disco.UrlImagenTapa);
                tabla_disco.setParametro("@IdEstilo", disco.Estilo.Id);
                tabla_disco.setParametro("@IdTipoEdicion", disco.TipoEdicion.Id);
                tabla_disco.setParametro("@Activo", disco.Activo);
                tabla_disco.ejecutarConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tabla_disco.cerrarConexion();
            }
            
        }

        public void eliminarDisco(Disco disco)
        {
            AccesoDatos tablaDiscos = new AccesoDatos("DISCOS_DB");
            string consulta = "DELETE FROM DISCOS WHERE Id = @id";
            try
            {
                tablaDiscos.consulta(consulta);
                tablaDiscos.setParametro("@id", disco.Id);
                tablaDiscos.ejecutarConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tablaDiscos.cerrarConexion();
            }
        }

        public void deshabilitarDisco(Disco disco)
        {
            AccesoDatos tablaDiscos = new AccesoDatos("DISCOS_DB");
            try
            {
            string consulta = "UPDATE DISCOS SET Activo = 0 WHERE Id = @Id";
                tablaDiscos.consulta(consulta);
                tablaDiscos.setParametro("@Id", disco.Id);
                tablaDiscos.ejecutarConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tablaDiscos.cerrarConexion();
            }
        }

        public void recuperarDiscos()
        {
            AccesoDatos tablaDiscos = new AccesoDatos("DISCOS_DB");
            try
            {
                string consulta = "UPDATE DISCOS SET Activo = 1 WHERE Activo = 0";
                tablaDiscos.consulta(consulta);
                tablaDiscos.ejecutarConsulta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tablaDiscos.cerrarConexion();
            }
        }

        public void modificarDisco(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos("DISCOS_DB");
            string consulta = "UPDATE DISCOS SET Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @canciones, UrlImagenTapa = @urlimagen, IdEstilo = @idEstilo, IdTipoEdicion = @idTipo WHERE Id = @id";
            try
            {
                datos.consulta(consulta);
                datos.setParametro("@id", disco.Id);
                datos.setParametro("@titulo", disco.Titulo);
                datos.setParametro("@fecha", disco.FechaLanzamiento);
                datos.setParametro("@canciones", disco.CantidadCanciones);
                datos.setParametro("@urlimagen", disco.UrlImagenTapa);
                datos.setParametro("@idEstilo", disco.Estilo.Id);
                datos.setParametro("@idTipo", disco.TipoEdicion.Id);
                datos.ejecutarConsulta();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            { 
                datos.cerrarConexion();
            }
        }

        public List<Disco> filtrarDiscoGenero(Estilo genero)
        {
            List<Disco> discos = new List<Disco>();
            AccesoDatos con = new AccesoDatos("DISCOS_DB");
            try
            {
                string consulta = "SELECT D.Id, Titulo, CantidadCanciones, FechaLanzamiento, UrlImagenTapa, E.Descripcion Genero, T.Descripcion Formato, D.IdEstilo idestilo, D.IdTipoEdicion idedicion FROM DISCOS D JOIN ESTILOS E ON D.IdEstilo = E.Id JOIN TIPOSEDICION T ON D.IdTipoEdicion = T.Id WHERE E.Descripcion = @genero";
                con.consulta(consulta);
                con.setParametro("@genero", genero.Descripcion);
                con.ejecutarLectura();

                while (con.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)con.Lector["Id"];
                    //aux.Id = tabla_discos.Lector.GetInt32(0);
                    aux.Titulo = (string)con.Lector["Titulo"];
                    //Para validar si la imagen celda de la tabla de la base de datos
                    // es null, debemos hacer de la siguiente manera
                    //##### FORMA 1
                    //if(!tabla_discos.Lector.IsDBNull(tabla_discos.Lector.GetOrdinal("UrlImagenTapa")))
                    //    aux.UrlImagenTapa = (string)tabla_discos.Lector["UrlImagenTapa"];

                    //##### FORMA 2
                    if (!(con.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)con.Lector["UrlImagenTapa"];


                    aux.CantidadCanciones = (int)con.Lector["CantidadCanciones"];
                    aux.Estilo.Id = (int)con.Lector["idestilo"];
                    aux.Estilo.Descripcion = (string)con.Lector["Genero"];

                    aux.TipoEdicion.Id = (int)con.Lector["idedicion"];
                    aux.TipoEdicion.Descripcion = (string)con.Lector["Formato"];
                    aux.FechaLanzamiento = (DateTime)con.Lector["FechaLanzamiento"];

                    discos.Add(aux);

                }

                return discos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.cerrarConexion();
            }
        }


    }
}
