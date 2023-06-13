using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionDb;
using Dominio;

namespace TPFinalNivel2_Apellido
{
    public partial class Form1 : Form
    {
        private List<Productos> listaProductos;
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            recargarFormulario();
            cboBoxFiltroBuscar.Items.Add("Precio");
            cboBoxFiltroBuscar.Items.Add("Marca");
            cboBoxFiltroBuscar.Items.Add("Categoria");
           
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
        private void recargarFormulario()
        {
            ProductosNegocio recargar = new ProductosNegocio();
            try
            {
                listaProductos = recargar.listar();
                dgvProd.DataSource = listaProductos;
                ocultarColumnas();
                cargarImagen(listaProductos[0].Imagen);
                if (cboBoxFiltroRango.Text == "")
                {
                    btnFiltro.Enabled = false;
                }
                else
                {
                    btnFiltro.Enabled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvProd.Columns["Imagen"].Visible = false;
            dgvProd.Columns["Id"].Visible = false;
        }
        private void dgvProd_SelectionChanged_1(object sender, EventArgs e)
        {
            if(dgvProd.CurrentRow!= null) {
                Productos seleccionado = (Productos)dgvProd.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProducto nuevoForm = new frmAgregarProducto();
            nuevoForm.ShowDialog();
            recargarFormulario();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Productos seleccionado;
            seleccionado = (Productos)dgvProd.CurrentRow.DataBoundItem; //de la grilla, el item que seleccione, lo asig
                                                                         //no a seleccionado. seleccionado es la variable.
            frmAgregarProducto modificar = new frmAgregarProducto(seleccionado);
            modificar.ShowDialog();
            recargarFormulario();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductosNegocio eliminar = new ProductosNegocio();
            Productos seleccionado;
            try
            {
                DialogResult respuesta= MessageBox.Show("Una vez eliminado el producto, no podra ser reestablecido. ¿Desea Continuar?","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Productos)dgvProd.CurrentRow.DataBoundItem;
                    eliminar.eliminar(seleccionado.Id);
                    recargarFormulario();
                }
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Productos> listaBuscar;
            string buscar= textBoxBuscar.Text;

            if( buscar.Length >= 2)
            {
                listaBuscar = listaProductos.FindAll(x => x.Nombre.ToLower().Contains (buscar.ToLower())|| x.CodArt.ToLower().Contains(buscar.ToLower()) || x.Marca.Descripcion.ToLower().Contains(buscar.ToLower())|| x.Descripcion.ToLower().Contains(buscar.ToLower()) || x.Categoria.Descripcion.ToLower().Contains(buscar.ToLower()));
                
            }
            else
            {
                listaBuscar = listaProductos;
            }
            dgvProd.DataSource = null;
            dgvProd.DataSource = listaBuscar;
            ocultarColumnas();
            if (listaBuscar.Count == 0)
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                cargarImagen(null);
            }
            else
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
           

        }

        private void cboBoxFiltroBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBoxFiltroRango.Enabled = true;   
            if (cboBoxFiltroBuscar.SelectedItem != null) 
            {
                string opcion = cboBoxFiltroBuscar.SelectedItem.ToString();
                try
                {

                    if (opcion == "Precio")
                    {
                        cboBoxFiltroRango.Items.Clear();
                        cboBoxFiltroRango.Items.Add("Mayor a $100000");
                        cboBoxFiltroRango.Items.Add("Gama intermedia");
                        cboBoxFiltroRango.Items.Add("Menor a $50000");
                    }
                    else if (opcion == "Marca")
                    {
                        cboBoxFiltroRango.Items.Clear();
                        cboBoxFiltroRango.Items.Add("Samsung");
                        cboBoxFiltroRango.Items.Add("Sony");
                        cboBoxFiltroRango.Items.Add("Apple");
                        cboBoxFiltroRango.Items.Add("Huawei");
                        cboBoxFiltroRango.Items.Add("Motorola");
                    }
                    else
                    {
                        cboBoxFiltroRango.Items.Clear();
                        cboBoxFiltroRango.Items.Add("Televisores");
                        cboBoxFiltroRango.Items.Add("Audio");
                        cboBoxFiltroRango.Items.Add("Media");
                        cboBoxFiltroRango.Items.Add("Celulares");
                    }
                    textBoxBuscar.Text = "";
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            textBoxBuscar.Text = "";
            List<Productos> listaFiltrar;
            string criterio = cboBoxFiltroBuscar.Text;
            string rango = cboBoxFiltroRango.Text;

            if (criterio == "Precio")
            {
                if(rango=="Mayor a $100000")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Precio > 100000);
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }else if (rango== "Menor a $50000")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Precio < 50000);
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }
                else {
                    listaFiltrar = listaProductos.FindAll(x => x.Precio < 50000 && x.Precio > 100000);
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }
                if (listaFiltrar.Count == 0)
                {
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cargarImagen(null);
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }

            }
            
            else if (criterio == "Categoria")
            {
                if (rango == "Televisores")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Categoria.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                } else if (rango == "Audio")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Categoria.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                } else if (rango == "Media")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Categoria.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                } else        
                {
                    rango = "Celulares";
                    listaFiltrar = listaProductos.FindAll(x => x.Categoria.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }
                if (listaFiltrar.Count == 0)
                {
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cargarImagen(null);
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
            else if (criterio == "Marca")
            {
                if( rango== "Motorola")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Marca.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }
                else if (rango == "Huawei")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Marca.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }
                else if (rango == "Samsung")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Marca.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }
                else if (rango == "Sony")
                {
                    listaFiltrar = listaProductos.FindAll(x => x.Marca.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }
                else
                {
                    rango = "Apple";
                    listaFiltrar = listaProductos.FindAll(x => x.Marca.Descripcion.Contains(rango));
                    dgvProd.DataSource = null;
                    dgvProd.DataSource = listaFiltrar;
                    ocultarColumnas();
                }
                if (listaFiltrar.Count == 0)
                {
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    cargarImagen(null);
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }



            }
        }

        private void cboBoxFiltroRango_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboBoxFiltroRango_TextChanged(object sender, EventArgs e)
        {
            if(btnFiltro.Enabled==false)
                recargarFormulario();
        }

        private void cboBoxFiltroBuscar_TextChanged(object sender, EventArgs e)
        {
            recargarFormulario();
            btnFiltro.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            textBoxBuscar.Text = "";
            cboBoxFiltroRango.Text = null;
            cboBoxFiltroBuscar.Text = null;
            cboBoxFiltroRango.Enabled = false;
            
            btnFiltro.Enabled = true;
            recargarFormulario();
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            Productos seleccionado;
            seleccionado = (Productos)dgvProd.CurrentRow.DataBoundItem;
            frmVerInfo verInfo= new frmVerInfo(seleccionado);
            verInfo.ShowDialog();
            recargarFormulario();
        }

        private void cboBoxFiltroBuscar_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxBuscar.Text = "";
        }

        private void cboBoxFiltroRango_SelectedValueChanged(object sender, EventArgs e)
        {
           ;
        }
    }
   
}