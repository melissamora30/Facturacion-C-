using Guna.UI2.WinForms;
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
    public partial class FrmClientes : Form
    {
        public class Cliente //Crear clase con los datos del usuario
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
        }

        public List<Cliente> listadoClientes = new List<Cliente>(); //Crear lista para almacenar los usuarios
        private int index = 1; //Esto es un indicador de posicion [0,1,2,3]

        public FrmClientes()
        {
            InitializeComponent();
            ActualizarGrid();//Inicializar para ver en tiempo real
            ConfigurarBotones();
        }

        private void ConfigurarBotones()
        {
            // Verificar si la columna de borrar ya está agregada
            if (DGVclientes.Columns["Borrar"] == null)
            {
                // Crear la columna de botones de borrar
                DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
                btnBorrar.Name = "Borrar";
                btnBorrar.HeaderText = "Borrar";
                btnBorrar.Text = "Borrar";
                btnBorrar.UseColumnTextForButtonValue = true; // Hace que cada botón muestre el texto "Borrar"
                DGVclientes.Columns.Add(btnBorrar);
            }

            // Configurar el evento CellContentClick para manejar clics en los botones
            DGVclientes.CellContentClick += eliminarUsuarios;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Limpiar las columnas existentes
            DGVclientes.Columns.Clear();

            // Definir las columnas manualmente con el DataPropertyName
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.HeaderText = "ID";
            colId.DataPropertyName = "Id"; // Vincula a la propiedad Id de la clase Cliente
            DGVclientes.Columns.Add(colId);

            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "Nombre"; // Vincula a la propiedad Nombre
            DGVclientes.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colDireccion = new DataGridViewTextBoxColumn();
            colDireccion.HeaderText = "Dirección";
            colDireccion.DataPropertyName = "Direccion"; // Vincula a la propiedad Direccion
            DGVclientes.Columns.Add(colDireccion);

            DataGridViewTextBoxColumn colTelefono = new DataGridViewTextBoxColumn();
            colTelefono.HeaderText = "Teléfono";
            colTelefono.DataPropertyName = "Telefono"; // Vincula a la propiedad Telefono
            DGVclientes.Columns.Add(colTelefono);

            // Columna para el botón "Editar"
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.HeaderText = "Editar";
            colEditar.Name = "btnEditar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            DGVclientes.Columns.Add(colEditar);

            // Columna para el botón "Borrar"
            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Name = "btnBorrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            DGVclientes.Columns.Add(colBorrar);
            DGVclientes.CellClick += eliminarUsuarios;
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e) //Esto es una accion Click de x Boton
        {
            pnlFields();
            txtNombreCliente();
            txtDireccionCliente();
            txtTelefonoCliente();
            lblMensajeCliente();
            btnCerrarCliente();
            btnAgregarCliente();
        }

        private void ActualizarGrid() //Actualizar el DataGridView para que muestre los datos en tiempo real
        {
            DGVclientes.AutoGenerateColumns = false; //Le indicamos no auto agregar columnas sino que se acople a las que ya hay
            DGVclientes.DataSource = null; //Borrar datos
            DGVclientes.DataSource = listadoClientes; //Agregar segun los parametros de la lista
        }

        private void clearFields() //Aqui esta el metodo anterior para borrar
        {
            txtNombre1.Clear();
            txtDireccion1.Clear();
            txtTelefono1.Clear();
        }

        private Guna2Panel pnlFieldsClientes;
        private void pnlFields()
        {
            pnlFieldsClientes = new Guna2Panel();
            pnlFieldsClientes.Size = new Size(300, 350);
            pnlFieldsClientes.BorderRadius = 1000;
            pnlFieldsClientes.BackColor = SystemColors.ControlLight;
            pnlFieldsClientes.ForeColor = Color.Black;
            pnlFieldsClientes.Location = new Point(175, 182);
            pnlFieldsClientes.Padding = new Padding(20, 20, 20, 20);
            pnlAddClienteBorder = new Guna2Elipse();
            pnlAddClienteBorder.TargetControl = pnlFieldsClientes;
            pnlAddClienteBorder.BorderRadius = 30;
            Controls.Add(pnlFieldsClientes);
            pnlFieldsClientes.BringToFront();
        }


        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            Filtro(sender, e);
        }

        private Guna2TextBox txtNombre1;
        private void txtNombreCliente()
        {
            txtNombre1 = new Guna2TextBox();
            txtNombre1.PlaceholderText = "Nombre";
            txtNombre1.Size = new Size(270, 45);
            txtNombre1.BorderRadius = 20;
            txtNombre1.FillColor = Color.White;
            txtNombre1.BackColor = SystemColors.ControlLight;
            txtNombre1.ForeColor = SystemColors.ControlText;
            txtNombre1.Location = new Point(190, 290);
            Controls.Add(txtNombre1);
            txtNombre1.BringToFront();
        }

        private Guna2TextBox txtDireccion1;
        private void txtDireccionCliente()
        {
            txtDireccion1 = new Guna2TextBox();
            txtDireccion1.PlaceholderText = "Direccion";
            txtDireccion1.Size = new Size(270, 45);
            txtDireccion1.BorderRadius = 20;
            txtDireccion1.FillColor = Color.White;
            txtDireccion1.BackColor = SystemColors.ControlLight;
            txtDireccion1.ForeColor = SystemColors.ControlText;
            txtDireccion1.Location = new Point(190, 345);
            Controls.Add(txtDireccion1);
            txtDireccion1.BringToFront();
        }

        private Guna2TextBox txtTelefono1;
        private void txtTelefonoCliente()
        {
            txtTelefono1 = new Guna2TextBox();
            txtTelefono1.PlaceholderText = "Telefono";
            txtTelefono1.Size = new Size(270, 45);
            txtTelefono1.BorderRadius = 20;
            txtTelefono1.FillColor = Color.White;
            txtTelefono1.BackColor = SystemColors.ControlLight;
            txtTelefono1.ForeColor = SystemColors.ControlText;
            txtTelefono1.Location = new Point(190, 400);
            Controls.Add(txtTelefono1);
            txtTelefono1.BringToFront();
        }

        private Guna2HtmlLabel lblMensaje1;
        private void lblMensajeCliente()
        {
            lblMensaje1 = new Guna2HtmlLabel();
            lblMensaje1.Text = "Por favor, ingrese los datos requerido <br> para agregar un nuevo cliente";
            lblMensaje1.TextAlignment = ContentAlignment.TopCenter;
            lblMensaje1.Location = new Point(200, 225);
            lblMensaje1.ForeColor = SystemColors.ControlText;
            lblMensaje1.BackColor = SystemColors.ControlLight;
            lblMensaje1.Font = DefaultFont;
            Controls.Add(lblMensaje1);
            lblMensaje1.BringToFront();
        }

        private Guna2Button btnCerrar1; 
        private void btnCerrarCliente()
        {
            btnCerrar1 = new Guna2Button();
            //btnCerrar1.Text = "Cerrar";
            btnCerrar1.Image = Image.FromFile(@"C:\Users\willi\OneDrive\Escritorio\cloneMelissa\Facturacion-C-\pantallas con diseño moderno\bin\recursos\cerrar.png");
            btnCerrar1.ForeColor = Color.White;
            btnCerrar1.BorderColor = SystemColors.ControlLight;
            btnCerrar1.MouseEnter += (s, e) => 
            { 
                btnCerrar1.BackColor = SystemColors.ControlLight;
                btnCerrar1.ForeColor = SystemColors.ControlLight;
                btnCerrar1.FillColor = SystemColors.ControlLight;
            };
            btnCerrar1.FillColor = SystemColors.ControlLight;
            btnCerrar1.Size = new Size(70,25);
            btnCerrar1.Location = new Point(420,190);
            btnCerrar1.BorderRadius = 10;
            btnCerrar1.BackColor = SystemColors.ControlLight;
            btnCerrar1.Click += new EventHandler(pnlClientesVisible);
            Controls.Add(btnCerrar1);
            btnCerrar1.BringToFront();
        }

        private void pnlClientesVisible(object sender, EventArgs e)
        {
            pnlFieldsClientes.Visible = false;
            btnCerrar1.Visible = false;
            txtNombre1.Visible = false;
            txtDireccion1.Visible = false;
            txtTelefono1.Visible = false;
            lblMensaje1.Visible = false;
            btnAgregar1.Visible = false;
        }

        private Guna2Button btnAgregar1;
        private void btnAgregarCliente()
        {
            btnAgregar1 = new Guna2Button();
            btnAgregar1.Text = "Agregar";
            btnAgregar1.FillColor = Color.Indigo;
            btnAgregar1.BackColor = SystemColors.ControlLight;
            btnAgregar1.ForeColor = Color.White;
            btnAgregar1.Size = new Size(170,40);
            btnAgregar1.BorderRadius = 20;
            btnAgregar1.Location = new Point(240,480);
            btnAgregar1.Click += new EventHandler(crearUsuario);
            btnAgregar1.Click += new EventHandler(pnlClientesVisible);
            Controls.Add(btnAgregar1);
            btnAgregar1.BringToFront();
        }

        private void crearUsuario(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente //Invocamos la clase
            {
                id = index++, //Le decimos que cada vez aumente +1
                nombre = txtNombre1.Text,
                direccion = txtDireccion1.Text,
                telefono = txtTelefono1.Text, //Los datos del usuario los asociamos a los respectivos TextBox
            };

            listadoClientes.Add(cliente); //Le damos la orden al mapa de agregar segun los parametros de la clase Cliente
            ActualizarGrid();
            clearFields(); //Aqui solo borramos los campos despues de agregar
        }

        private void Filtro(object sender, EventArgs e)
        {
            string filtro = txtBuscarCliente.Text.ToLower();
            var clientesFiltrados = listadoClientes
                                    .Where(cliente => cliente.nombre.ToLower().Contains(filtro))
                                    .ToList();
            txtBuscarCliente.Clear();
            DGVclientes.DataSource = null;
            DGVclientes.DataSource = clientesFiltrados;
        }

        private void eliminarUsuarios(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVclientes.Columns["Borrar"].Index && e.RowIndex >= 0)
            {
                int idCliente = (int)DGVclientes.Rows[e.RowIndex].Cells["ID"].Value;

                Cliente clienteAEliminar = listadoClientes.FirstOrDefault(cliente => cliente.id == idCliente);
                if (clienteAEliminar != null)
                {
                    listadoClientes.Remove(clienteAEliminar);
                    ActualizarGrid();
                }
            }
        }
    }
}
