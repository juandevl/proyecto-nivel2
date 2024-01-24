namespace cargar_disco_form
{
    partial class frmCargarDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblUrlImagenDisco = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbUrlImagenDisco = new System.Windows.Forms.TextBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.numCantidadCanciones = new System.Windows.Forms.NumericUpDown();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAltaDisco = new System.Windows.Forms.Label();
            this.pbPrevImagen = new System.Windows.Forms.PictureBox();
            this.lblPrevImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(71, 109);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(71, 173);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(145, 19);
            this.lblFechaLanzamiento.TabIndex = 1;
            this.lblFechaLanzamiento.Text = "Fecha de lanzamiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(72, 433);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(57, 19);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Genero:";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Location = new System.Drawing.Point(71, 301);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(151, 19);
            this.lblCantCanciones.TabIndex = 3;
            this.lblCantCanciones.Text = "Cantidad de canciones:";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(71, 365);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(68, 19);
            this.lblFormato.TabIndex = 4;
            this.lblFormato.Text = "Formato: ";
            // 
            // lblUrlImagenDisco
            // 
            this.lblUrlImagenDisco.AutoSize = true;
            this.lblUrlImagenDisco.Location = new System.Drawing.Point(71, 240);
            this.lblUrlImagenDisco.Name = "lblUrlImagenDisco";
            this.lblUrlImagenDisco.Size = new System.Drawing.Size(119, 19);
            this.lblUrlImagenDisco.TabIndex = 5;
            this.lblUrlImagenDisco.Text = "Url imagen disco: ";
            // 
            // tbTitulo
            // 
            this.tbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitulo.Location = new System.Drawing.Point(74, 131);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTitulo.MaxLength = 100;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(244, 24);
            this.tbTitulo.TabIndex = 0;
            // 
            // tbUrlImagenDisco
            // 
            this.tbUrlImagenDisco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUrlImagenDisco.Location = new System.Drawing.Point(74, 264);
            this.tbUrlImagenDisco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUrlImagenDisco.MaxLength = 200;
            this.tbUrlImagenDisco.Name = "tbUrlImagenDisco";
            this.tbUrlImagenDisco.Size = new System.Drawing.Size(244, 24);
            this.tbUrlImagenDisco.TabIndex = 2;
            this.tbUrlImagenDisco.Leave += new System.EventHandler(this.tbUrlImagenDisco_Leave);
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(74, 197);
            this.dtpFechaLanzamiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(244, 24);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(75, 457);
            this.cbGenero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(244, 27);
            this.cbGenero.TabIndex = 5;
            // 
            // cbFormato
            // 
            this.cbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormato.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(74, 388);
            this.cbFormato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(244, 27);
            this.cbFormato.TabIndex = 4;
            // 
            // numCantidadCanciones
            // 
            this.numCantidadCanciones.Location = new System.Drawing.Point(74, 325);
            this.numCantidadCanciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCantidadCanciones.Name = "numCantidadCanciones";
            this.numCantidadCanciones.Size = new System.Drawing.Size(120, 24);
            this.numCantidadCanciones.TabIndex = 3;
            // 
            // btnCargar
            // 
            this.btnCargar.AutoSize = true;
            this.btnCargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargar.Location = new System.Drawing.Point(96, 500);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(10);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btnCargar.Size = new System.Drawing.Size(80, 41);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Location = new System.Drawing.Point(196, 501);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.btnCancelar.Size = new System.Drawing.Size(92, 41);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAltaDisco
            // 
            this.lblAltaDisco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAltaDisco.AutoSize = true;
            this.lblAltaDisco.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaDisco.Location = new System.Drawing.Point(230, 27);
            this.lblAltaDisco.Name = "lblAltaDisco";
            this.lblAltaDisco.Size = new System.Drawing.Size(304, 36);
            this.lblAltaDisco.TabIndex = 14;
            this.lblAltaDisco.Text = "Carga de nuevo disco";
            // 
            // pbPrevImagen
            // 
            this.pbPrevImagen.Location = new System.Drawing.Point(404, 181);
            this.pbPrevImagen.Name = "pbPrevImagen";
            this.pbPrevImagen.Size = new System.Drawing.Size(317, 303);
            this.pbPrevImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrevImagen.TabIndex = 15;
            this.pbPrevImagen.TabStop = false;
            // 
            // lblPrevImagen
            // 
            this.lblPrevImagen.AutoSize = true;
            this.lblPrevImagen.Location = new System.Drawing.Point(400, 154);
            this.lblPrevImagen.Name = "lblPrevImagen";
            this.lblPrevImagen.Size = new System.Drawing.Size(173, 19);
            this.lblPrevImagen.TabIndex = 16;
            this.lblPrevImagen.Text = "Previsualizacion de imagen";
            // 
            // frmCargarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(793, 667);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.lblPrevImagen);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.pbPrevImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAltaDisco);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.tbUrlImagenDisco);
            this.Controls.Add(this.numCantidadCanciones);
            this.Controls.Add(this.cbFormato);
            this.Controls.Add(this.lblUrlImagenDisco);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCargarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta disco";
            this.Load += new System.EventHandler(this.frmCargarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.Label lblUrlImagenDisco;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbUrlImagenDisco;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.NumericUpDown numCantidadCanciones;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAltaDisco;
        private System.Windows.Forms.PictureBox pbPrevImagen;
        private System.Windows.Forms.Label lblPrevImagen;
    }
}

