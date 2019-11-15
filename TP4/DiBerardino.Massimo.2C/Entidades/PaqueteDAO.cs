using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PaqueteDAO()
        {
            string connectionStr = @"Data Source= .\SQLEXPRESS; Initial Catalog= correo-sp-2017; Integrated Security = True";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static bool Insertar(Paquete p)
        {
            bool validation = true;
            comando.CommandText = $"INSERT INTO dbo.Paquetes (direccionEntrega, trackingID, nombreAlumno)  VALUES('{p.DireccionEntrega}', '{p.TrakingID}', 'massimo di berardino')";
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                validation = false;
                throw e;
            }

            return validation;
        }
    }
}
