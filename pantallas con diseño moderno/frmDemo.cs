using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantallas_con_diseño_moderno
{
    public partial class frmDemo : Form
    {
        public class Usuario
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string telefono { get; set; }
        }

            private List<Usuario> listadoUsuarios = new List<Usuario>();
            private int index = 1;
        
        public frmDemo()
        {
            InitializeComponent();
            actualizarDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                id = index++,
                nombre = txtDemo1.Text,
                apellido = txtDemo2.Text,
                telefono = txtDemo3.Text,
            };

            listadoUsuarios.Add(usuario);
            actualizarDGV();
            clearFields();
        }

        private void actualizarDGV()
        {
            dgvLoad.DataSource = null;
            dgvLoad.DataSource = listadoUsuarios;
        }

        private void clearFields()
        {
            txtDemo1.Clear();
            txtDemo2.Clear();
            txtDemo3.Clear();
            txtDemo4.Clear();
        }
    }
}
