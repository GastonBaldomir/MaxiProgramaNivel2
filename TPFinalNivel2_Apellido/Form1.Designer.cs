namespace TPFinalNivel2_Apellido
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.cboBoxFiltroRango = new System.Windows.Forms.ComboBox();
            this.cboBoxFiltroBuscar = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProd.Location = new System.Drawing.Point(12, 58);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(665, 208);
            this.dgvProd.TabIndex = 0;
            this.dgvProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellContentClick);
            this.dgvProd.SelectionChanged += new System.EventHandler(this.dgvProd_SelectionChanged_1);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(683, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(215, 186);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 295);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(130, 295);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 31);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(254, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(758, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(58, 21);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(213, 20);
            this.textBoxBuscar.TabIndex = 6;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.labelBuscar.Location = new System.Drawing.Point(12, 24);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(40, 13);
            this.labelBuscar.TabIndex = 7;
            this.labelBuscar.Text = "Buscar";
            // 
            // cboBoxFiltroRango
            // 
            this.cboBoxFiltroRango.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxFiltroRango.FormattingEnabled = true;
            this.cboBoxFiltroRango.Location = new System.Drawing.Point(446, 21);
            this.cboBoxFiltroRango.Name = "cboBoxFiltroRango";
            this.cboBoxFiltroRango.Size = new System.Drawing.Size(113, 21);
            this.cboBoxFiltroRango.TabIndex = 12;
            this.cboBoxFiltroRango.SelectedIndexChanged += new System.EventHandler(this.cboBoxFiltroRango_SelectedIndexChanged);
            this.cboBoxFiltroRango.SelectedValueChanged += new System.EventHandler(this.cboBoxFiltroRango_SelectedValueChanged);
            this.cboBoxFiltroRango.TextChanged += new System.EventHandler(this.cboBoxFiltroRango_TextChanged);
            // 
            // cboBoxFiltroBuscar
            // 
            this.cboBoxFiltroBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxFiltroBuscar.FormattingEnabled = true;
            this.cboBoxFiltroBuscar.Location = new System.Drawing.Point(327, 21);
            this.cboBoxFiltroBuscar.Name = "cboBoxFiltroBuscar";
            this.cboBoxFiltroBuscar.Size = new System.Drawing.Size(113, 21);
            this.cboBoxFiltroBuscar.TabIndex = 11;
            this.cboBoxFiltroBuscar.SelectedIndexChanged += new System.EventHandler(this.cboBoxFiltroBuscar_SelectedIndexChanged);
            this.cboBoxFiltroBuscar.SelectedValueChanged += new System.EventHandler(this.cboBoxFiltroBuscar_SelectedValueChanged);
            this.cboBoxFiltroBuscar.TextChanged += new System.EventHandler(this.cboBoxFiltroBuscar_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(565, 16);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(52, 29);
            this.btnFiltro.TabIndex = 13;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblFiltro.Location = new System.Drawing.Point(292, 24);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 14;
            this.lblFiltro.Text = "Filtro";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(624, 16);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(53, 29);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.Location = new System.Drawing.Point(568, 295);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(109, 31);
            this.btnVerInfo.TabIndex = 16;
            this.btnVerInfo.Text = "Ver Información";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(910, 361);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.cboBoxFiltroRango);
            this.Controls.Add(this.cboBoxFiltroBuscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dgvProd);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario de Articulos.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.ComboBox cboBoxFiltroRango;
        private System.Windows.Forms.ComboBox cboBoxFiltroBuscar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnVerInfo;
    }
}

