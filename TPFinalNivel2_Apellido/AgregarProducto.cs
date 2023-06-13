using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using ConexionDb;
using System.Xml.Linq;


namespace TPFinalNivel2_Apellido
{
    public partial class frmAgregarProducto : Form
    {
        private Productos nuevo = null;
        public frmAgregarProducto()
        {
            InitializeComponent();
            if ((txbNombre.Text=="")||(txbPrecio.Text=="")|| (comboBoxCategoriaId.SelectedItem == null)) { btnAceptar.Enabled = false; }
            else { btnAceptar.Enabled = true; }
            
        }
        public frmAgregarProducto(Productos nuevo)
        {
            InitializeComponent();
            this.nuevo = nuevo;
            Text = "Modificar Producto.";
        }
        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            MarcaMetodos marcametodo = new MarcaMetodos();
            CategoriaMetodo categoriaMetodo = new CategoriaMetodo();
            try
            {

                comboBoxMarcaId.DataSource = marcametodo.listar();
                comboBoxMarcaId.ValueMember = "Id";
                comboBoxMarcaId.DisplayMember = "Descripcion";

                comboBoxCategoriaId.DataSource = categoriaMetodo.listar();
                comboBoxCategoriaId.ValueMember = "Id";
                comboBoxCategoriaId.DisplayMember = "Descripcion";

                if (nuevo != null)
                {
                    txbCodArt.Text = nuevo.CodArt;
                    txbDescr.Text = nuevo.Descripcion;
                    txbNombre.Text = nuevo.Nombre;
                    txbImagen.Text = nuevo.Imagen;
                    cargarImagen(nuevo.Imagen);
                    txbPrecio.Text = nuevo.Precio.ToString();
                    comboBoxCategoriaId.SelectedValue = nuevo.Categoria.Id;
                    comboBoxMarcaId.SelectedValue = nuevo.Marca.Id;



                }
                else
                {
                    comboBoxCategoriaId.SelectedIndex = -1;
                    comboBoxMarcaId.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
   
        }
        
        private bool validarNumeros(string cadena)
        {
            char coma = ',';
                foreach (char caracter in cadena)
                {
                    if (!(char.IsNumber(caracter))&& (!(caracter ==coma)))
                    {
                        return false;
                    }
                }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                ProductosNegocio agregarProd = new ProductosNegocio();
                try
                {
                
                if (nuevo == null)
                        nuevo = new Productos();
                    
                    nuevo.Nombre = txbNombre.Text;
                    nuevo.Precio = decimal.Parse(txbPrecio.Text);
                    nuevo.Descripcion = txbDescr.Text;
                    nuevo.CodArt = txbCodArt.Text;
                    nuevo.Imagen = txbImagen.Text;
                    nuevo.Marca = new Marca();
                    nuevo.Marca.Id = (int)comboBoxMarcaId.SelectedValue;

                    nuevo.Categoria = new Categoria();
                    nuevo.Categoria.Id = (int)comboBoxCategoriaId.SelectedValue;

                   

                    if (nuevo.Id != 0)//si tiene Id, ya existe, lo modifica. Si no tiene lo crea.
                    {
                    agregarProd.modificar(nuevo);
                    MessageBox.Show("Producto Modificado con exito.","Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    }
                    else
                    {
                     agregarProd.agregar(nuevo);
                     MessageBox.Show("Producto Agregado.","Agregado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
           
            
            
        }
        private void cargarImagen(String imagen)
        {
            try
            {
                pictureBox.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ28WA2ZQREgEZ1jva2HNK6hzzNLXtnkxGhG2eCg1bAuw&s"); ;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txbPrecio_TextChanged(object sender, EventArgs e)
        {
            if ((txbNombre.Text != "") && (txbPrecio.Text != "")&& (comboBoxCategoriaId.SelectedValue!=null)&&(comboBoxMarcaId.SelectedValue!=null))
            {
                btnAceptar.Enabled = true;
            }
            else {
               
                btnAceptar.Enabled = false; 
            }    
            try
            {
                if (!(validarNumeros(txbPrecio.Text)))
                {
                    DialogResult dialogResult = MessageBox.Show("El campo Precio, solo puede recibir numeros", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPrecio.Text = null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        private void comboBoxCategoriaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((txbNombre.Text != "") && (txbPrecio.Text != "")&& (comboBoxCategoriaId.SelectedValue!=null)&&(comboBoxMarcaId.SelectedValue!=null))
            {
                btnAceptar.Enabled = true;
            }
            else { btnAceptar.Enabled = false; }
        }

        private void txbImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txbImagen.Text);
        }

        private void comboBoxMarcaId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            if ((txbNombre.Text != "") && (txbPrecio.Text != ""))
            {
                btnAceptar.Enabled = true;
            }
            else { btnAceptar.Enabled = false; }
        }

        private void txbNombre_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
