namespace CapaPresentacion
{
    partial class SubirPromocion
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
            this.FechaFinal = new System.Windows.Forms.TextBox();
            this.FechaInicio = new System.Windows.Forms.TextBox();
            this.DescripcionDeLaPromocion = new System.Windows.Forms.TextBox();
            this.NombrePromocion = new System.Windows.Forms.TextBox();
            this.GuardarPromocion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NombreTienda = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaFinal
            // 
            this.FechaFinal.BackColor = System.Drawing.Color.White;
            this.FechaFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFinal.ForeColor = System.Drawing.Color.Black;
            this.FechaFinal.Location = new System.Drawing.Point(411, 342);
            this.FechaFinal.Multiline = true;
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(149, 26);
            this.FechaFinal.TabIndex = 165;
            this.FechaFinal.Text = "Fecha final";
            // 
            // FechaInicio
            // 
            this.FechaInicio.BackColor = System.Drawing.Color.White;
            this.FechaInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicio.ForeColor = System.Drawing.Color.Black;
            this.FechaInicio.Location = new System.Drawing.Point(166, 342);
            this.FechaInicio.Multiline = true;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(152, 26);
            this.FechaInicio.TabIndex = 164;
            this.FechaInicio.Text = "Fecha de inicio";
            // 
            // DescripcionDeLaPromocion
            // 
            this.DescripcionDeLaPromocion.BackColor = System.Drawing.Color.White;
            this.DescripcionDeLaPromocion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionDeLaPromocion.ForeColor = System.Drawing.Color.Black;
            this.DescripcionDeLaPromocion.Location = new System.Drawing.Point(166, 249);
            this.DescripcionDeLaPromocion.Multiline = true;
            this.DescripcionDeLaPromocion.Name = "DescripcionDeLaPromocion";
            this.DescripcionDeLaPromocion.Size = new System.Drawing.Size(520, 70);
            this.DescripcionDeLaPromocion.TabIndex = 163;
            this.DescripcionDeLaPromocion.Text = "Descripción de la Pomocion";
            // 
            // NombrePromocion
            // 
            this.NombrePromocion.BackColor = System.Drawing.Color.White;
            this.NombrePromocion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePromocion.ForeColor = System.Drawing.Color.Black;
            this.NombrePromocion.Location = new System.Drawing.Point(166, 153);
            this.NombrePromocion.Multiline = true;
            this.NombrePromocion.Name = "NombrePromocion";
            this.NombrePromocion.Size = new System.Drawing.Size(520, 28);
            this.NombrePromocion.TabIndex = 162;
            this.NombrePromocion.Text = "Nombre de la Promocion";
            // 
            // GuardarPromocion
            // 
            this.GuardarPromocion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardarPromocion.BackColor = System.Drawing.Color.Green;
            this.GuardarPromocion.FlatAppearance.BorderSize = 0;
            this.GuardarPromocion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.GuardarPromocion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarPromocion.ForeColor = System.Drawing.Color.White;
            this.GuardarPromocion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarPromocion.Location = new System.Drawing.Point(166, 394);
            this.GuardarPromocion.Name = "GuardarPromocion";
            this.GuardarPromocion.Size = new System.Drawing.Size(183, 24);
            this.GuardarPromocion.TabIndex = 169;
            this.GuardarPromocion.Text = "GUARDAR";
            this.GuardarPromocion.UseVisualStyleBackColor = false;
            this.GuardarPromocion.Click += new System.EventHandler(this.GuardarPromocion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 124);
            this.panel1.TabIndex = 170;
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
            this.label4.Location = new System.Drawing.Point(236, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subir una Promocion";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 35);
            this.panel2.TabIndex = 171;
            // 
            // NombreTienda
            // 
            this.NombreTienda.BackColor = System.Drawing.Color.White;
            this.NombreTienda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTienda.ForeColor = System.Drawing.Color.Black;
            this.NombreTienda.Location = new System.Drawing.Point(166, 203);
            this.NombreTienda.Multiline = true;
            this.NombreTienda.Name = "NombreTienda";
            this.NombreTienda.Size = new System.Drawing.Size(520, 28);
            this.NombreTienda.TabIndex = 172;
            this.NombreTienda.Text = "TIENDA";
            // 
            // SubirPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 535);
            this.Controls.Add(this.NombreTienda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GuardarPromocion);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.FechaInicio);
            this.Controls.Add(this.DescripcionDeLaPromocion);
            this.Controls.Add(this.NombrePromocion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubirPromocion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubirPromocion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FechaFinal;
        private System.Windows.Forms.TextBox FechaInicio;
        private System.Windows.Forms.TextBox DescripcionDeLaPromocion;
        private System.Windows.Forms.TextBox NombrePromocion;
        private System.Windows.Forms.Button GuardarPromocion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NombreTienda;
    }
}