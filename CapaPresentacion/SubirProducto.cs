﻿using System;
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
    public partial class SubirProducto : Form
    {
        public SubirProducto()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal dis = new DiseñoPrincipal();
            dis.Visible = true;
            Visible = false;
        }

        private void GuardarUnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = Applogin; Integrated Security=True;");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT Registro_Productos (IdProducto,NombreProducto,Tienda,Marca,Descripcion,Precio,Presentacion,Caracteristicas) " +
               "VALUES ('"+ IdProducto.Text + "','" + NombreProducto.Text + "','" + TiendaProducto.Text + "','" + MarcaProducto.Text + "','" + DescripcionProducto.Text  + "','" + PrecioProductos.Text + "','" + PresentacionProductos.Text + "','" + CaracteristicasProducto.Text + "')";

                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Se ha creado un Nuevo Producto.");
                
            }
            catch
            {
                MessageBox.Show("Error al intentar ingresar los datos en la base de datos");
                
                

            }
        }

        private void SubirProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
