using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {

        #region Events
        public static event DelegadoException ExceptionDAO;
        #endregion


        #region Atributtes
        private static SqlCommand comando;
        private static SqlConnection conexion;
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor estático de la clase PaqueteDAO
        /// </summary>
        static PaqueteDAO()
        {
            try
            {
                conexion = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = correo-sp-2017; Integrated Security = True");
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;                
            }
            catch (Exception ex)
            {

                ExceptionDAO("Error en la conexión con la DB",ex);
            }
            
        }
        #endregion


        #region Methods
        /// <summary>
        /// Método que inserta el registro en la tabla
        /// </summary>
        /// <param name="p">Datos del paquete a insertar</param>
        /// <returns>True si se pudo, exception si no</returns>
        public static bool Insertar(Paquete p)
        {
            try
            {
                string query = "INSERT INTO dbo.Paquetes (direccionEntrega, trackingID, alumno) VALUES ('" + p.DireccionEntrega + "','" + p.TrackingID + "','GONZALEZ HUGO NAHUEL')";
                comando.CommandText = query;
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                ExceptionDAO("Error al insertar datos en la DB", ex);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion

    }
}
