namespace pantallas_con_diseño_moderno
{
    partial class frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            loginpanel = new Guna.UI2.WinForms.Guna2Panel();
            CheckContraseña = new Guna.UI2.WinForms.Guna2CheckBox();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnIniciar = new Guna.UI2.WinForms.Guna2Button();
            TxtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            TxtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            LblContraseña = new Label();
            LblUsuario = new Label();
            lblTitulo = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            borderpanel = new Guna.UI2.WinForms.Guna2Elipse(components);
            PanelLogo = new Guna.UI2.WinForms.Guna2Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            loginpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginpanel
            // 
            loginpanel.BackColor = Color.White;
            loginpanel.Controls.Add(CheckContraseña);
            loginpanel.Controls.Add(btnCancelar);
            loginpanel.Controls.Add(btnIniciar);
            loginpanel.Controls.Add(TxtContraseña);
            loginpanel.Controls.Add(TxtUsuario);
            loginpanel.Controls.Add(LblContraseña);
            loginpanel.Controls.Add(LblUsuario);
            loginpanel.Controls.Add(lblTitulo);
            loginpanel.Controls.Add(guna2CirclePictureBox1);
            loginpanel.CustomizableEdges = customizableEdges10;
            loginpanel.Location = new Point(185, 97);
            loginpanel.Name = "loginpanel";
            loginpanel.ShadowDecoration.CustomizableEdges = customizableEdges11;
            loginpanel.Size = new Size(450, 444);
            loginpanel.TabIndex = 0;
            
            // 
            // CheckContraseña
            // 
            CheckContraseña.AutoSize = true;
            CheckContraseña.BackColor = Color.White;
            CheckContraseña.CheckedState.BorderColor = Color.Gray;
            CheckContraseña.CheckedState.BorderRadius = 0;
            CheckContraseña.CheckedState.BorderThickness = 0;
            CheckContraseña.CheckedState.FillColor = Color.Gray;
            CheckContraseña.CheckMarkColor = Color.WhiteSmoke;
            CheckContraseña.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckContraseña.Location = new Point(53, 299);
            CheckContraseña.Name = "CheckContraseña";
            CheckContraseña.Size = new Size(166, 21);
            CheckContraseña.TabIndex = 9;
            CheckContraseña.Text = "Mostrar contraseña";
            CheckContraseña.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            CheckContraseña.UncheckedState.BorderRadius = 0;
            CheckContraseña.UncheckedState.BorderThickness = 0;
            CheckContraseña.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            CheckContraseña.UseVisualStyleBackColor = false;
            CheckContraseña.CheckedChanged += CheckContraseña_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BorderRadius = 8;
            btnCancelar.CustomizableEdges = customizableEdges1;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.FillColor = Color.FromArgb(15, 4, 32);
            btnCancelar.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(233, 356);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancelar.Size = new Size(136, 43);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.BorderRadius = 8;
            btnIniciar.CustomizableEdges = customizableEdges3;
            btnIniciar.DisabledState.BorderColor = Color.DarkGray;
            btnIniciar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnIniciar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnIniciar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnIniciar.FillColor = Color.FromArgb(15, 4, 32);
            btnIniciar.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(61, 356);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnIniciar.Size = new Size(136, 43);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "INICIAR";
            btnIniciar.Click += btnIniciar_Click;
            // 
            // TxtContraseña
            // 
            TxtContraseña.BorderColor = Color.Gainsboro;
            TxtContraseña.BorderRadius = 10;
            TxtContraseña.CustomizableEdges = customizableEdges5;
            TxtContraseña.DefaultText = "";
            TxtContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtContraseña.FillColor = Color.WhiteSmoke;
            TxtContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtContraseña.Font = new Font("Segoe UI", 9F);
            TxtContraseña.ForeColor = Color.Black;
            TxtContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtContraseña.Location = new Point(39, 245);
            TxtContraseña.Margin = new Padding(3, 4, 3, 4);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.PlaceholderForeColor = SystemColors.GrayText;
            TxtContraseña.PlaceholderText = "Ingrese la contraseña";
            TxtContraseña.SelectedText = "";
            TxtContraseña.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TxtContraseña.Size = new Size(347, 38);
            TxtContraseña.TabIndex = 6;
            // 
            // TxtUsuario
            // 
            TxtUsuario.BorderColor = Color.Gainsboro;
            TxtUsuario.BorderRadius = 10;
            TxtUsuario.CustomizableEdges = customizableEdges7;
            TxtUsuario.DefaultText = "";
            TxtUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxtUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxtUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxtUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxtUsuario.FillColor = Color.WhiteSmoke;
            TxtUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtUsuario.Font = new Font("Segoe UI", 9F);
            TxtUsuario.ForeColor = Color.Black;
            TxtUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxtUsuario.Location = new Point(39, 157);
            TxtUsuario.Margin = new Padding(3, 4, 3, 4);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.PasswordChar = '\0';
            TxtUsuario.PlaceholderForeColor = SystemColors.GrayText;
            TxtUsuario.PlaceholderText = "Ingrese el usuario";
            TxtUsuario.SelectedText = "";
            TxtUsuario.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TxtUsuario.Size = new Size(347, 38);
            TxtUsuario.TabIndex = 5;
            // 
            // LblContraseña
            // 
            LblContraseña.AutoSize = true;
            LblContraseña.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblContraseña.Location = new Point(39, 209);
            LblContraseña.Name = "LblContraseña";
            LblContraseña.Size = new Size(104, 21);
            LblContraseña.TabIndex = 4;
            LblContraseña.Text = "Contraseña";
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsuario.Location = new Point(39, 132);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(73, 21);
            LblUsuario.TabIndex = 3;
            LblUsuario.Text = "Usuario";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(131, 78);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(174, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "INICIAR SESIÓN";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.FromArgb(0, 0, 0, 6);
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(183, -52);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(0, 0);
            guna2CirclePictureBox1.TabIndex = 2;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // borderpanel
            // 
            borderpanel.BorderRadius = 40;
            borderpanel.TargetControl = loginpanel;
            // 
            // PanelLogo
            // 
            PanelLogo.BackgroundImage = (Image)resources.GetObject("PanelLogo.BackgroundImage");
            PanelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            PanelLogo.CustomizableEdges = customizableEdges12;
            PanelLogo.Location = new Point(340, 30);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.ShadowDecoration.CustomizableEdges = customizableEdges13;
            PanelLogo.Size = new Size(125, 125);
            PanelLogo.TabIndex = 9;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 1000;
            guna2Elipse1.TargetControl = PanelLogo;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(847, 604);
            ControlBox = false;
            Controls.Add(PanelLogo);
            Controls.Add(loginpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel loginpanel;
        private Guna.UI2.WinForms.Guna2Elipse borderpanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox TxtUsuario;
        private Label LblContraseña;
        private Label LblUsuario;
        private Guna.UI2.WinForms.Guna2TextBox TxtContraseña;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnIniciar;
        private Guna.UI2.WinForms.Guna2Panel PanelLogo;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CheckBox CheckContraseña;
    }
}
