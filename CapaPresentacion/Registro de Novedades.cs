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
    public partial class Registro_de_Novedades : Form
    {
        public Registro_de_Novedades()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal dis = new DiseñoPrincipal();
            dis.Visible = true;
            Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = Applogin; Integrated Security=True;");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT Registro_Novedades (NombreNovedad,DescripcionNovedad,FK_NombreTienda) VALUES ('" + TxtNovedad.Text + "','" + txtNovedadDescripcion.Text + "','" + TxtNovedadTienda.Text +  "')";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Se ha creado una nueva Novedad.");

            }
            catch
            {
                MessageBox.Show("Error al intentar ingresar los datos en la base de datos");



            }
        }

        private void Registro_de_Novedades_Load(object sender, EventArgs e)
        {

        }
    }
}
