namespace Finder_Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtQueryID = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpia = new System.Windows.Forms.Button();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtQueryNombre = new System.Windows.Forms.TextBox();
            this.BtnQueryNombre = new System.Windows.Forms.Button();
            this.BtnQueryID = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DataGVTecnico = new System.Windows.Forms.DataGridView();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.CbCiudad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MTxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTecnico)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 10F);
            this.label14.Location = new System.Drawing.Point(1017, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 17);
            this.label14.TabIndex = 104;
            this.label14.Text = "Seleccionar Foto de Perfil:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1020, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // TxtQueryID
            // 
            this.TxtQueryID.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryID.Location = new System.Drawing.Point(11, 165);
            this.TxtQueryID.Mask = "00000";
            this.TxtQueryID.Name = "TxtQueryID";
            this.TxtQueryID.Size = new System.Drawing.Size(121, 23);
            this.TxtQueryID.TabIndex = 102;
            this.TxtQueryID.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 10F);
            this.label13.Location = new System.Drawing.Point(690, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 101;
            this.label13.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtID.Location = new System.Drawing.Point(690, 125);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(51, 20);
            this.TxtID.TabIndex = 100;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEliminar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Location = new System.Drawing.Point(896, 389);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(158, 57);
            this.BtnEliminar.TabIndex = 82;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpia
            // 
            this.BtnLimpia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnLimpia.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnLimpia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpia.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpia.Location = new System.Drawing.Point(896, 452);
            this.BtnLimpia.Name = "BtnLimpia";
            this.BtnLimpia.Size = new System.Drawing.Size(158, 57);
            this.BtnLimpia.TabIndex = 84;
            this.BtnLimpia.Text = "Limpiar";
            this.BtnLimpia.UseVisualStyleBackColor = false;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtTelefono.Location = new System.Drawing.Point(874, 272);
            this.TxtTelefono.Mask = "(000)000-0000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(124, 20);
            this.TxtTelefono.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 10F);
            this.label12.Location = new System.Drawing.Point(690, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 99;
            this.label12.Text = "Correo";
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShowAll.Location = new System.Drawing.Point(526, 166);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(98, 69);
            this.BtnShowAll.TabIndex = 98;
            this.BtnShowAll.Text = "Mostrar Todos los Registros";
            this.BtnShowAll.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F);
            this.label10.Location = new System.Drawing.Point(296, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 20);
            this.label10.TabIndex = 97;
            this.label10.Text = "Filtrar por Nombre y Apellido";
            // 
            // TxtQueryNombre
            // 
            this.TxtQueryNombre.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryNombre.Location = new System.Drawing.Point(299, 166);
            this.TxtQueryNombre.Name = "TxtQueryNombre";
            this.TxtQueryNombre.Size = new System.Drawing.Size(211, 23);
            this.TxtQueryNombre.TabIndex = 87;
            // 
            // BtnQueryNombre
            // 
            this.BtnQueryNombre.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnQueryNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQueryNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQueryNombre.Location = new System.Drawing.Point(300, 195);
            this.BtnQueryNombre.Name = "BtnQueryNombre";
            this.BtnQueryNombre.Size = new System.Drawing.Size(83, 40);
            this.BtnQueryNombre.TabIndex = 89;
            this.BtnQueryNombre.Text = "Buscar";
            this.BtnQueryNombre.UseVisualStyleBackColor = false;
            // 
            // BtnQueryID
            // 
            this.BtnQueryID.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnQueryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQueryID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQueryID.Location = new System.Drawing.Point(12, 194);
            this.BtnQueryID.Name = "BtnQueryID";
            this.BtnQueryID.Size = new System.Drawing.Size(83, 40);
            this.BtnQueryID.TabIndex = 86;
            this.BtnQueryID.Text = "Buscar";
            this.BtnQueryID.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F);
            this.label11.Location = new System.Drawing.Point(8, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 20);
            this.label11.TabIndex = 96;
            this.label11.Text = "Filtrar por Codigo de empleado (ID)";
            // 
            // DataGVTecnico
            // 
            this.DataGVTecnico.AllowUserToAddRows = false;
            this.DataGVTecnico.AllowUserToDeleteRows = false;
            this.DataGVTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGVTecnico.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DataGVTecnico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGVTecnico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVTecnico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGVTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGVTecnico.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGVTecnico.GridColor = System.Drawing.Color.Honeydew;
            this.DataGVTecnico.Location = new System.Drawing.Point(12, 241);
            this.DataGVTecnico.MultiSelect = false;
            this.DataGVTecnico.Name = "DataGVTecnico";
            this.DataGVTecnico.ReadOnly = true;
            this.DataGVTecnico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVTecnico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGVTecnico.RowHeadersVisible = false;
            this.DataGVTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGVTecnico.Size = new System.Drawing.Size(629, 268);
            this.DataGVTecnico.TabIndex = 95;
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(874, 323);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(124, 20);
            this.dateNacimiento.TabIndex = 80;
            // 
            // CbCiudad
            // 
            this.CbCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CbCiudad.FormattingEnabled = true;
            this.CbCiudad.Location = new System.Drawing.Point(875, 220);
            this.CbCiudad.Name = "CbCiudad";
            this.CbCiudad.Size = new System.Drawing.Size(123, 21);
            this.CbCiudad.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(3, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 46);
            this.label9.TabIndex = 94;
            this.label9.Text = "Registro de Tecnicos";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnRegistrar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(723, 389);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(158, 120);
            this.BtnRegistrar.TabIndex = 81;
            this.BtnRegistrar.Text = "Guardar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10F);
            this.label8.Location = new System.Drawing.Point(874, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 93;
            this.label8.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10F);
            this.label7.Location = new System.Drawing.Point(872, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 92;
            this.label7.Text = "Sexo";
            // 
            // CbSexo
            // 
            this.CbSexo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CbSexo.FormattingEnabled = true;
            this.CbSexo.Location = new System.Drawing.Point(875, 168);
            this.CbSexo.Name = "CbSexo";
            this.CbSexo.Size = new System.Drawing.Size(121, 21);
            this.CbSexo.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10F);
            this.label6.Location = new System.Drawing.Point(872, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 91;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10F);
            this.label5.Location = new System.Drawing.Point(690, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Cedula";
            // 
            // MTxtCedula
            // 
            this.MTxtCedula.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MTxtCedula.Location = new System.Drawing.Point(690, 323);
            this.MTxtCedula.Mask = "000-0000000-0";
            this.MTxtCedula.Name = "MTxtCedula";
            this.MTxtCedula.Size = new System.Drawing.Size(163, 20);
            this.MTxtCedula.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10F);
            this.label4.Location = new System.Drawing.Point(874, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtApellido.Location = new System.Drawing.Point(690, 217);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(163, 20);
            this.TxtApellido.TabIndex = 74;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtCorreo.Location = new System.Drawing.Point(690, 272);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(163, 20);
            this.TxtCorreo.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10F);
            this.label3.Location = new System.Drawing.Point(689, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10F);
            this.label2.Location = new System.Drawing.Point(690, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtNombre.Location = new System.Drawing.Point(690, 168);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(163, 20);
            this.TxtNombre.TabIndex = 73;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 521);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtQueryID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpia);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnShowAll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtQueryNombre);
            this.Controls.Add(this.BtnQueryNombre);
            this.Controls.Add(this.BtnQueryID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DataGVTecnico);
            this.Controls.Add(this.dateNacimiento);
            this.Controls.Add(this.CbCiudad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbSexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MTxtCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTecnico)).EndInit();
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
        private System.Windows.Forms.Button BtnLimpia;
        private System.Windows.Forms.MaskedTextBox TxtTelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnShowAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtQueryNombre;
        private System.Windows.Forms.Button BtnQueryNombre;
        private System.Windows.Forms.Button BtnQueryID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGVTecnico;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.ComboBox CbCiudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MTxtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}

