using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reglas_de_Negocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class DATAGRIDVIEW : Form
    {
        public DATAGRIDVIEW()
        {
            InitializeComponent();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal dis = new DiseñoPrincipal();
            dis.Visible = true;
            Visible = false;
        }

        private void Promociones_Load(object sender, EventArgs e)
        {
            MostrarPromociones();
        }

        Filtrar_datos objectCP = new Filtrar_datos();
        private void MostrarPromociones()
        {
            dataGridView1.DataSource = objectCP.MostrarPromociones();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal dis = new DiseñoPrincipal();
            dis.Visible = true;
            Visible = false;
        }
    }
}
