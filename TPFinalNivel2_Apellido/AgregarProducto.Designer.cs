namespace TPFinalNivel2_Apellido
{
    partial class frmAgregarProducto
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescr = new System.Windows.Forms.Label();
            this.labelCodArt = new System.Windows.Forms.Label();
            this.labelMarcaId = new System.Windows.Forms.Label();
            this.labelCategoriaId = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.comboBoxMarcaId = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoriaId = new System.Windows.Forms.ComboBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescr = new System.Windows.Forms.TextBox();
            this.txbCodArt = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.labelImg = new System.Windows.Forms.Label();
            this.txbImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(326, 264);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 34);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(478, 264);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 34);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(354, 27);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(192, 175);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(33, 34);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescr
            // 
            this.labelDescr.AutoSize = true;
            this.labelDescr.Location = new System.Drawing.Point(33, 69);
            this.labelDescr.Name = "labelDescr";
            this.labelDescr.Size = new System.Drawing.Size(63, 13);
            this.labelDescr.TabIndex = 4;
            this.labelDescr.Text = "Descripción";
            // 
            // labelCodArt
            // 
            this.labelCodArt.AutoSize = true;
            this.labelCodArt.Location = new System.Drawing.Point(33, 102);
            this.labelCodArt.Name = "labelCodArt";
            this.labelCodArt.Size = new System.Drawing.Size(93, 13);
            this.labelCodArt.TabIndex = 5;
            this.labelCodArt.Text = "Codigo de Articulo";
            // 
            // labelMarcaId
            // 
            this.labelMarcaId.AutoSize = true;
            this.labelMarcaId.Location = new System.Drawing.Point(35, 139);
            this.labelMarcaId.Name = "labelMarcaId";
            this.labelMarcaId.Size = new System.Drawing.Size(37, 13);
            this.labelMarcaId.TabIndex = 6;
            this.labelMarcaId.Text = "Marca";
            // 
            // labelCategoriaId
            // 
            this.labelCategoriaId.AutoSize = true;
            this.labelCategoriaId.Location = new System.Drawing.Point(33, 174);
            this.labelCategoriaId.Name = "labelCategoriaId";
            this.labelCategoriaId.Size = new System.Drawing.Size(52, 13);
            this.labelCategoriaId.TabIndex = 7;
            this.labelCategoriaId.Text = "Categoria";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(35, 206);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 8;
            this.labelPrecio.Text = "Precio";
            // 
            // comboBoxMarcaId
            // 
            this.comboBoxMarcaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarcaId.FormattingEnabled = true;
            this.comboBoxMarcaId.Location = new System.Drawing.Point(166, 131);
            this.comboBoxMarcaId.Name = "comboBoxMarcaId";
            this.comboBoxMarcaId.Size = new System.Drawing.Size(113, 21);
            this.comboBoxMarcaId.TabIndex = 9;
            this.comboBoxMarcaId.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarcaId_SelectedIndexChanged);
            // 
            // comboBoxCategoriaId
            // 
            this.comboBoxCategoriaId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoriaId.FormattingEnabled = true;
            this.comboBoxCategoriaId.Location = new System.Drawing.Point(166, 166);
            this.comboBoxCategoriaId.Name = "comboBoxCategoriaId";
            this.comboBoxCategoriaId.Size = new System.Drawing.Size(113, 21);
            this.comboBoxCategoriaId.TabIndex = 10;
            this.comboBoxCategoriaId.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoriaId_SelectedIndexChanged);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(166, 27);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(113, 20);
            this.txbNombre.TabIndex = 11;
            this.txbNombre.EnabledChanged += new System.EventHandler(this.txbNombre_EnabledChanged);
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // txbDescr
            // 
            this.txbDescr.Location = new System.Drawing.Point(166, 62);
            this.txbDescr.Name = "txbDescr";
            this.txbDescr.Size = new System.Drawing.Size(113, 20);
            this.txbDescr.TabIndex = 12;
            // 
            // txbCodArt
            // 
            this.txbCodArt.Location = new System.Drawing.Point(166, 95);
            this.txbCodArt.Name = "txbCodArt";
            this.txbCodArt.Size = new System.Drawing.Size(113, 20);
            this.txbCodArt.TabIndex = 13;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(166, 199);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(113, 20);
            this.txbPrecio.TabIndex = 14;
            this.txbPrecio.TextChanged += new System.EventHandler(this.txbPrecio_TextChanged);
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.Location = new System.Drawing.Point(33, 238);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(42, 13);
            this.labelImg.TabIndex = 15;
            this.labelImg.Text = "Imagen";
            // 
            // txbImagen
            // 
            this.txbImagen.Location = new System.Drawing.Point(166, 231);
            this.txbImagen.Name = "txbImagen";
            this.txbImagen.Size = new System.Drawing.Size(113, 20);
            this.txbImagen.TabIndex = 16;
            this.txbImagen.TextChanged += new System.EventHandler(this.txbImagen_TextChanged);
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 344);
            this.Controls.Add(this.txbImagen);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbCodArt);
            this.Controls.Add(this.txbDescr);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.comboBoxCategoriaId);
            this.Controls.Add(this.comboBoxMarcaId);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelCategoriaId);
            this.Controls.Add(this.labelMarcaId);
            this.Controls.Add(this.labelCodArt);
            this.Controls.Add(this.labelDescr);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.Name = "frmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescr;
        private System.Windows.Forms.Label labelCodArt;
        private System.Windows.Forms.Label labelMarcaId;
        private System.Windows.Forms.Label labelCategoriaId;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.ComboBox comboBoxMarcaId;
        private System.Windows.Forms.ComboBox comboBoxCategoriaId;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescr;
        private System.Windows.Forms.TextBox txbCodArt;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.TextBox txbImagen;
    }
}