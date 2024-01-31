using System;
using System.Windows.Forms;

namespace discos_form
{
    partial class frmDiscos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDiscos = new System.Windows.Forms.Label();
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.btnAgregarDisco = new System.Windows.Forms.Button();
            this.btnEliminarDisco = new System.Windows.Forms.Button();
            this.btnModificarDisco = new System.Windows.Forms.Button();
            this.btnAgregarEstilo = new System.Windows.Forms.Button();
            this.cbFiltrarGenero = new System.Windows.Forms.ComboBox();
            this.lblFiltroGenero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiscos
            // 
            this.lblDiscos.AutoSize = true;
            this.lblDiscos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDiscos.Location = new System.Drawing.Point(558, 13);
            this.lblDiscos.Name = "lblDiscos";
            this.lblDiscos.Size = new System.Drawing.Size(126, 45);
            this.lblDiscos.TabIndex = 0;
            this.lblDiscos.Text = "Discos";
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.AllowUserToAddRows = false;
            this.dgvDiscos.AllowUserToDeleteRows = false;
            this.dgvDiscos.AllowUserToResizeColumns = false;
            this.dgvDiscos.AllowUserToResizeRows = false;
            this.dgvDiscos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiscos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.dgvDiscos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiscos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDiscos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDiscos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiscos.ColumnHeadersHeight = 30;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.EnableHeadersVisualStyles = false;
            this.dgvDiscos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            this.dgvDiscos.Location = new System.Drawing.Point(75, 68);
            this.dgvDiscos.Margin = new System.Windows.Forms.Padding(10);
            this.dgvDiscos.MaximumSize = new System.Drawing.Size(1038, 275);
            this.dgvDiscos.MinimumSize = new System.Drawing.Size(1038, 100);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.ReadOnly = true;
            this.dgvDiscos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiscos.RowHeadersVisible = false;
            this.dgvDiscos.RowHeadersWidth = 51;
            this.dgvDiscos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(68)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(65)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiscos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDiscos.RowTemplate.Height = 24;
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(1038, 250);
            this.dgvDiscos.TabIndex = 1;
            // 
            // btnAgregarDisco
            // 
            this.btnAgregarDisco.AutoSize = true;
            this.btnAgregarDisco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregarDisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(151)))), ((int)(((byte)(171)))));
            this.btnAgregarDisco.Location = new System.Drawing.Point(75, 386);
            this.btnAgregarDisco.Name = "btnAgregarDisco";
            this.btnAgregarDisco.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnAgregarDisco.Size = new System.Drawing.Size(160, 41);
            this.btnAgregarDisco.TabIndex = 2;
            this.btnAgregarDisco.Text = "Cargar nuevo disco";
            this.btnAgregarDisco.UseVisualStyleBackColor = true;
            this.btnAgregarDisco.Click += new System.EventHandler(this.btnAgregarDisco_Click);
            // 
            // btnEliminarDisco
            // 
            this.btnEliminarDisco.AutoSize = true;
            this.btnEliminarDisco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnEliminarDisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(151)))), ((int)(((byte)(171)))));
            this.btnEliminarDisco.Location = new System.Drawing.Point(75, 452);
            this.btnEliminarDisco.Name = "btnEliminarDisco";
            this.btnEliminarDisco.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnEliminarDisco.Size = new System.Drawing.Size(125, 41);
            this.btnEliminarDisco.TabIndex = 3;
            this.btnEliminarDisco.Text = "Eliminar disco";
            this.btnEliminarDisco.UseVisualStyleBackColor = true;
            this.btnEliminarDisco.Click += new System.EventHandler(this.btnEliminarDisco_Click);
            // 
            // btnModificarDisco
            // 
            this.btnModificarDisco.AutoSize = true;
            this.btnModificarDisco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnModificarDisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(151)))), ((int)(((byte)(171)))));
            this.btnModificarDisco.Location = new System.Drawing.Point(276, 386);
            this.btnModificarDisco.Name = "btnModificarDisco";
            this.btnModificarDisco.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnModificarDisco.Size = new System.Drawing.Size(136, 41);
            this.btnModificarDisco.TabIndex = 4;
            this.btnModificarDisco.Text = "Modificar disco";
            this.btnModificarDisco.UseVisualStyleBackColor = true;
            this.btnModificarDisco.Click += new System.EventHandler(this.btnModificarDisco_Click);
            // 
            // btnAgregarEstilo
            // 
            this.btnAgregarEstilo.AutoSize = true;
            this.btnAgregarEstilo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.btnAgregarEstilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(151)))), ((int)(((byte)(171)))));
            this.btnAgregarEstilo.Location = new System.Drawing.Point(276, 452);
            this.btnAgregarEstilo.Name = "btnAgregarEstilo";
            this.btnAgregarEstilo.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.btnAgregarEstilo.Size = new System.Drawing.Size(134, 41);
            this.btnAgregarEstilo.TabIndex = 5;
            this.btnAgregarEstilo.Text = "Agregar estilo";
            this.btnAgregarEstilo.UseVisualStyleBackColor = true;
            // 
            // cbFiltrarGenero
            // 
            this.cbFiltrarGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrarGenero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFiltrarGenero.FormattingEnabled = true;
            this.cbFiltrarGenero.Location = new System.Drawing.Point(451, 400);
            this.cbFiltrarGenero.Name = "cbFiltrarGenero";
            this.cbFiltrarGenero.Size = new System.Drawing.Size(214, 27);
            this.cbFiltrarGenero.TabIndex = 6;
            this.cbFiltrarGenero.DropDownClosed += new System.EventHandler(this.cbFiltrarGenero_DropDownClosed);
            // 
            // lblFiltroGenero
            // 
            this.lblFiltroGenero.AutoSize = true;
            this.lblFiltroGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(151)))), ((int)(((byte)(171)))));
            this.lblFiltroGenero.Location = new System.Drawing.Point(451, 378);
            this.lblFiltroGenero.Name = "lblFiltroGenero";
            this.lblFiltroGenero.Size = new System.Drawing.Size(116, 19);
            this.lblFiltroGenero.TabIndex = 7;
            this.lblFiltroGenero.Text = "Filtrar por genero";
            // 
            // frmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1234, 674);
            this.Controls.Add(this.lblFiltroGenero);
            this.Controls.Add(this.cbFiltrarGenero);
            this.Controls.Add(this.btnAgregarEstilo);
            this.Controls.Add(this.btnModificarDisco);
            this.Controls.Add(this.btnEliminarDisco);
            this.Controls.Add(this.btnAgregarDisco);
            this.Controls.Add(this.dgvDiscos);
            this.Controls.Add(this.lblDiscos);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Discos";
            this.Load += new System.EventHandler(this.frmDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiscos;
        private System.Windows.Forms.DataGridView dgvDiscos;
        private Button btnAgregarDisco;
        private Button btnEliminarDisco;
        private Button btnModificarDisco;
        private Button btnAgregarEstilo;
        private ComboBox cbFiltrarGenero;
        private Label lblFiltroGenero;
    }
}

