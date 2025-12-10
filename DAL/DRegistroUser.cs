using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class DRegistroUser
    {
        
        private string linkconexion = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;

        public DataTable OptenerDatos()
        {
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {
                SqlDataAdapter tabla= new SqlDataAdapter("SELECT * FROM MiTabla", conexion);
                DataTable dt = new DataTable();
                tabla.Fill(dt);
                return dt;
            }

        }
        //public bool GuardarDatos(Entidade.ERegistroUser item)
        //{
        //    using (SqlConnection conexion = new SqlConnection(linkconexion))
        //    {
        //        SqlCommand comando = new SqlCommand("INSERT INTO MiTabla (Nombre, Edad) VALUES (@Nombre, @Edad)", conexion);
        //        comando.Parameters.AddWithValue("@Nombre", nombre);
        //        comando.Parameters.AddWithValue("@Edad", edad);
        //        conexion.Open();
        //        int resultado = comando.ExecuteNonQuery();
        //        return resultado > 0;
        //    }
        //}
        public bool validarLoguin(Entidade.ERegistroUser item)
        {
            using (SqlConnection conexion = new SqlConnection(linkconexion))
            {
                SqlCommand cmd = new SqlCommand(" SELECT COUNT(*) FROM RegistroUser WHERE Email = @Email AND Contrasena = @Contrasena", conexion);
               cmd.Parameters.AddWithValue("@Email", item.Email);
                cmd.Parameters.AddWithValue("@Contrasena", item.Contraseña);

                conexion.Open();
                int resultado = cmd.ExecuteNonQuery();
                return resultado > 0;
            }
        }
    }
}
