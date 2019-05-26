using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace B2C.Models.dao
{
    public static class Conexion
    {
        private static SqlConnection conexion;

        public static SqlConnection ObtenerConexion()
        {
            conexion = new SqlConnection("data source=localhost;initial catalog=Productos;user id=sa;Password=abc.123;");
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DescargarConexion()
        {
            conexion.Dispose();
            return true;
        }
    }
}