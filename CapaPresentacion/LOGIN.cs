using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using Reglas_de_Negocio;
using Capa_De_Soporte.Cache;



namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO") {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text,txtPass.Text);
                    if(validLogin == true)
                    {
                        DiseñoPrincipal mainMenu = new DiseñoPrincipal();
                        MessageBox.Show("Su Ingreso fue exitoso, Bienvenido" + " " + UserLoginCache.FirstName + " " + UserLoginCache.LastName);
                        mainMenu.Show();
                        this.Hide();

                    }
                    else
                    {
                        msgError(" Usuario o Contraseña Incorrectos. ");
                        txtPass.Clear();
                        txtUser.Focus();

                    }
                }
                else msgError("Por favor Ingresar Contraseña.");
            }
            else msgError(" Porfavor Ingresar Nombre de Usuario.");
            
        }
        private void msgError(string msg)
        {
            lblErrorLogin.Text ="" + msg;
            lblErrorLogin.Visible = true;

        }




        private void RegistrarUsuarios_Click(object sender, EventArgs e)
        {
            if (panelRegistrar.Visible == true)
            {
                panelRegistrar.Visible = false;
            }
            else
            {
                panelRegistrar.Visible = true;
            }


            RegistrarUsuarios.Location = new Point(0, 84);
            panelRegistrar.Location = new Point(34, 135);

            


            if (panelRegistrar.Visible == false)
            {
                RegistrarUsuarios.Location = new Point(0, 84);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
            RegistrarUsuarios.Location = new Point(-3, 84);
            panelRegistrar.Location = new Point(34, 135);
            
            panelRegistrar.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiseñoPrincipal Diseño = new DiseñoPrincipal();
            Diseño.Visible = true;
            Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioCliente registcliente = new RegistrarUsuarioCliente();
            registcliente.Visible = true;
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioTienda USUARIOTIENDA = new RegistrarUsuarioTienda();
            USUARIOTIENDA.Visible = true;
            Visible = false;
        }

        private void lblErrorUsuario_Click(object sender, EventArgs e)
        {

        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverpassword = new RecuperarContraseña();
            recoverpassword.ShowDialog();
        }

        private void lblErrorLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
