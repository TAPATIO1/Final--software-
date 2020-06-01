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

namespace CapaPresentacion
{
    public partial class DetalleProductos : Form
    {
        public DetalleProductos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Productos dis = new Productos();
            dis.Visible = true;
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetalleProductos_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
