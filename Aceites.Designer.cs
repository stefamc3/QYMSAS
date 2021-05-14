<<<<<<< HEAD
﻿namespace QYMSAS
{
    partial class Aceites
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aceites));
            this.label7 = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_descripcionf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbid_maquina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.busAce = new System.Windows.Forms.TextBox();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.exportar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 115;
            this.label7.Text = "Fecha: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Location = new System.Drawing.Point(488, 156);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(305, 26);
            this.dt_fecha.TabIndex = 1;
            // 
            // txt_descripcionf
            // 
            this.txt_descripcionf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descripcionf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionf.Location = new System.Drawing.Point(488, 199);
            this.txt_descripcionf.Name = "txt_descripcionf";
            this.txt_descripcionf.Size = new System.Drawing.Size(305, 26);
            this.txt_descripcionf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "Descripción: ";
            // 
            // txt_valor
            // 
            this.txt_valor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(123, 200);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(247, 26);
            this.txt_valor.TabIndex = 2;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solonumeros);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 120;
            this.label10.Text = "Valor: ";
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ingresar.Location = new System.Drawing.Point(243, 284);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(98, 36);
            this.Bt_Ingresar.TabIndex = 4;
            this.Bt_Ingresar.Text = "Ingresar";
            this.Bt_Ingresar.UseVisualStyleBackColor = false;
            this.Bt_Ingresar.Click += new System.EventHandler(this.Bt_Ingresar_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nuevo.Location = new System.Drawing.Point(139, 284);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(98, 36);
            this.bt_nuevo.TabIndex = 8;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseVisualStyleBackColor = false;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(451, 284);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(105, 36);
            this.btn_modificar.TabIndex = 122;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 124;
            this.label1.Text = "Id Maquina: ";
            // 
            // Cbid_maquina
            // 
            this.Cbid_maquina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbid_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbid_maquina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cbid_maquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbid_maquina.FormattingEnabled = true;
            this.Cbid_maquina.Items.AddRange(new object[] {
            "1- Retro 2",
            "2- Retro 3",
            "3- Retro 4",
            "4- Retro 6",
            "5- Foton 1",
            "6- Foton 2",
            "7- SZN-114",
            "8- Tuneleadora",
            "9- Molino"});
            this.Cbid_maquina.Location = new System.Drawing.Point(123, 156);
            this.Cbid_maquina.Name = "Cbid_maquina";
            this.Cbid_maquina.Size = new System.Drawing.Size(247, 28);
            this.Cbid_maquina.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 128;
            this.label3.Text = "Buscar:";
            // 
            // busAce
            // 
            this.busAce.Location = new System.Drawing.Point(183, 325);
            this.busAce.Name = "busAce";
            this.busAce.Size = new System.Drawing.Size(498, 20);
            this.busAce.TabIndex = 127;
            this.busAce.TextChanged += new System.EventHandler(this.busAce_TextChanged);
            // 
            // dg_consulta
            // 
            this.dg_consulta.AllowUserToAddRows = false;
            this.dg_consulta.AllowUserToDeleteRows = false;
            this.dg_consulta.AllowUserToOrderColumns = true;
            this.dg_consulta.AllowUserToResizeColumns = false;
            this.dg_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_consulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dg_consulta.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_consulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_consulta.EnableHeadersVisualStyles = false;
            this.dg_consulta.Location = new System.Drawing.Point(39, 356);
            this.dg_consulta.Name = "dg_consulta";
            this.dg_consulta.ReadOnly = true;
            this.dg_consulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_consulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_consulta.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_consulta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_consulta.Size = new System.Drawing.Size(721, 287);
            this.dg_consulta.TabIndex = 126;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(347, 284);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(98, 36);
            this.bt_eliminar.TabIndex = 129;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportar.Location = new System.Drawing.Point(562, 284);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(107, 36);
            this.exportar.TabIndex = 214;
            this.exportar.Text = "Exportar";
            this.exportar.UseVisualStyleBackColor = false;
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QYMSAS.Properties.Resources.salida1;
            this.pictureBox3.Location = new System.Drawing.Point(405, 649);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 121;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QYMSAS.Properties.Resources.aceites;
            this.pictureBox1.Location = new System.Drawing.Point(335, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QYMSAS.Properties.Resources.menu__1_;
            this.pictureBox2.Location = new System.Drawing.Point(361, 649);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Aceites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(803, 698);
            this.Controls.Add(this.exportar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.busAce);
            this.Controls.Add(this.dg_consulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbid_maquina);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descripcionf);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(819, 737);
            this.MinimumSize = new System.Drawing.Size(819, 726);
            this.Name = "Aceites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aceites y Filtros";
            this.Load += new System.EventHandler(this.Aceites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.TextBox txt_descripcionf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbid_maquina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox busAce;
        public System.Windows.Forms.DataGridView dg_consulta;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button exportar;
    }
=======
﻿namespace QYMSAS
{
    partial class Aceites
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aceites));
            this.label7 = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_descripcionf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbid_maquina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.busAce = new System.Windows.Forms.TextBox();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.exportar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 115;
            this.label7.Text = "Fecha: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Location = new System.Drawing.Point(488, 156);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(305, 26);
            this.dt_fecha.TabIndex = 1;
            // 
            // txt_descripcionf
            // 
            this.txt_descripcionf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descripcionf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionf.Location = new System.Drawing.Point(488, 199);
            this.txt_descripcionf.Name = "txt_descripcionf";
            this.txt_descripcionf.Size = new System.Drawing.Size(305, 26);
            this.txt_descripcionf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "Descripción: ";
            // 
            // txt_valor
            // 
            this.txt_valor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(123, 200);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(247, 26);
            this.txt_valor.TabIndex = 2;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            this.txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solonumeros);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 120;
            this.label10.Text = "Valor: ";
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ingresar.Location = new System.Drawing.Point(243, 284);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(98, 36);
            this.Bt_Ingresar.TabIndex = 4;
            this.Bt_Ingresar.Text = "Ingresar";
            this.Bt_Ingresar.UseVisualStyleBackColor = false;
            this.Bt_Ingresar.Click += new System.EventHandler(this.Bt_Ingresar_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nuevo.Location = new System.Drawing.Point(139, 284);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(98, 36);
            this.bt_nuevo.TabIndex = 8;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseVisualStyleBackColor = false;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(451, 284);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(105, 36);
            this.btn_modificar.TabIndex = 122;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 124;
            this.label1.Text = "Id Maquina: ";
            // 
            // Cbid_maquina
            // 
            this.Cbid_maquina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cbid_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbid_maquina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cbid_maquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbid_maquina.FormattingEnabled = true;
            this.Cbid_maquina.Items.AddRange(new object[] {
            "1- Retro 2",
            "2- Retro 3",
            "3- Retro 4",
            "4- Retro 6",
            "5- Foton 1",
            "6- Foton 2",
            "7- SZN-114",
            "8- Tuneleadora",
            "9- Molino"});
            this.Cbid_maquina.Location = new System.Drawing.Point(123, 156);
            this.Cbid_maquina.Name = "Cbid_maquina";
            this.Cbid_maquina.Size = new System.Drawing.Size(247, 28);
            this.Cbid_maquina.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 128;
            this.label3.Text = "Buscar:";
            // 
            // busAce
            // 
            this.busAce.Location = new System.Drawing.Point(183, 325);
            this.busAce.Name = "busAce";
            this.busAce.Size = new System.Drawing.Size(498, 20);
            this.busAce.TabIndex = 127;
            this.busAce.TextChanged += new System.EventHandler(this.busAce_TextChanged);
            // 
            // dg_consulta
            // 
            this.dg_consulta.AllowUserToAddRows = false;
            this.dg_consulta.AllowUserToDeleteRows = false;
            this.dg_consulta.AllowUserToOrderColumns = true;
            this.dg_consulta.AllowUserToResizeColumns = false;
            this.dg_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_consulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dg_consulta.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dg_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_consulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_consulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_consulta.EnableHeadersVisualStyles = false;
            this.dg_consulta.Location = new System.Drawing.Point(39, 356);
            this.dg_consulta.Name = "dg_consulta";
            this.dg_consulta.ReadOnly = true;
            this.dg_consulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_consulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_consulta.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_consulta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_consulta.Size = new System.Drawing.Size(721, 287);
            this.dg_consulta.TabIndex = 126;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(347, 284);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(98, 36);
            this.bt_eliminar.TabIndex = 129;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportar.Location = new System.Drawing.Point(562, 284);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(107, 36);
            this.exportar.TabIndex = 214;
            this.exportar.Text = "Exportar";
            this.exportar.UseVisualStyleBackColor = false;
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QYMSAS.Properties.Resources.salida1;
            this.pictureBox3.Location = new System.Drawing.Point(405, 649);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 121;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QYMSAS.Properties.Resources.aceites;
            this.pictureBox1.Location = new System.Drawing.Point(335, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QYMSAS.Properties.Resources.menu__1_;
            this.pictureBox2.Location = new System.Drawing.Point(361, 649);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Aceites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(803, 698);
            this.Controls.Add(this.exportar);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.busAce);
            this.Controls.Add(this.dg_consulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbid_maquina);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descripcionf);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(819, 737);
            this.MinimumSize = new System.Drawing.Size(819, 726);
            this.Name = "Aceites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aceites y Filtros";
            this.Load += new System.EventHandler(this.Aceites_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.TextBox txt_descripcionf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbid_maquina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox busAce;
        public System.Windows.Forms.DataGridView dg_consulta;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button exportar;
    }
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
}