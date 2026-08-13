namespace AppNegocio.Vista
{
    partial class formGestionUsuarios
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
            panelSuperior = new Panel();
            iconTitulo = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new Label();
            panelControles = new Panel();
            lblCorreElectronico = new Label();
            txtCorreoElectronico = new TextBox();
            lblConfirmarContrasena = new Label();
            txtConfirmarContrasena = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblNumeroDocumento = new Label();
            txtNumeroDocumento = new TextBox();
            btnCambiarImagen = new FontAwesome.Sharp.IconButton();
            lblSubtitulo = new Label();
            picUsuario = new PictureBox();
            panelCentral = new Panel();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTitulo).BeginInit();
            panelControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSuperior.BackColor = Color.FromArgb(17, 45, 78);
            panelSuperior.Controls.Add(iconTitulo);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(888, 25);
            panelSuperior.TabIndex = 0;
            // 
            // iconTitulo
            // 
            iconTitulo.Anchor = AnchorStyles.Top;
            iconTitulo.BackColor = Color.FromArgb(17, 45, 78);
            iconTitulo.ForeColor = Color.FromArgb(249, 247, 247);
            iconTitulo.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconTitulo.IconColor = Color.FromArgb(249, 247, 247);
            iconTitulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTitulo.Location = new Point(324, -3);
            iconTitulo.Name = "iconTitulo";
            iconTitulo.Size = new Size(32, 32);
            iconTitulo.TabIndex = 1;
            iconTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.Font = new Font("Roboto", 14.25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(44, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 2, 0, 0);
            lblTitulo.Size = new Size(800, 23);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Gestión de Usuarios";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelControles
            // 
            panelControles.AutoSize = true;
            panelControles.BackColor = Color.FromArgb(219, 226, 239);
            panelControles.Controls.Add(lblCorreElectronico);
            panelControles.Controls.Add(txtCorreoElectronico);
            panelControles.Controls.Add(lblConfirmarContrasena);
            panelControles.Controls.Add(txtConfirmarContrasena);
            panelControles.Controls.Add(lblApellido);
            panelControles.Controls.Add(txtApellido);
            panelControles.Controls.Add(lblNombreUsuario);
            panelControles.Controls.Add(txtNombreUsuario);
            panelControles.Controls.Add(lblContrasena);
            panelControles.Controls.Add(txtContrasena);
            panelControles.Controls.Add(lblNombre);
            panelControles.Controls.Add(txtNombre);
            panelControles.Controls.Add(lblNumeroDocumento);
            panelControles.Controls.Add(txtNumeroDocumento);
            panelControles.Controls.Add(btnCambiarImagen);
            panelControles.Controls.Add(lblSubtitulo);
            panelControles.Controls.Add(picUsuario);
            panelControles.Dock = DockStyle.Top;
            panelControles.Location = new Point(0, 0);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(888, 195);
            panelControles.TabIndex = 1;
            // 
            // lblCorreElectronico
            // 
            lblCorreElectronico.AutoSize = true;
            lblCorreElectronico.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreElectronico.Location = new Point(563, 60);
            lblCorreElectronico.Name = "lblCorreElectronico";
            lblCorreElectronico.Size = new Size(105, 14);
            lblCorreElectronico.TabIndex = 16;
            lblCorreElectronico.Text = "Correo electrónico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(565, 75);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(311, 23);
            txtCorreoElectronico.TabIndex = 15;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.AutoSize = true;
            lblConfirmarContrasena.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarContrasena.Location = new Point(346, 154);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(126, 14);
            lblConfirmarContrasena.TabIndex = 14;
            lblConfirmarContrasena.Text = "Confirmar contraseña";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(348, 169);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(189, 23);
            txtConfirmarContrasena.TabIndex = 13;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(344, 106);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 14);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(346, 121);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(189, 23);
            txtApellido.TabIndex = 11;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(346, 60);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(112, 14);
            lblNombreUsuario.TabIndex = 10;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(348, 75);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(189, 23);
            txtNombreUsuario.TabIndex = 9;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasena.Location = new Point(131, 154);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(70, 14);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(133, 169);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(189, 23);
            txtContrasena.TabIndex = 7;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(131, 106);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 14);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(189, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroDocumento.Location = new Point(131, 60);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(117, 14);
            lblNumeroDocumento.TabIndex = 4;
            lblNumeroDocumento.Text = "Número Documento";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(133, 75);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(189, 23);
            txtNumeroDocumento.TabIndex = 3;
            // 
            // btnCambiarImagen
            // 
            btnCambiarImagen.BackColor = Color.White;
            btnCambiarImagen.FlatStyle = FlatStyle.Flat;
            btnCambiarImagen.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiarImagen.IconChar = FontAwesome.Sharp.IconChar.IdCardClip;
            btnCambiarImagen.IconColor = Color.Black;
            btnCambiarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCambiarImagen.IconSize = 35;
            btnCambiarImagen.Location = new Point(12, 150);
            btnCambiarImagen.Name = "btnCambiarImagen";
            btnCambiarImagen.Size = new Size(113, 42);
            btnCambiarImagen.TabIndex = 2;
            btnCambiarImagen.Text = "Cambiar imagen";
            btnCambiarImagen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCambiarImagen.UseVisualStyleBackColor = false;
            btnCambiarImagen.Click += btnCambiarImagen_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Roboto", 12F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(63, 114, 175);
            lblSubtitulo.Location = new Point(130, 31);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(165, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "DATOS DEL USUARIO";
            // 
            // picUsuario
            // 
            picUsuario.Location = new Point(12, 31);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(113, 113);
            picUsuario.TabIndex = 0;
            picUsuario.TabStop = false;
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCentral.BackColor = Color.White;
            panelCentral.Location = new Point(6, 201);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(876, 316);
            panelCentral.TabIndex = 2;
            // 
            // formGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 114, 175);
            ClientSize = new Size(888, 522);
            Controls.Add(panelCentral);
            Controls.Add(panelSuperior);
            Controls.Add(panelControles);
            MinimumSize = new Size(904, 561);
            Name = "formGestionUsuarios";
            Text = "Form1";
            Load += GestionUsuarios_Load;
            Resize += GestionUsuarios_Resize;
            panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconTitulo).EndInit();
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconTitulo;
        private Panel panelControles;
        private PictureBox picUsuario;
        private Label lblSubtitulo;
        private Panel panelCentral;
        private FontAwesome.Sharp.IconButton btnCambiarImagen;
        private Label lblNumeroDocumento;
        private TextBox txtNumeroDocumento;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCorreElectronico;
        private TextBox txtCorreoElectronico;
        private Label lblConfirmarContrasena;
        private TextBox txtConfirmarContrasena;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblContrasena;
        private TextBox txtContrasena;
    }
}
