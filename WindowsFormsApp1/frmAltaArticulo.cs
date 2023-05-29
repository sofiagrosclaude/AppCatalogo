using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;
using System.CodeDom;

namespace WindowsFormsApp1
{
    public partial class frmAltaArticulo : Form
    {
        public Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {   
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripción.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Categoria = (Categoria)cmbCategoria.SelectedItem;
                articulo.Marca = (Marca)cmbMarca.SelectedItem;

                
                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente!");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente!");
                }
                
                if(archivo != null && (txtImagenUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["ImágenesApp"] + archivo.SafeFileName);
                
                
                 Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el precio, por favor");
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cmbCategoria.DataSource = categoriaNegocio.listar();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";
                cmbMarca.DataSource = marcaNegocio.listar();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripción.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString("0.00");
                    cmbCategoria.SelectedValue = articulo.Categoria.Id;
                    cmbMarca.SelectedValue = articulo.Marca.Id;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
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

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
