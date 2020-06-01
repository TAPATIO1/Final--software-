namespace CapaPresentacion
{
    partial class SubirProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrecioProductos = new System.Windows.Forms.TextBox();
            this.DescripcionProducto = new System.Windows.Forms.TextBox();
            this.NombreProducto = new System.Windows.Forms.TextBox();
            this.GuardarUnProducto = new System.Windows.Forms.Button();
            this.PresentacionProductos = new System.Windows.Forms.TextBox();
            this.MarcaProducto = new System.Windows.Forms.TextBox();
            this.TiendaProducto = new System.Windows.Forms.TextBox();
            this.CaracteristicasProducto = new System.Windows.Forms.TextBox();
            this.IdProducto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 124);
            this.panel1.TabIndex = 153;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.BOTON_VOLVER_MENU1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 149;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(229, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "SUBIR UN PRODUCTO ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 47);
            this.panel2.TabIndex = 150;
            // 
            // PrecioProductos
            // 
            this.PrecioProductos.BackColor = System.Drawing.Color.White;
            this.PrecioProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioProductos.ForeColor = System.Drawing.Color.Black;
            this.PrecioProductos.Location = new System.Drawing.Point(466, 414);
            this.PrecioProductos.Multiline = true;
            this.PrecioProductos.Name = "PrecioProductos";
            this.PrecioProductos.Size = new System.Drawing.Size(123, 26);
            this.PrecioProductos.TabIndex = 157;
            this.PrecioProductos.Text = "Precio";
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.BackColor = System.Drawing.Color.White;
            this.DescripcionProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProducto.ForeColor = System.Drawing.Color.Black;
            this.DescripcionProducto.Location = new System.Drawing.Point(174, 319);
            this.DescripcionProducto.Multiline = true;
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.Size = new System.Drawing.Size(520, 76);
            this.DescripcionProducto.TabIndex = 156;
            this.DescripcionProducto.Text = "Descripción del Producto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.BackColor = System.Drawing.Color.White;
            this.NombreProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto.ForeColor = System.Drawing.Color.Black;
            this.NombreProducto.Location = new System.Drawing.Point(174, 199);
            this.NombreProducto.Multiline = true;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(195, 28);
            this.NombreProducto.TabIndex = 155;
            this.NombreProducto.Text = "Nombre del Producto";
            // 
            // GuardarUnProducto
            // 
            this.GuardarUnProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardarUnProducto.BackColor = System.Drawing.Color.Green;
            this.GuardarUnProducto.FlatAppearance.BorderSize = 0;
            this.GuardarUnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.GuardarUnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarUnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarUnProducto.ForeColor = System.Drawing.Color.White;
            this.GuardarUnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarUnProducto.Location = new System.Drawing.Point(174, 518);
            this.GuardarUnProducto.Name = "GuardarUnProducto";
            this.GuardarUnProducto.Size = new System.Drawing.Size(183, 24);
            this.GuardarUnProducto.TabIndex = 160;
            this.GuardarUnProducto.Text = "GUARDAR";
            this.GuardarUnProducto.UseVisualStyleBackColor = false;
            this.GuardarUnProducto.Click += new System.EventHandler(this.GuardarUnProducto_Click);
            // 
            // PresentacionProductos
            // 
            this.PresentacionProductos.BackColor = System.Drawing.Color.White;
            this.PresentacionProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentacionProductos.ForeColor = System.Drawing.Color.Black;
            this.PresentacionProductos.Location = new System.Drawing.Point(466, 460);
            this.PresentacionProductos.Multiline = true;
            this.PresentacionProductos.Name = "PresentacionProductos";
            this.PresentacionProductos.Size = new System.Drawing.Size(123, 26);
            this.PresentacionProductos.TabIndex = 161;
            this.PresentacionProductos.Text = "Presentacion";
            // 
            // MarcaProducto
            // 
            this.MarcaProducto.BackColor = System.Drawing.Color.White;
            this.MarcaProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaProducto.ForeColor = System.Drawing.Color.Black;
            this.MarcaProducto.Location = new System.Drawing.Point(174, 267);
            this.MarcaProducto.Multiline = true;
            this.MarcaProducto.Name = "MarcaProducto";
            this.MarcaProducto.Size = new System.Drawing.Size(195, 28);
            this.MarcaProducto.TabIndex = 162;
            this.MarcaProducto.Text = "Marca";
            // 
            // TiendaProducto
            // 
            this.TiendaProducto.BackColor = System.Drawing.Color.White;
            this.TiendaProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiendaProducto.ForeColor = System.Drawing.Color.Black;
            this.TiendaProducto.Location = new System.Drawing.Point(174, 233);
            this.TiendaProducto.Multiline = true;
            this.TiendaProducto.Name = "TiendaProducto";
            this.TiendaProducto.Size = new System.Drawing.Size(195, 28);
            this.TiendaProducto.TabIndex = 163;
            this.TiendaProducto.Text = "Tienda";
            // 
            // CaracteristicasProducto
            // 
            this.CaracteristicasProducto.BackColor = System.Drawing.Color.White;
            this.CaracteristicasProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaracteristicasProducto.ForeColor = System.Drawing.Color.Black;
            this.CaracteristicasProducto.Location = new System.Drawing.Point(174, 401);
            this.CaracteristicasProducto.Multiline = true;
            this.CaracteristicasProducto.Name = "CaracteristicasProducto";
            this.CaracteristicasProducto.Size = new System.Drawing.Size(274, 103);
            this.CaracteristicasProducto.TabIndex = 164;
            this.CaracteristicasProducto.Text = "Caracteristicas";
            // 
            // IdProducto
            // 
            this.IdProducto.BackColor = System.Drawing.Color.White;
            this.IdProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProducto.ForeColor = System.Drawing.Color.Black;
            this.IdProducto.Location = new System.Drawing.Point(174, 165);
            this.IdProducto.Multiline = true;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Size = new System.Drawing.Size(195, 28);
            this.IdProducto.TabIndex = 165;
            this.IdProducto.Text = "IdProducto";
            // 
            // SubirProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 574);
            this.Controls.Add(this.IdProducto);
            this.Controls.Add(this.CaracteristicasProducto);
            this.Controls.Add(this.TiendaProducto);
            this.Controls.Add(this.MarcaProducto);
            this.Controls.Add(this.PresentacionProductos);
            this.Controls.Add(this.GuardarUnProducto);
            this.Controls.Add(this.PrecioProductos);
            this.Controls.Add(this.DescripcionProducto);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubirProducto";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubirProducto";
            this.Load += new System.EventHandler(this.SubirProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PrecioProductos;
        private System.Windows.Forms.TextBox DescripcionProducto;
        private System.Windows.Forms.TextBox NombreProducto;
        private System.Windows.Forms.Button GuardarUnProducto;
        private System.Windows.Forms.TextBox PresentacionProductos;
        private System.Windows.Forms.TextBox MarcaProducto;
        private System.Windows.Forms.TextBox TiendaProducto;
        private System.Windows.Forms.TextBox CaracteristicasProducto;
        private System.Windows.Forms.TextBox IdProducto;
    }
}