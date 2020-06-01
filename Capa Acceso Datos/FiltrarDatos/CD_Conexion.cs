using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Acceso_Datos.FiltrarDatos
{
   public class CD_Conexion
    {
        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-M0V5OC5\\SQLEXPRESS;DataBase=Applogin;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;

        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

        

        


    }
}
