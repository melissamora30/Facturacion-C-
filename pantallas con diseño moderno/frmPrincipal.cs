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
    public partial class frmPrincipal : Form
    {
        private FrmClientes FrmClientes;
        private frmDemo frmDemo;

        public frmPrincipal()
        {
            InitializeComponent();
            InitializeScreens();


            //BtnTablas.ContextMenuStrip = SubOpcTablas;

            //// Si el ContextMenuStrip no se ha añadido a BtnTablas, puedes mostrarlo manualmente
            ////BtnTablas.Click += (s, e) =>
            ////{
            ////    // Mostrar el ContextMenuStrip justo debajo del botón
            ////    SubOpcTablas.Show(BtnTablas, new Point(0, BtnTablas.Height));
            ////};

            ////ContextMenuStrip de Opción facturación
            //BtnFacturacion.ContextMenuStrip = SubOpcFacturacion;


            //BtnFacturacion.Click += (s, e) =>
            //{

            //    SubOpcFacturacion.Show(BtnFacturacion, new Point(0, BtnFacturacion.Height));
            //};

            ////ContextMenuStrip de Opción seguridad
            //BtnSeguridad.ContextMenuStrip = SubOpcSeguridad;


            //BtnSeguridad.Click += (s, e) =>
            //{

            //    SubOpcSeguridad.Show(BtnSeguridad, new Point(0, BtnSeguridad.Height));
            //};

            ////ContextMenuStrip de Opción Acerca De
            //BtnAcercaDe.ContextMenuStrip = SubOpcAcercaDe;


            //BtnAcercaDe.Click += (s, e) =>
            //{

            //    SubOpcAcercaDe.Show(BtnAcercaDe, new Point(0, BtnAcercaDe.Height));
            //};

        }

        private void InitializeScreens()
        {
            FrmClientes = new FrmClientes();
            frmDemo = new frmDemo();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierra la aplicación
        }
        public void pnlContainer(object _container)
        {
            this.pnlContenedor.Controls.Clear();
            Form? P = _container as Form;
            P.TopLevel = false;
            P.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(P);
            this.pnlContenedor.Tag = P;
            P.Show();
        }

        //public void clientesToolStripMenuItem_Click(object sender)
        //{
        //    PnlContenedor.Controls.Clear();
        //    Form formulario = _clientesToolStripMenuItem_Click as Form();
        //    formulario.TopLevel = false;
        //    formulario.Dock = DockStyle.Fill;
        //    this.PnlContenedor.Controls.Add(formulario);
        //    this.PnlContenedor.Tag = formulario;
        //    formulario.Show();
        //}
        public void BtnTablas_Click(object sender, EventArgs e)
        {
            pnlContainer(FrmClientes);
        }
    }
}



