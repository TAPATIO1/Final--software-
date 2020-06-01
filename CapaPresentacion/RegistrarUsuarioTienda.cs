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
    public partial class RegistrarUsuarioTienda : Form
    {
        public RegistrarUsuarioTienda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login LOG = new Login();
            LOG.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal DIS = new DiseñoPrincipal();
            DIS.Visible = true;
            Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtusuarioTienda.Text == "NOMBRE")
            {
                txtusuarioTienda.Text = "";
                txtusuarioTienda.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtusuarioTienda.Text == "")
            {
                txtusuarioTienda.Text = "NOMBRE";
                txtusuarioTienda.ForeColor = Color.White;
            }
        }

        private void txtApellidoo_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaTienda.Text == "APELLIDO")
            {
                txtContraseñaTienda.Text = "";
                txtContraseñaTienda.ForeColor = Color.White;
            }
        }

        private void txtApellidoo_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaTienda.Text == "")
            {
                txtContraseñaTienda.Text = "APELLIDO";
                txtContraseñaTienda.ForeColor = Color.White;
            }
        }

        private void txtCorreoo_Enter(object sender, EventArgs e)
        {
            if (txtCorreoTienda.Text == "CORREO ELECTRONICO")
            {
                txtCorreoTienda.Text = "";
                txtCorreoTienda.ForeColor = Color.White;
            }
        }

        private void txtCorreoo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreoo_Leave(object sender, EventArgs e)
        {
            if (txtCorreoTienda.Text == "")
            {
                txtCorreoTienda.Text = "CORREO ELECTRONICO";
                txtCorreoTienda.ForeColor = Color.White;
            }
        }
                     
              
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtTIENDA_Enter(object sender, EventArgs e)
        {
            if (txtNombreTienda.Text == "NOMBRE TIENDA")
            {
                txtNombreTienda.Text = "";
                txtNombreTienda.ForeColor = Color.White;
            }
        }

        private void txtTIENDA_Leave(object sender, EventArgs e)
        {
            if (txtNombreTienda.Text == "")
            {
                txtNombreTienda.Text = "NOMBRE TIENDA";
                txtNombreTienda.ForeColor = Color.White;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtApellidoTienda.Text == "TELEFONO")
            {
                txtApellidoTienda.Text = "";
                txtApellidoTienda.ForeColor = Color.White;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtApellidoTienda.Text == "")
            {
                txtApellidoTienda.Text = "TELEFONO";
                txtApellidoTienda.ForeColor = Color.White;
            }
        }

        private void txtContraseñaa_Enter(object sender, EventArgs e)
        {
            if (txtTipoTienda.Text == "CONTRASEÑA")
            {
                txtTipoTienda.Text = "";
                txtTipoTienda.ForeColor = Color.White;
                txtTipoTienda.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseñaa_Leave(object sender, EventArgs e)
        {
            if (txtTipoTienda.Text == "")
            {
                txtTipoTienda.Text = "CONTRASEÑA";
                txtTipoTienda.ForeColor = Color.White;
                txtTipoTienda.UseSystemPasswordChar = false;
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = Applogin; Integrated Security=True;");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT Usuarios (LoginName,password,FirstName,LastName,Tipo,Email) VALUES ('" + txtusuarioTienda.Text + "','" + txtContraseñaTienda.Text + "','" + txtNombreTienda.Text + "','" + txtApellidoTienda.Text + "','" + txtTipoTienda.Text + "','" + txtCorreoTienda.Text + "')";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Se ha creado un usuario exitosamente.");
                
            }
            catch
            {
                MessageBox.Show("Error al intentar ingresar los datos en la base de datos");
                
            }

        }

        private void txtTitularTienda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
