<<<<<<< HEAD
﻿namespace QYMSAS
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(180, 241);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(246, 29);
            this.txt_contraseña.TabIndex = 107;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.txt_contraseña_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Contraseña:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(180, 206);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(246, 29);
            this.txt_usuario.TabIndex = 104;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Usuario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(180, 171);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(246, 29);
            this.txt_apellido.TabIndex = 102;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(180, 136);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(246, 29);
            this.txt_nombre.TabIndex = 100;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ingresar.Location = new System.Drawing.Point(177, 319);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(126, 40);
            this.Bt_Ingresar.TabIndex = 110;
            this.Bt_Ingresar.Text = "Registrar";
            this.Bt_Ingresar.UseVisualStyleBackColor = false;
            this.Bt_Ingresar.Click += new System.EventHandler(this.Bt_Ingresar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QYMSAS.Properties.Resources.en_espera;
            this.pictureBox4.Location = new System.Drawing.Point(265, 368);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 112;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QYMSAS.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(221, 368);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QYMSAS.Properties.Resources.izquierda;
            this.pictureBox2.Location = new System.Drawing.Point(177, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QYMSAS.Properties.Resources.anadir;
            this.pictureBox1.Location = new System.Drawing.Point(197, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(180, 277);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '*';
            this.txt_email.Size = new System.Drawing.Size(246, 29);
            this.txt_email.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "Email:";
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(479, 417);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(495, 456);
            this.MinimumSize = new System.Drawing.Size(495, 456);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
    }
=======
﻿namespace QYMSAS
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(180, 241);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(246, 29);
            this.txt_contraseña.TabIndex = 107;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.txt_contraseña_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Contraseña:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(180, 206);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(246, 29);
            this.txt_usuario.TabIndex = 104;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Usuario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(180, 171);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(246, 29);
            this.txt_apellido.TabIndex = 102;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "Apellido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(180, 136);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(246, 29);
            this.txt_nombre.TabIndex = 100;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ingresar.Location = new System.Drawing.Point(177, 319);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(126, 40);
            this.Bt_Ingresar.TabIndex = 110;
            this.Bt_Ingresar.Text = "Registrar";
            this.Bt_Ingresar.UseVisualStyleBackColor = false;
            this.Bt_Ingresar.Click += new System.EventHandler(this.Bt_Ingresar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QYMSAS.Properties.Resources.en_espera;
            this.pictureBox4.Location = new System.Drawing.Point(265, 368);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 112;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QYMSAS.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(221, 368);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QYMSAS.Properties.Resources.izquierda;
            this.pictureBox2.Location = new System.Drawing.Point(177, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QYMSAS.Properties.Resources.anadir;
            this.pictureBox1.Location = new System.Drawing.Point(197, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(180, 277);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '*';
            this.txt_email.Size = new System.Drawing.Size(246, 29);
            this.txt_email.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "Email:";
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(479, 417);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(495, 456);
            this.MinimumSize = new System.Drawing.Size(495, 456);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
    }
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
}