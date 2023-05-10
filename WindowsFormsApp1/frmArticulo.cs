using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            //dgvArticulos.Columns["IdCategoria"].Visible = false;
            //dgvArticulos.Columns["IdMarca"].Visible = false;
            cargarImagen(listaArticulo[0].ImagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);

            
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulos.Load(imagen);
            }
            catch
            {

                pbArticulos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4QOjaXf9Kp3OBcQOQoOqF17obRPZ759bXsSSZIboGEcT6NvAmLSuYeqxYSUDoGQtb_4U&usqp=CAU");
            }
        }
    }
}
