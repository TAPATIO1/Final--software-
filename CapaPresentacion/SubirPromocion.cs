using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class SubirPromocion : Form
    {
        public SubirPromocion()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal dis = new DiseñoPrincipal();
            dis.Visible = true;
            Visible = false;
        }

        private void GuardarPromocion_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = Applogin; Integrated Security=True;");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT Registro_Promociones (NombrePromocion,DescripcionPromocion,FechaInicio,FechaFinal,FK_NombreTienda) VALUES ('" + NombrePromocion.Text + "','" + DescripcionDeLaPromocion.Text + "','" + FechaInicio.Text + "','" + FechaFinal.Text + "','" + NombreTienda.Text + "')";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Se ha creado una nueva Promocion.");
                
            }
            catch
            {
                MessageBox.Show("Error al intentar ingresar los datos en la base de datos");
                
                
            }
        }
    }
}
