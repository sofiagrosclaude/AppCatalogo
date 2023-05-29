using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using static System.Net.Mime.MediaTypeNames;


namespace WindowsFormsApp1
{
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulo;
        public frmArticulo()
        {
            InitializeComponent();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            cargar();
            cmbCualidad.Items.Add("Categoría");
            cmbCualidad.Items.Add("Marca");
            cmbCualidad.Items.Add("Precio");  
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            } 
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";

                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } 
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["descripcion"].Visible = false;
        }
        
        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulos.Load(imagen);
            }
            catch
            {   
                pbArticulos.Load("https://grupoa2.com/wp-content/uploads/woocommerce-placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

            }
            else
            {
                MessageBox.Show("Por favor seleccione un artículo para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el artículo seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes) 
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void btnDetalle_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                MessageBox.Show("NOMBRE: " + seleccionado.Nombre + ", DESCRIPCIÓN: " + seleccionado.Descripcion +  ", PRECIO: " + seleccionado.Precio.ToString("0.00") + ".", "Detalles de artículo");

            }
            else
            {
                MessageBox.Show("Por favor seleccione un artículo para ver detalles.");
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaArticulo ventana = new frmAltaArticulo();
            ventana.ShowDialog();
        }
        
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el artículo seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            MessageBox.Show("NOMBRE: " + seleccionado.Nombre + ", DESCRIPCIÓN: " + seleccionado.Descripcion + ", PRECIO: " + seleccionado.Precio.ToString("0.00") + ".", "Detalles de artículo");
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicación fue desarollada por Sofía Grosclaude como proyecto final del Curso C# Nivel 2 en MAXIPROGRAMA.COM Campus. Para instrucciones o inconvenientes con la aplicación escribir a la dirección: sofiagrosclaud@gmail.com", "About");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
            List<Articulo> listaFiltrada;
            
            string filtro = txtBuscar.Text;
            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
  
            }
            else
            {
                listaFiltrada = listaArticulo;
            }



            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ocultarColumnas();
        }

        private void cmbSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cmbCualidad.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Desde");
                cmbCriterio.Items.Add("Hasta");
            }
            else
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Contiene");
                cmbCriterio.Items.Add("Empieza con");

            }
        }
        private bool validarFiltro()
        {
            if(cmbCualidad.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor complete los campos del filtro.");
                return true;
            }
            
            if(cmbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor complete los campos del filtro.");
                return true;
            }
            if (cmbCualidad.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtBuscar2.Text))
                {
                    MessageBox.Show("Por favor cargar el filtro para numéricos.");
                    return true;
                }
                if (!(soloNumeros(txtBuscar2.Text)))
                {
                    MessageBox.Show("Por favor indique el precio en números.");
                    return true;
                }
            }
            return false;

        
        }
        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                
                    return false;
                
            }
                return true;
        }
    
        private void btnIr_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }
                string cualidad = cmbCualidad.SelectedItem.ToString();
                string criterio = cmbCriterio.SelectedItem.ToString();
                string filtro = txtBuscar2.Text;
                dgvArticulos.DataSource = negocio.filtrar(cualidad, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = null;
            txtBuscar2.Text = null;
            
            cargar();
        }
    }
}

