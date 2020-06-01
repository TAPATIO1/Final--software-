using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_De_Soporte;
using Capa_De_Soporte.Cache;
using Reglas_de_Negocio;

namespace CapaPresentacion
{
    public partial class DiseñoPrincipal : Form
    {
        public DiseñoPrincipal()
        {
            InitializeComponent();
            //PrivilegioUsuario();
            LoadUserData();

            // Administrar permisos 
            if(UserLoginCache.Tipo == Tipos.Cliente)
            {
                btnSubirpRODUCTO.Enabled = false;
                btnSubirPROMOCION.Enabled = false;
            }
            if(UserLoginCache.Tipo == Tipos.Tienda)
            {
                btnRegistroNovedad.Enabled = false;
            }
            
        }

       /* private void PrivilegioUsuario()
        {
            //Deshabilitar botones
           

           if (Program.Tipo != "Tienda")
            {
                btnSubirpRODUCTO.Enabled = false;
                btnSubirPROMOCION.Enabled = false;
            }

           /*if (Program.Tipo != "Tienda")
            {
                btnSubirpRODUCTO.Visible = false;
                btnSubirPROMOCION.Visible = false;
            }*/
           
            /*if (Program.Tipo == "Tienda")
            {
                btnSubirpRODUCTO.Visible = true;
                btnSubirPROMOCION.Visible = true;
            }


        }*/

       private void LoadUserData()
        {
            NombreInfo.Text = UserLoginCache.FirstName + " " + UserLoginCache.LastName;
            TipoInfo.Text = UserLoginCache.Tipo;
            CorreoInfo.Text = UserLoginCache.Email;
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }


       


        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconomaximizar.Visible = false;
            iconorestaurar.Visible = true;
        }

        private void iconorestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconomaximizar.Visible = true;
            iconorestaurar.Visible = false;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconomaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconorestaurar.Visible = true;
            iconomaximizar.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void panelRegistrar_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void RegistrarUsuarios_Click(object sender, EventArgs e)
        {

            

            


        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Visible = true;
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            DiseñoPrincipal dis = new DiseñoPrincipal();
            dis.Visible = true;
            Visible = false;
        }
        
        private void PanleControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Promociones_Click(object sender, EventArgs e)
        {
            DATAGRIDVIEW pro = new DATAGRIDVIEW();
            pro.Visible = true;
            Visible = false;

        }

        private void CrearcuentaUsuario_Click(object sender, EventArgs e)
        {
            Productos pro = new Productos();
            pro.Visible = true;
            Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Productos pro = new Productos();
            pro.Visible = true;
            Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Visible = true;
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

        private void button17_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Registro_de_Novedades regisNovedades = new Registro_de_Novedades();
            regisNovedades.Visible = true;
            Visible = false;

        }

        private void btnSubirpRODUCTO_Click(object sender, EventArgs e)
        {
            SubirProducto subir = new SubirProducto();
            subir.Visible = true;
            Visible = false;
        }

        private void btnSubirPROMOCION_Click(object sender, EventArgs e)
        {
            SubirPromocion pro = new SubirPromocion();
            pro.Visible = true;
            Visible = false;
        }

        private void btnSobreNosotros_Click(object sender, EventArgs e)
        {
            SobreNosotros sob = new SobreNosotros();
            sob.Visible = true;
            Visible = false;
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DiseñoPrincipal_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        Filtrar_datos objectCN = new Filtrar_datos();


        private void MostrarProductos()
        {

            dataGridView1.DataSource = objectCN.MostrarProductos();
        }

        private void NombreInfo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
