using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegateSqlError(string message);
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        public static event DelegateSqlError errorSql;

        /// <summary>
        /// constructor de la clase que inicializa la coneccion a la BBDD
        /// </summary>
        static PaqueteDAO()
        {
            string connectionStr = @"Data Source= .\SQLEXPRESS; Initial Catalog= correo-sp-2017; Integrated Security = True";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        /// <summary>
        /// insertar un paquete en la BBDD
        /// </summary>
        /// <param name="p">paquete a insertar en la BBDD</param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            bool validation = true;
            comando.CommandText = $"INSERT INTO dbo.Paquetes (direccionEntrega, trackingID, nombreAlumno)  VALUES('{p.DireccionEntrega}', '{p.TrackingID}', 'massimo di berardino')";
            try
            {
                conexion.Open();
                validation = comando.ExecuteNonQuery() != 0 ? true : false; ;
            }
            catch (Exception e)
            {
                errorSql.Invoke(e.Message);
                validation = false;
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return validation;
        }
    }
}
