<<<<<<< HEAD
﻿namespace QYMSAS
{
    partial class Remisiones1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remisiones1));
            this.textEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.busRe = new System.Windows.Forms.TextBox();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaterialr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtremision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdestinor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_rvalor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmetrosr = new System.Windows.Forms.TextBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textEstado
            // 
            this.textEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "PAGO",
            "CREDITO"});
            this.textEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstado.FormattingEnabled = true;
            this.textEstado.Items.AddRange(new object[] {
            "PAGO",
            "CREDITO"});
            this.textEstado.Location = new System.Drawing.Point(534, 281);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(171, 28);
            this.textEstado.TabIndex = 212;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 211;
            this.label8.Text = "Buscar:";
            // 
            // busRe
            // 
            this.busRe.Location = new System.Drawing.Point(155, 372);
            this.busRe.Name = "busRe";
            this.busRe.Size = new System.Drawing.Size(498, 20);
            this.busRe.TabIndex = 210;
            this.busRe.TextChanged += new System.EventHandler(this.busRe_TextChanged);
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
            this.dg_consulta.Location = new System.Drawing.Point(20, 403);
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
            this.dg_consulta.Size = new System.Drawing.Size(717, 241);
            this.dg_consulta.TabIndex = 209;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 208;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(335, 330);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(98, 36);
            this.bt_eliminar.TabIndex = 207;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 206;
            this.label6.Text = "Estado:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QYMSAS.Properties.Resources.en_espera;
            this.pictureBox3.Location = new System.Drawing.Point(380, 650);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 205;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 204;
            this.label5.Text = "Material:";
            // 
            // txtmaterialr
            // 
            this.txtmaterialr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmaterialr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterialr.Location = new System.Drawing.Point(122, 192);
            this.txtmaterialr.Name = "txtmaterialr";
            this.txtmaterialr.Size = new System.Drawing.Size(305, 26);
            this.txtmaterialr.TabIndex = 203;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 202;
            this.label4.Text = "Remision:";
            // 
            // txtremision
            // 
            this.txtremision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtremision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremision.Location = new System.Drawing.Point(534, 146);
            this.txtremision.Name = "txtremision";
            this.txtremision.Size = new System.Drawing.Size(171, 26);
            this.txtremision.TabIndex = 201;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 200;
            this.label3.Text = "Destino:";
            // 
            // txtdestinor
            // 
            this.txtdestinor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdestinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestinor.Location = new System.Drawing.Point(122, 239);
            this.txtdestinor.Name = "txtdestinor";
            this.txtdestinor.Size = new System.Drawing.Size(305, 26);
            this.txtdestinor.TabIndex = 199;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 198;
            this.label1.Text = "Placa:";
            // 
            // txtplaca
            // 
            this.txtplaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(534, 191);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(171, 26);
            this.txtplaca.TabIndex = 197;
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nuevo.Location = new System.Drawing.Point(127, 330);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(98, 36);
            this.bt_nuevo.TabIndex = 191;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseVisualStyleBackColor = false;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ingresar.Location = new System.Drawing.Point(231, 330);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(98, 36);
            this.Bt_Ingresar.TabIndex = 190;
            this.Bt_Ingresar.Text = "Ingresar";
            this.Bt_Ingresar.UseVisualStyleBackColor = false;
            this.Bt_Ingresar.Click += new System.EventHandler(this.Bt_Ingresar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 196;
            this.label10.Text = "Valor:";
            // 
            // txt_rvalor
            // 
            this.txt_rvalor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_rvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rvalor.Location = new System.Drawing.Point(122, 282);
            this.txt_rvalor.Name = "txt_rvalor";
            this.txt_rvalor.Size = new System.Drawing.Size(305, 26);
            this.txt_rvalor.TabIndex = 188;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 195;
            this.label2.Text = "Metros:";
            // 
            // txtmetrosr
            // 
            this.txtmetrosr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmetrosr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetrosr.Location = new System.Drawing.Point(534, 241);
            this.txtmetrosr.Name = "txtmetrosr";
            this.txtmetrosr.Size = new System.Drawing.Size(171, 26);
            this.txtmetrosr.TabIndex = 189;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Location = new System.Drawing.Point(122, 146);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(305, 26);
            this.dt_fecha.TabIndex = 187;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 194;
            this.label7.Text = "Fecha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QYMSAS.Properties.Resources.factura;
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 193;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QYMSAS.Properties.Resources.menu;
            this.pictureBox2.Location = new System.Drawing.Point(336, 650);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 192;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportar.Location = new System.Drawing.Point(552, 330);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(107, 36);
            this.exportar.TabIndex = 213;
            this.exportar.Text = "Exportar";
            this.exportar.UseVisualStyleBackColor = false;
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            // 
            // Remisiones1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(757, 698);
            this.Controls.Add(this.exportar);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.busRe);
            this.Controls.Add(this.dg_consulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmaterialr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtremision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdestinor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_rvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmetrosr);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(773, 737);
            this.MinimumSize = new System.Drawing.Size(773, 726);
            this.Name = "Remisiones1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remisiones";
            this.Load += new System.EventHandler(this.Remisiones1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox textEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox busRe;
        public System.Windows.Forms.DataGridView dg_consulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaterialr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtremision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdestinor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_rvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmetrosr;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exportar;
    }
=======
﻿namespace QYMSAS
{
    partial class Remisiones1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remisiones1));
            this.textEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.busRe = new System.Windows.Forms.TextBox();
            this.dg_consulta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaterialr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtremision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdestinor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.bt_nuevo = new System.Windows.Forms.Button();
            this.Bt_Ingresar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_rvalor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmetrosr = new System.Windows.Forms.TextBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textEstado
            // 
            this.textEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "PAGO",
            "CREDITO"});
            this.textEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEstado.FormattingEnabled = true;
            this.textEstado.Items.AddRange(new object[] {
            "PAGO",
            "CREDITO"});
            this.textEstado.Location = new System.Drawing.Point(534, 281);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(171, 28);
            this.textEstado.TabIndex = 212;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 211;
            this.label8.Text = "Buscar:";
            // 
            // busRe
            // 
            this.busRe.Location = new System.Drawing.Point(155, 372);
            this.busRe.Name = "busRe";
            this.busRe.Size = new System.Drawing.Size(498, 20);
            this.busRe.TabIndex = 210;
            this.busRe.TextChanged += new System.EventHandler(this.busRe_TextChanged);
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
            this.dg_consulta.Location = new System.Drawing.Point(20, 403);
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
            this.dg_consulta.Size = new System.Drawing.Size(717, 241);
            this.dg_consulta.TabIndex = 209;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 208;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.Location = new System.Drawing.Point(335, 330);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(98, 36);
            this.bt_eliminar.TabIndex = 207;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 206;
            this.label6.Text = "Estado:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QYMSAS.Properties.Resources.en_espera;
            this.pictureBox3.Location = new System.Drawing.Point(380, 650);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 205;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 204;
            this.label5.Text = "Material:";
            // 
            // txtmaterialr
            // 
            this.txtmaterialr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmaterialr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterialr.Location = new System.Drawing.Point(122, 192);
            this.txtmaterialr.Name = "txtmaterialr";
            this.txtmaterialr.Size = new System.Drawing.Size(305, 26);
            this.txtmaterialr.TabIndex = 203;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 202;
            this.label4.Text = "Remision:";
            // 
            // txtremision
            // 
            this.txtremision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtremision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremision.Location = new System.Drawing.Point(534, 146);
            this.txtremision.Name = "txtremision";
            this.txtremision.Size = new System.Drawing.Size(171, 26);
            this.txtremision.TabIndex = 201;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 200;
            this.label3.Text = "Destino:";
            // 
            // txtdestinor
            // 
            this.txtdestinor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdestinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestinor.Location = new System.Drawing.Point(122, 239);
            this.txtdestinor.Name = "txtdestinor";
            this.txtdestinor.Size = new System.Drawing.Size(305, 26);
            this.txtdestinor.TabIndex = 199;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 198;
            this.label1.Text = "Placa:";
            // 
            // txtplaca
            // 
            this.txtplaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(534, 191);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(171, 26);
            this.txtplaca.TabIndex = 197;
            // 
            // bt_nuevo
            // 
            this.bt_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nuevo.Location = new System.Drawing.Point(127, 330);
            this.bt_nuevo.Name = "bt_nuevo";
            this.bt_nuevo.Size = new System.Drawing.Size(98, 36);
            this.bt_nuevo.TabIndex = 191;
            this.bt_nuevo.Text = "Nuevo";
            this.bt_nuevo.UseVisualStyleBackColor = false;
            this.bt_nuevo.Click += new System.EventHandler(this.bt_nuevo_Click);
            // 
            // Bt_Ingresar
            // 
            this.Bt_Ingresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Bt_Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Ingresar.Location = new System.Drawing.Point(231, 330);
            this.Bt_Ingresar.Name = "Bt_Ingresar";
            this.Bt_Ingresar.Size = new System.Drawing.Size(98, 36);
            this.Bt_Ingresar.TabIndex = 190;
            this.Bt_Ingresar.Text = "Ingresar";
            this.Bt_Ingresar.UseVisualStyleBackColor = false;
            this.Bt_Ingresar.Click += new System.EventHandler(this.Bt_Ingresar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 196;
            this.label10.Text = "Valor:";
            // 
            // txt_rvalor
            // 
            this.txt_rvalor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_rvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rvalor.Location = new System.Drawing.Point(122, 282);
            this.txt_rvalor.Name = "txt_rvalor";
            this.txt_rvalor.Size = new System.Drawing.Size(305, 26);
            this.txt_rvalor.TabIndex = 188;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 195;
            this.label2.Text = "Metros:";
            // 
            // txtmetrosr
            // 
            this.txtmetrosr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmetrosr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmetrosr.Location = new System.Drawing.Point(534, 241);
            this.txtmetrosr.Name = "txtmetrosr";
            this.txtmetrosr.Size = new System.Drawing.Size(171, 26);
            this.txtmetrosr.TabIndex = 189;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fecha.Location = new System.Drawing.Point(122, 146);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(305, 26);
            this.dt_fecha.TabIndex = 187;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 194;
            this.label7.Text = "Fecha:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QYMSAS.Properties.Resources.factura;
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 193;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QYMSAS.Properties.Resources.menu;
            this.pictureBox2.Location = new System.Drawing.Point(336, 650);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 192;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // exportar
            // 
            this.exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportar.Location = new System.Drawing.Point(552, 330);
            this.exportar.Name = "exportar";
            this.exportar.Size = new System.Drawing.Size(107, 36);
            this.exportar.TabIndex = 213;
            this.exportar.Text = "Exportar";
            this.exportar.UseVisualStyleBackColor = false;
            this.exportar.Click += new System.EventHandler(this.exportar_Click);
            // 
            // Remisiones1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(757, 698);
            this.Controls.Add(this.exportar);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.busRe);
            this.Controls.Add(this.dg_consulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmaterialr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtremision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdestinor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.bt_nuevo);
            this.Controls.Add(this.Bt_Ingresar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_rvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmetrosr);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(773, 737);
            this.MinimumSize = new System.Drawing.Size(773, 726);
            this.Name = "Remisiones1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remisiones";
            this.Load += new System.EventHandler(this.Remisiones1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox textEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox busRe;
        public System.Windows.Forms.DataGridView dg_consulta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaterialr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtremision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdestinor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Button bt_nuevo;
        private System.Windows.Forms.Button Bt_Ingresar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_rvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmetrosr;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exportar;
    }
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
}