namespace pantallas_con_diseño_moderno
{
    partial class frmDemo
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            dgvLoad = new Guna.UI2.WinForms.Guna2DataGridView();
            txtDemo1 = new Guna.UI2.WinForms.Guna2TextBox();
            txtDemo2 = new Guna.UI2.WinForms.Guna2TextBox();
            txtDemo3 = new Guna.UI2.WinForms.Guna2TextBox();
            txtDemo4 = new Guna.UI2.WinForms.Guna2TextBox();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLoad).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.CustomizableEdges = customizableEdges1;
            btnAgregar.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar.Font = new Font("Segoe UI", 9F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(592, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAgregar.Size = new Size(196, 47);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar +";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvLoad
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvLoad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoad.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLoad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLoad.ColumnHeadersHeight = 4;
            dgvLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvLoad.Columns.AddRange(new DataGridViewColumn[] { id, nombre, apellido, telefono });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLoad.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLoad.GridColor = Color.FromArgb(231, 229, 255);
            dgvLoad.Location = new Point(92, 118);
            dgvLoad.Name = "dgvLoad";
            dgvLoad.RowHeadersVisible = false;
            dgvLoad.RowHeadersWidth = 51;
            dgvLoad.Size = new Size(615, 269);
            dgvLoad.TabIndex = 2;
            dgvLoad.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvLoad.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvLoad.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvLoad.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvLoad.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvLoad.ThemeStyle.BackColor = SystemColors.Control;
            dgvLoad.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvLoad.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvLoad.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLoad.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvLoad.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvLoad.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvLoad.ThemeStyle.HeaderStyle.Height = 4;
            dgvLoad.ThemeStyle.ReadOnly = false;
            dgvLoad.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvLoad.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLoad.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvLoad.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvLoad.ThemeStyle.RowsStyle.Height = 29;
            dgvLoad.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvLoad.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // txtDemo1
            // 
            txtDemo1.CustomizableEdges = customizableEdges3;
            txtDemo1.DefaultText = "Nombre";
            txtDemo1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDemo1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDemo1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDemo1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDemo1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDemo1.Font = new Font("Segoe UI", 9F);
            txtDemo1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDemo1.Location = new Point(118, 12);
            txtDemo1.Margin = new Padding(3, 4, 3, 4);
            txtDemo1.Name = "txtDemo1";
            txtDemo1.PasswordChar = '\0';
            txtDemo1.PlaceholderText = "";
            txtDemo1.SelectedText = "";
            txtDemo1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtDemo1.Size = new Size(136, 46);
            txtDemo1.TabIndex = 3;
            // 
            // txtDemo2
            // 
            txtDemo2.CustomizableEdges = customizableEdges5;
            txtDemo2.DefaultText = "Apellido";
            txtDemo2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDemo2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDemo2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDemo2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDemo2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDemo2.Font = new Font("Segoe UI", 9F);
            txtDemo2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDemo2.Location = new Point(274, 12);
            txtDemo2.Margin = new Padding(3, 4, 3, 4);
            txtDemo2.Name = "txtDemo2";
            txtDemo2.PasswordChar = '\0';
            txtDemo2.PlaceholderText = "";
            txtDemo2.SelectedText = "";
            txtDemo2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtDemo2.Size = new Size(136, 46);
            txtDemo2.TabIndex = 4;
            // 
            // txtDemo3
            // 
            txtDemo3.CustomizableEdges = customizableEdges7;
            txtDemo3.DefaultText = "Telefono";
            txtDemo3.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDemo3.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDemo3.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDemo3.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDemo3.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDemo3.Font = new Font("Segoe UI", 9F);
            txtDemo3.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDemo3.Location = new Point(426, 12);
            txtDemo3.Margin = new Padding(3, 4, 3, 4);
            txtDemo3.Name = "txtDemo3";
            txtDemo3.PasswordChar = '\0';
            txtDemo3.PlaceholderText = "";
            txtDemo3.SelectedText = "";
            txtDemo3.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtDemo3.Size = new Size(136, 46);
            txtDemo3.TabIndex = 5;
            // 
            // txtDemo4
            // 
            txtDemo4.CustomizableEdges = customizableEdges9;
            txtDemo4.DefaultText = "ID";
            txtDemo4.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDemo4.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDemo4.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDemo4.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDemo4.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDemo4.Font = new Font("Segoe UI", 9F);
            txtDemo4.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDemo4.Location = new Point(25, 13);
            txtDemo4.Margin = new Padding(3, 4, 3, 4);
            txtDemo4.Name = "txtDemo4";
            txtDemo4.PasswordChar = '\0';
            txtDemo4.PlaceholderText = "";
            txtDemo4.SelectedText = "";
            txtDemo4.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtDemo4.Size = new Size(78, 46);
            txtDemo4.TabIndex = 6;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            // 
            // telefono
            // 
            telefono.HeaderText = "telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            // 
            // frmDemo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDemo4);
            Controls.Add(txtDemo3);
            Controls.Add(txtDemo2);
            Controls.Add(txtDemo1);
            Controls.Add(dgvLoad);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDemo";
            Text = "frmDemo";
            ((System.ComponentModel.ISupportInitialize)dgvLoad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLoad;
        private Guna.UI2.WinForms.Guna2TextBox txtDemo1;
        private Guna.UI2.WinForms.Guna2TextBox txtDemo2;
        private Guna.UI2.WinForms.Guna2TextBox txtDemo3;
        private Guna.UI2.WinForms.Guna2TextBox txtDemo4;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn telefono;
    }
}