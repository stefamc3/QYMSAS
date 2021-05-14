<<<<<<< HEAD
﻿namespace QYMSAS
{
    partial class C_Egreso_Recebera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_Egreso_Recebera));
            this.exportar = new System.Windows.Forms.Button();
            this.busCom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_señor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txtNumF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportar.Location = new System.Drawing.Point(552, 273);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(107, 36);
            this.exportar.TabIndex = 232;
            this.exportar.Text = "Exportar";
            this.exportar.UseVisualStyleBackColor = false;
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            // 
            // busCom
            // 
            this.busCom.Location = new System.Drawing.Point(174, 315);
            this.busCom.Name = "busCom";
            this.busCom.Size = new System.Drawing.Size(498, 20);
            this.busCom.TabIndex = 231;
            this.busCom.TextChanged += new System.EventHandler(this.busCom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 230;
            this.label2.Text = "Buscar:";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(335, 273);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(98, 36);
            this.bt_eliminar.TabIndex = 228;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(439, 273);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(107, 36);
            this.btn_modificar.TabIndex = 227;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QYMSAS.Properties.Resources.en_espera;
            this.pictureBox3.Location = new System.Drawing.Point(402, 646);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 224;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nuevo.Location = new System.Drawing.Point(127, 273);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(98, 36);
            this.bt_nuevo.TabIndex = 219;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseVisualStyleBackColor = false;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ingresar.Location = new System.Drawing.Point(231, 273);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(98, 36);
            this.Bt_Ingresar.TabIndex = 218;
            this.Bt_Ingresar.Text = "Ingresar";
            this.Bt_Ingresar.UseVisualStyleBackColor = false;
            this.Bt_Ingresar.Click += new System.EventHandler(this.Bt_Ingresar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(422, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 223;
            this.label10.Text = "Valor: ";
            // 
            // txt_valor
            // 
            this.txt_valor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(516, 209);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(243, 26);
            this.txt_valor.TabIndex = 217;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Location = new System.Drawing.Point(275, 113);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(305, 26);
            this.dt_fecha.TabIndex = 216;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 222;
            this.label7.Text = "Fecha: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QYMSAS.Properties.Resources.cuenta;
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 221;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QYMSAS.Properties.Resources.menu;
            this.pictureBox2.Location = new System.Drawing.Point(358, 646);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 220;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(549, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(236, 18);
            this.label19.TabIndex = 374;
            this.label19.Text = "COMPROBNTE DE EGRESO ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(330, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 90);
            this.label16.TabIndex = 372;
            this.label16.Text = "Q Y M S.A.S. \r\nNIT 900.058.021 - 1\r\nSutatausa Colombia \r\nTel: 8552419\r\nqym.sas@ho" +
    "tmail.com";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(580, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 18);
            this.label13.TabIndex = 371;
            this.label13.Text = "N°: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 376;
            this.label1.Text = "Señor: ";
            // 
            // txt_señor
            // 
            this.txt_señor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_señor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_señor.Location = new System.Drawing.Point(127, 145);
            this.txt_señor.Name = "txt_señor";
            this.txt_señor.Size = new System.Drawing.Size(289, 26);
            this.txt_señor.TabIndex = 375;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 378;
            this.label3.Text = "Dirección";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(127, 176);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(289, 26);
            this.txt_direccion.TabIndex = 377;
            // 
            // txtNumF
            // 
            this.txtNumF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumF.Location = new System.Drawing.Point(623, 73);
            this.txtNumF.Name = "txtNumF";
            this.txtNumF.Size = new System.Drawing.Size(145, 26);
            this.txtNumF.TabIndex = 379;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 381;
            this.label4.Text = "Teléfono: ";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(516, 145);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(243, 26);
            this.txt_telefono.TabIndex = 380;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 383;
            this.label5.Text = "Ciudad: ";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad.Location = new System.Drawing.Point(516, 177);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(243, 26);
            this.txt_ciudad.TabIndex = 382;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 385;
            this.label6.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(127, 209);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(289, 26);
            this.txt_descripcion.TabIndex = 384;
            // 
            // cbtipo
            // 
            this.cbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "ACOPIO",
            "RECEBERA"});
            this.cbtipo.Location = new System.Drawing.Point(127, 241);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(289, 28);
            this.cbtipo.TabIndex = 402;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 18);
            this.label20.TabIndex = 401;
            this.label20.Text = "Tipo:";
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
            this.dg_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_consulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dg_consulta.Location = new System.Drawing.Point(29, 341);
            this.dg_consulta.Name = "dg_consulta";
            this.dg_consulta.ReadOnly = true;
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
            this.dg_consulta.Size = new System.Drawing.Size(730, 295);
            this.dg_consulta.TabIndex = 403;
            // 
            // C_Egreso_Recebera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(803, 687);
            this.Controls.Add(this.dg_consulta);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txtNumF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_señor);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.exportar);
            this.Controls.Add(this.busCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(819, 737);
            this.MinimumSize = new System.Drawing.Size(819, 726);
            this.Name = "C_Egreso_Recebera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante de Egreso Recebera";
            this.Load += new System.EventHandler(this.C_Egreso_Recebera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportar;
        private System.Windows.Forms.TextBox busCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_señor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txtNumF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.DataGridView dg_consulta;
    }
=======
﻿namespace QYMSAS
{
    partial class C_Egreso_Recebera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_Egreso_Recebera));
            this.exportar = new System.Windows.Forms.Button();
            this.busCom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_señor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txtNumF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportar.Location = new System.Drawing.Point(552, 273);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(107, 36);
            this.exportar.TabIndex = 232;
            this.exportar.Text = "Exportar";
            this.exportar.UseVisualStyleBackColor = false;
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            // 
            // busCom
            // 
            this.busCom.Location = new System.Drawing.Point(174, 315);
            this.busCom.Name = "busCom";
            this.busCom.Size = new System.Drawing.Size(498, 20);
            this.busCom.TabIndex = 231;
            this.busCom.TextChanged += new System.EventHandler(this.busCom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 230;
            this.label2.Text = "Buscar:";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(335, 273);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(98, 36);
            this.bt_eliminar.TabIndex = 228;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(439, 273);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(107, 36);
            this.btn_modificar.TabIndex = 227;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QYMSAS.Properties.Resources.en_espera;
            this.pictureBox3.Location = new System.Drawing.Point(402, 646);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 224;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nuevo.Location = new System.Drawing.Point(127, 273);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(98, 36);
            this.bt_nuevo.TabIndex = 219;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseVisualStyleBackColor = false;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ingresar.Location = new System.Drawing.Point(231, 273);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(98, 36);
            this.Bt_Ingresar.TabIndex = 218;
            this.Bt_Ingresar.Text = "Ingresar";
            this.Bt_Ingresar.UseVisualStyleBackColor = false;
            this.Bt_Ingresar.Click += new System.EventHandler(this.Bt_Ingresar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(422, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 223;
            this.label10.Text = "Valor: ";
            // 
            // txt_valor
            // 
            this.txt_valor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(516, 209);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(243, 26);
            this.txt_valor.TabIndex = 217;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Location = new System.Drawing.Point(275, 113);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(305, 26);
            this.dt_fecha.TabIndex = 216;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 222;
            this.label7.Text = "Fecha: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QYMSAS.Properties.Resources.cuenta;
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 221;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QYMSAS.Properties.Resources.menu;
            this.pictureBox2.Location = new System.Drawing.Point(358, 646);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 220;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(549, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(236, 18);
            this.label19.TabIndex = 374;
            this.label19.Text = "COMPROBNTE DE EGRESO ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(330, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 90);
            this.label16.TabIndex = 372;
            this.label16.Text = "Q Y M S.A.S. \r\nNIT 900.058.021 - 1\r\nSutatausa Colombia \r\nTel: 8552419\r\nqym.sas@ho" +
    "tmail.com";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(580, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 18);
            this.label13.TabIndex = 371;
            this.label13.Text = "N°: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 376;
            this.label1.Text = "Señor: ";
            // 
            // txt_señor
            // 
            this.txt_señor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_señor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_señor.Location = new System.Drawing.Point(127, 145);
            this.txt_señor.Name = "txt_señor";
            this.txt_señor.Size = new System.Drawing.Size(289, 26);
            this.txt_señor.TabIndex = 375;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 378;
            this.label3.Text = "Dirección";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(127, 176);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(289, 26);
            this.txt_direccion.TabIndex = 377;
            // 
            // txtNumF
            // 
            this.txtNumF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumF.Location = new System.Drawing.Point(623, 73);
            this.txtNumF.Name = "txtNumF";
            this.txtNumF.Size = new System.Drawing.Size(145, 26);
            this.txtNumF.TabIndex = 379;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 381;
            this.label4.Text = "Teléfono: ";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(516, 145);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(243, 26);
            this.txt_telefono.TabIndex = 380;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 383;
            this.label5.Text = "Ciudad: ";
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad.Location = new System.Drawing.Point(516, 177);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(243, 26);
            this.txt_ciudad.TabIndex = 382;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 385;
            this.label6.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(127, 209);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(289, 26);
            this.txt_descripcion.TabIndex = 384;
            // 
            // cbtipo
            // 
            this.cbtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "ACOPIO",
            "RECEBERA"});
            this.cbtipo.Location = new System.Drawing.Point(127, 241);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(289, 28);
            this.cbtipo.TabIndex = 402;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(25, 245);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 18);
            this.label20.TabIndex = 401;
            this.label20.Text = "Tipo:";
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
            this.dg_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_consulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dg_consulta.Location = new System.Drawing.Point(29, 341);
            this.dg_consulta.Name = "dg_consulta";
            this.dg_consulta.ReadOnly = true;
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
            this.dg_consulta.Size = new System.Drawing.Size(730, 295);
            this.dg_consulta.TabIndex = 403;
            // 
            // C_Egreso_Recebera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(803, 687);
            this.Controls.Add(this.dg_consulta);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txtNumF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_señor);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.exportar);
            this.Controls.Add(this.busCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(819, 737);
            this.MinimumSize = new System.Drawing.Size(819, 726);
            this.Name = "C_Egreso_Recebera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante de Egreso Recebera";
            this.Load += new System.EventHandler(this.C_Egreso_Recebera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportar;
        private System.Windows.Forms.TextBox busCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_señor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txtNumF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.DataGridView dg_consulta;
    }
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
}