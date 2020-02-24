namespace Finder_Form
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtQueryID = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.BtnQueryID = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DataGVUsuario = new System.Windows.Forms.DataGridView();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtLocalizacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPatrimonio = new System.Windows.Forms.NumericUpDown();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CbAtraccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatrimonio)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 10F);
            this.label14.Location = new System.Drawing.Point(738, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 17);
            this.label14.TabIndex = 136;
            this.label14.Text = "Seleccionar Foto de Perfil:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(741, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 135;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TxtQueryID
            // 
            this.TxtQueryID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryID.Location = new System.Drawing.Point(52, 77);
            this.TxtQueryID.Mask = "00000";
            this.TxtQueryID.Name = "TxtQueryID";
            this.TxtQueryID.Size = new System.Drawing.Size(121, 23);
            this.TxtQueryID.TabIndex = 134;
            this.TxtQueryID.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 10F);
            this.label13.Location = new System.Drawing.Point(535, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 133;
            this.label13.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtID.Location = new System.Drawing.Point(535, 28);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(51, 20);
            this.TxtID.TabIndex = 132;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEliminar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(876, 216);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 51);
            this.BtnEliminar.TabIndex = 114;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowAll.Location = new System.Drawing.Point(179, 84);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(98, 63);
            this.BtnShowAll.TabIndex = 130;
            this.BtnShowAll.Text = "Mostrar Todos";
            this.BtnShowAll.UseVisualStyleBackColor = false;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // BtnQueryID
            // 
            this.BtnQueryID.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnQueryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQueryID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQueryID.Location = new System.Drawing.Point(53, 109);
            this.BtnQueryID.Name = "BtnQueryID";
            this.BtnQueryID.Size = new System.Drawing.Size(83, 40);
            this.BtnQueryID.TabIndex = 118;
            this.BtnQueryID.Text = "Buscar";
            this.BtnQueryID.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F);
            this.label11.Location = new System.Drawing.Point(49, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 20);
            this.label11.TabIndex = 128;
            this.label11.Text = "Filtrar por Codigo de empleado (ID)";
            // 
            // DataGVUsuario
            // 
            this.DataGVUsuario.AllowUserToAddRows = false;
            this.DataGVUsuario.AllowUserToDeleteRows = false;
            this.DataGVUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGVUsuario.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DataGVUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGVUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGVUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGVUsuario.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGVUsuario.GridColor = System.Drawing.Color.Honeydew;
            this.DataGVUsuario.Location = new System.Drawing.Point(53, 153);
            this.DataGVUsuario.MultiSelect = false;
            this.DataGVUsuario.Name = "DataGVUsuario";
            this.DataGVUsuario.ReadOnly = true;
            this.DataGVUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGVUsuario.RowHeadersVisible = false;
            this.DataGVUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGVUsuario.Size = new System.Drawing.Size(440, 316);
            this.DataGVUsuario.TabIndex = 127;
            this.DataGVUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVUsuario_CellClick);
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(535, 173);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(124, 20);
            this.dateNacimiento.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(44, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 46);
            this.label9.TabIndex = 126;
            this.label9.Text = "Registro de Usuarios";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnRegistrar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrar.Location = new System.Drawing.Point(741, 216);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(121, 51);
            this.BtnRegistrar.TabIndex = 113;
            this.BtnRegistrar.Text = "Guardar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10F);
            this.label8.Location = new System.Drawing.Point(532, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 125;
            this.label8.Text = "Localizacion";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10F);
            this.label7.Location = new System.Drawing.Point(535, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 124;
            this.label7.Text = "Sexo";
            // 
            // CbSexo
            // 
            this.CbSexo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSexo.FormattingEnabled = true;
            this.CbSexo.Location = new System.Drawing.Point(538, 278);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(121, 21);
            this.CbSexo.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10F);
            this.label4.Location = new System.Drawing.Point(535, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 120;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // TxtBio
            // 
            this.TxtBio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtBio.Location = new System.Drawing.Point(535, 373);
            this.TxtBio.Multiline = true;
            this.TxtBio.Name = "TxtBio";
            this.TxtBio.Size = new System.Drawing.Size(200, 96);
            this.TxtBio.TabIndex = 106;
            this.TxtBio.TextChanged += new System.EventHandler(this.TxtBio_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10F);
            this.label3.Location = new System.Drawing.Point(535, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 117;
            this.label3.Text = "Bio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10F);
            this.label2.Location = new System.Drawing.Point(535, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtNombre.Location = new System.Drawing.Point(535, 71);
            this.TxtNombre.MaxLength = 60;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtNombre.TabIndex = 105;
            // 
            // TxtLocalizacion
            // 
            this.TxtLocalizacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtLocalizacion.Location = new System.Drawing.Point(535, 121);
            this.TxtLocalizacion.Name = "TxtLocalizacion";
            this.TxtLocalizacion.Size = new System.Drawing.Size(200, 20);
            this.TxtLocalizacion.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10F);
            this.label1.Location = new System.Drawing.Point(532, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 138;
            this.label1.Text = "Patrimonio";
            // 
            // TxtPatrimonio
            // 
            this.TxtPatrimonio.Location = new System.Drawing.Point(535, 227);
            this.TxtPatrimonio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtPatrimonio.Name = "TxtPatrimonio";
            this.TxtPatrimonio.Size = new System.Drawing.Size(120, 20);
            this.TxtPatrimonio.TabIndex = 140;
            this.TxtPatrimonio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnActualizar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.BtnActualizar.ForeColor = System.Drawing.Color.Black;
            this.BtnActualizar.Location = new System.Drawing.Point(741, 278);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(121, 51);
            this.BtnActualizar.TabIndex = 142;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnLimpiar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(876, 278);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(121, 51);
            this.BtnLimpiar.TabIndex = 143;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10F);
            this.label5.Location = new System.Drawing.Point(535, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 145;
            this.label5.Text = "Atraccion";
            // 
            // CbAtraccion
            // 
            this.CbAtraccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CbAtraccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAtraccion.FormattingEnabled = true;
            this.CbAtraccion.Location = new System.Drawing.Point(538, 329);
            this.CbAtraccion.Name = "CbAtraccion";
            this.CbAtraccion.Size = new System.Drawing.Size(121, 21);
            this.CbAtraccion.TabIndex = 144;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbAtraccion);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtPatrimonio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtLocalizacion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtQueryID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnShowAll);
            this.Controls.Add(this.BtnQueryID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DataGVUsuario);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Name = "Form1";
            this.Text = "Crud Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPatrimonio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox TxtQueryID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnShowAll;
        private System.Windows.Forms.Button BtnQueryID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGVUsuario;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtLocalizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TxtPatrimonio;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbAtraccion;
    }
}

