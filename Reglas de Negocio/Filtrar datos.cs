using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Acceso_Datos.FiltrarDatos;
using Capa_Acceso_Datos;
using System.Windows.Forms;
using System.Net.Configuration;

namespace Reglas_de_Negocio
{
     public class Filtrar_datos

    {

        private CD_Productos ObjectCd = new CD_Productos();
        private CD_Promociones ObjectDT = new CD_Promociones();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = ObjectCd.Mostrar();
            return tabla;
        }
        public DataTable MostrarPromociones()
        {
            DataTable tablaDetalle = new DataTable();
            tablaDetalle = ObjectDT.Mostrar();
            return tablaDetalle;
        }
        

       
       


    }
}
