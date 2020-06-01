﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Acceso_Datos.FiltrarDatos
{
    public class CD_Productos

    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        
        DataTable tabla = new DataTable();
        
        SqlCommand comando = new SqlCommand();
       
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Mostrar_Productos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        


    }
}
