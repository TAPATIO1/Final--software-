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
    public partial class Productos : Form
    {
        
        public Productos()
        {
            InitializeComponent();
        }

        Filtrar_datos objectCN = new Filtrar_datos();
        
       
        private void MostrarProductos()
        {

            dataGridView1.DataSource = objectCN.MostrarProductos();
        }
        



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal dis = new DiseñoPrincipal();
            dis.Visible = true;
            Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DetalleProductos deta = new DetalleProductos();
            deta.Visible = true;
            Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {

            MostrarProductos();
            
            

           
        }
        
        

        private void DetallBoton_Click(object sender, EventArgs e)
        {
            DetalleProductos pro = new DetalleProductos();
            pro.Visible = true;
            Visible = false;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

        }
        
        private void CrearcuentaUsuario_Click(object sender, EventArgs e)
        {
            
        }

        

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
}

