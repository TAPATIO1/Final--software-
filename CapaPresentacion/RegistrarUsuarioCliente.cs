using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class RegistrarUsuarioCliente : Form
    {
        public RegistrarUsuarioCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal dis = new DiseñoPrincipal();
            dis.Visible = true;
            Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtNomreCliente.Text == "NOMBRE")
            {
                txtNomreCliente.Text = "";
                txtNomreCliente.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtNomreCliente.Text == "")
            {
                txtNomreCliente.Text = "NOMBRE";
                txtNomreCliente.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtContraseñaCliente.Text == "CONTRASEÑA")
            {
                txtContraseñaCliente.Text = "";
                txtContraseñaCliente.ForeColor = Color.White;
                txtContraseñaCliente.UseSystemPasswordChar = true;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellidoCliente.Text == "APELLIDO")
            {
                txtApellidoCliente.Text = "";
                txtApellidoCliente.ForeColor = Color.White;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellidoCliente.Text == "")
            {
                txtApellidoCliente.Text = "APELLIDO";
                txtApellidoCliente.ForeColor = Color.White;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioCliente.Text == "CORREO ELECTRONICO")
            {
                txtUsuarioCliente.Text = "";
                txtUsuarioCliente.ForeColor = Color.White;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioCliente.Text == "")
            {
                txtUsuarioCliente.Text = "CORREO ELECTRONICO";
                txtUsuarioCliente.ForeColor = Color.White;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseñaCliente.Text == "")
            {
                txtContraseñaCliente.Text = "CONTRASEÑA";
                txtContraseñaCliente.ForeColor = Color.White;
                txtContraseñaCliente.UseSystemPasswordChar = false;
            }
        }

        private void txtNomre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtCorreoCliente.Text == "Dni")
            {
                txtCorreoCliente.Text = "";
                txtCorreoCliente.ForeColor = Color.White;
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtCorreoCliente.Text == "")
            {
                txtCorreoCliente.Text = "Dni";
                txtCorreoCliente.ForeColor = Color.White;
                txtCorreoCliente.UseSystemPasswordChar = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = Applogin; Integrated Security=True;");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT Usuarios (LoginName,password,FirstName,LastName,Tipo,Email) VALUES ('" + txtUsuarioCliente.Text+ "','" + txtContraseñaCliente.Text + "','" + txtNomreCliente.Text + "','" + txtApellidoCliente.Text + "','" + txtTipoCliente.Text + "','" + txtCorreoCliente.Text + "')";
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
    }
}
