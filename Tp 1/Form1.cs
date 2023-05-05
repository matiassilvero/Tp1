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
using Negocio;

namespace Tp_1
{
    public partial class Form1 : Form

    {
        private List<Articulo> listaOriginal;
        public Form1()
        {
            InitializeComponent();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)  //apenas nace, el Form llama a la función cargar() para traer la info de la base
        {
            cargar();  
        }

        private void cargar()  //la función crea una instancia de ArticuloNegocio, del cual usa el método listar(),
                               //el return lo pasa a la dgvLista para mostrarlo en el Form
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaOriginal = negocio.listar();
            dgvLista.DataSource = listaOriginal;
            //dgvLista.Columns[0].Visible = false; permite no mostrar una columna en el Form
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
