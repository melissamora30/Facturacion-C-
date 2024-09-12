namespace pantallas_con_diseño_moderno
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BtnBuscarCliente = new Guna.UI2.WinForms.Guna2Button();
            BtnNuevoCliente = new Guna.UI2.WinForms.Guna2Button();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            DGVclientes = new Guna.UI2.WinForms.Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Borrar = new DataGridViewButtonColumn();
            DGVclientesborder = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtBuscarCliente = new Guna.UI2.WinForms.Guna2TextBox();
            pnlAddClienteBorder = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVclientes).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.BorderRadius = 20;
            BtnBuscarCliente.CustomizableEdges = customizableEdges1;
            BtnBuscarCliente.DisabledState.BorderColor = Color.DarkGray;
            BtnBuscarCliente.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnBuscarCliente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnBuscarCliente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnBuscarCliente.FillColor = Color.Indigo;
            BtnBuscarCliente.Font = new Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarCliente.ForeColor = Color.White;
            BtnBuscarCliente.Image = (Image)resources.GetObject("BtnBuscarCliente.Image");
            BtnBuscarCliente.ImageSize = new Size(22, 22);
            BtnBuscarCliente.Location = new Point(900, 180);
            BtnBuscarCliente.Name = "BtnBuscarCliente";
            BtnBuscarCliente.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnBuscarCliente.Size = new Size(121, 40);
            BtnBuscarCliente.TabIndex = 2;
            BtnBuscarCliente.Text = " Buscar";
            BtnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // BtnNuevoCliente
            // 
            BtnNuevoCliente.BorderRadius = 20;
            BtnNuevoCliente.CustomizableEdges = customizableEdges3;
            BtnNuevoCliente.DisabledState.BorderColor = Color.DarkGray;
            BtnNuevoCliente.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnNuevoCliente.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnNuevoCliente.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnNuevoCliente.FillColor = Color.Indigo;
            BtnNuevoCliente.Font = new Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnNuevoCliente.ForeColor = Color.White;
            BtnNuevoCliente.Image = (Image)resources.GetObject("BtnNuevoCliente.Image");
            BtnNuevoCliente.Location = new Point(36, 180);
            BtnNuevoCliente.Name = "BtnNuevoCliente";
            BtnNuevoCliente.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BtnNuevoCliente.Size = new Size(135, 40);
            BtnNuevoCliente.TabIndex = 3;
            BtnNuevoCliente.Text = " Agregar";
            BtnNuevoCliente.Click += BtnNuevoCliente_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges5;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(36, 14);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2PictureBox1.Size = new Size(110, 107);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 5;
            guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(152, 31);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(382, 37);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // DGVclientes
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DGVclientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGVclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGVclientes.ColumnHeadersHeight = 30;
            DGVclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DGVclientes.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Documento, Telefono, Editar, Borrar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGVclientes.DefaultCellStyle = dataGridViewCellStyle3;
            DGVclientes.GridColor = Color.FromArgb(231, 229, 255);
            DGVclientes.Location = new Point(36, 263);
            DGVclientes.Name = "DGVclientes";
            DGVclientes.RowHeadersVisible = false;
            DGVclientes.RowHeadersWidth = 51;
            DGVclientes.Size = new Size(985, 440);
            DGVclientes.TabIndex = 7;
            DGVclientes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DGVclientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            DGVclientes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DGVclientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DGVclientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DGVclientes.ThemeStyle.BackColor = Color.White;
            DGVclientes.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DGVclientes.ThemeStyle.HeaderStyle.BackColor = Color.Indigo;
            DGVclientes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DGVclientes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DGVclientes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DGVclientes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DGVclientes.ThemeStyle.HeaderStyle.Height = 30;
            DGVclientes.ThemeStyle.ReadOnly = false;
            DGVclientes.ThemeStyle.RowsStyle.BackColor = Color.White;
            DGVclientes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGVclientes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DGVclientes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DGVclientes.ThemeStyle.RowsStyle.Height = 29;
            DGVclientes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DGVclientes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Resizable = DataGridViewTriState.True;
            Editar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Borrar
            // 
            Borrar.HeaderText = "Borrar";
            Borrar.MinimumWidth = 6;
            Borrar.Name = "Borrar";
            Borrar.Resizable = DataGridViewTriState.True;
            Borrar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DGVclientesborder
            // 
            DGVclientesborder.BorderRadius = 20;
            DGVclientesborder.TargetControl = DGVclientes;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.BorderRadius = 20;
            txtBuscarCliente.CustomizableEdges = customizableEdges7;
            txtBuscarCliente.DefaultText = "";
            txtBuscarCliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscarCliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscarCliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarCliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarCliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarCliente.Font = new Font("Segoe UI", 9F);
            txtBuscarCliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarCliente.Location = new Point(545, 180);
            txtBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.PasswordChar = '\0';
            txtBuscarCliente.PlaceholderText = "Buscar por cliente";
            txtBuscarCliente.SelectedText = "";
            txtBuscarCliente.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtBuscarCliente.Size = new Size(349, 40);
            txtBuscarCliente.TabIndex = 8;
            // 
            // pnlAddClienteBorder
            // 
            pnlAddClienteBorder.BorderRadius = 80;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1063, 731);
            Controls.Add(txtBuscarCliente);
            Controls.Add(DGVclientes);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2PictureBox1);
            Controls.Add(BtnNuevoCliente);
            Controls.Add(BtnBuscarCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVclientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnBuscarCliente;
        private Guna.UI2.WinForms.Guna2Button BtnNuevoCliente;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView DGVclientes;
        private Guna.UI2.WinForms.Guna2Elipse DGVclientesborder;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCliente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Borrar;
        private Guna.UI2.WinForms.Guna2Elipse pnlAddClienteBorder;
    }
}