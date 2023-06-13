using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_Apellido
{
    public partial class frmVerInfo : Form
    {
        private Productos producto=null;
        public frmVerInfo()
        {
            InitializeComponent();
            
        }
         public frmVerInfo(Productos seleccionado)
        {
            InitializeComponent();
            producto = seleccionado;
        }
        private void frmVerInfo_Load(object sender, EventArgs e)
        {
            lblNombre.Text = producto.Nombre;
            lblMarca.Text = producto.Marca.Descripcion;
            lblCategoria.Text=producto.Categoria.Descripcion;
            lblCodArt.Text = producto.CodArt;
            lblPrecio.Text = producto.Precio.ToString();
            lblDescr.Text = producto.Descripcion;
            cargarImagen(producto.Imagen);
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cargarImagen(String imagen)
        {
            try
            {
                pictureBoxVerInfo.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxVerInfo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ28WA2ZQREgEZ1jva2HNK6hzzNLXtnkxGhG2eCg1bAuw&s"); ;
            }
        }
    }
}
