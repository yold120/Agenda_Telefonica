namespace Agenda_Telefonica
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.lblDatosNoEncontrados = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnPantallaEditar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnVerContactos = new System.Windows.Forms.Button();
            this.btnPantallaAgregar = new System.Windows.Forms.Button();
            this.grupo1 = new System.Windows.Forms.GroupBox();
            this.lblGrabar = new System.Windows.Forms.Label();
            this.lblCancelar = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblrequerido3 = new System.Windows.Forms.Label();
            this.lblrequerido1 = new System.Windows.Forms.Label();
            this.lblrequerido2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoresidencial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefonocelular = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblrequerido5 = new System.Windows.Forms.Label();
            this.lblrequerido8 = new System.Windows.Forms.Label();
            this.lblrequerido7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblrequerido6 = new System.Windows.Forms.Label();
            this.lblrequerido4 = new System.Windows.Forms.Label();
            this.txtFechadenacimiento = new System.Windows.Forms.TextBox();
            this.txtEstadocivil = new System.Windows.Forms.ComboBox();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodigopostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDirecciondetrabajo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvContactos2 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3.SuspendLayout();
            this.grupo1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Apellidos",
            "Telefonocelular",
            "Telefonoresidencial"});
            this.cmbBuscar.Location = new System.Drawing.Point(139, 19);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(126, 21);
            this.cmbBuscar.TabIndex = 1;
            this.cmbBuscar.Text = "Nombre";
            // 
            // lblDatosNoEncontrados
            // 
            this.lblDatosNoEncontrados.AutoSize = true;
            this.lblDatosNoEncontrados.Location = new System.Drawing.Point(441, 168);
            this.lblDatosNoEncontrados.Name = "lblDatosNoEncontrados";
            this.lblDatosNoEncontrados.Size = new System.Drawing.Size(124, 13);
            this.lblDatosNoEncontrados.TabIndex = 3;
            this.lblDatosNoEncontrados.Text = "No se encontraron datos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(275, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(490, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnInicio);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.btnPantallaEditar);
            this.groupBox3.Controls.Add(this.btnAyuda);
            this.groupBox3.Controls.Add(this.BtnSalir);
            this.groupBox3.Controls.Add(this.btnVerContactos);
            this.groupBox3.Controls.Add(this.btnPantallaAgregar);
            this.groupBox3.Location = new System.Drawing.Point(-1, -6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 597);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.ForeColor = System.Drawing.Color.Cornsilk;
            this.label16.Location = new System.Drawing.Point(44, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Inicio";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::Agenda_Telefonica.Properties.Resources.home;
            this.btnInicio.Location = new System.Drawing.Point(0, 26);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(127, 107);
            this.btnInicio.TabIndex = 32;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label29.ForeColor = System.Drawing.Color.Cornsilk;
            this.label29.Location = new System.Drawing.Point(6, 461);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 13);
            this.label29.TabIndex = 31;
            this.label29.Text = "Modificar Contacto";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label28.ForeColor = System.Drawing.Color.Cornsilk;
            this.label28.Location = new System.Drawing.Point(7, 342);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Agregar Contacto";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label27.ForeColor = System.Drawing.Color.Cornsilk;
            this.label27.Location = new System.Drawing.Point(5, 224);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(110, 13);
            this.label27.TabIndex = 31;
            this.label27.Text = "Mostrar Contactos";
            // 
            // btnPantallaEditar
            // 
            this.btnPantallaEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnPantallaEditar.FlatAppearance.BorderSize = 0;
            this.btnPantallaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantallaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPantallaEditar.ForeColor = System.Drawing.Color.White;
            this.btnPantallaEditar.Image = global::Agenda_Telefonica.Properties.Resources.configure_user_16726__2_;
            this.btnPantallaEditar.Location = new System.Drawing.Point(0, 365);
            this.btnPantallaEditar.Name = "btnPantallaEditar";
            this.btnPantallaEditar.Size = new System.Drawing.Size(127, 113);
            this.btnPantallaEditar.TabIndex = 6;
            this.btnPantallaEditar.UseVisualStyleBackColor = false;
            this.btnPantallaEditar.Click += new System.EventHandler(this.btnPantallaEditar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Image = global::Agenda_Telefonica.Properties.Resources.help_question_16768__1_;
            this.btnAyuda.Location = new System.Drawing.Point(66, 525);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(47, 48);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click_1);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Image = global::Agenda_Telefonica.Properties.Resources.cancelar1;
            this.BtnSalir.Location = new System.Drawing.Point(11, 524);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(46, 48);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnVerContactos
            // 
            this.btnVerContactos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerContactos.FlatAppearance.BorderSize = 0;
            this.btnVerContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerContactos.ForeColor = System.Drawing.Color.White;
            this.btnVerContactos.Image = global::Agenda_Telefonica.Properties.Resources.search_find_user_16727__1_;
            this.btnVerContactos.Location = new System.Drawing.Point(0, 134);
            this.btnVerContactos.Name = "btnVerContactos";
            this.btnVerContactos.Size = new System.Drawing.Size(127, 107);
            this.btnVerContactos.TabIndex = 4;
            this.btnVerContactos.UseVisualStyleBackColor = false;
            this.btnVerContactos.Click += new System.EventHandler(this.btnVerContactos_Click);
            // 
            // btnPantallaAgregar
            // 
            this.btnPantallaAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnPantallaAgregar.FlatAppearance.BorderSize = 0;
            this.btnPantallaAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantallaAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPantallaAgregar.ForeColor = System.Drawing.Color.White;
            this.btnPantallaAgregar.Image = global::Agenda_Telefonica.Properties.Resources.new_add_user_16734__3_;
            this.btnPantallaAgregar.Location = new System.Drawing.Point(0, 246);
            this.btnPantallaAgregar.Name = "btnPantallaAgregar";
            this.btnPantallaAgregar.Size = new System.Drawing.Size(127, 117);
            this.btnPantallaAgregar.TabIndex = 3;
            this.btnPantallaAgregar.UseVisualStyleBackColor = false;
            this.btnPantallaAgregar.Click += new System.EventHandler(this.btnPantallaAgregar_Click_1);
            // 
            // grupo1
            // 
            this.grupo1.BackColor = System.Drawing.Color.AliceBlue;
            this.grupo1.Controls.Add(this.lblGrabar);
            this.grupo1.Controls.Add(this.lblCancelar);
            this.grupo1.Controls.Add(this.lblEliminar);
            this.grupo1.Controls.Add(this.label30);
            this.grupo1.Controls.Add(this.btnEliminar);
            this.grupo1.Controls.Add(this.groupBox4);
            this.grupo1.Controls.Add(this.btnGrabar);
            this.grupo1.Controls.Add(this.groupBox5);
            this.grupo1.Controls.Add(this.btnCancelar);
            this.grupo1.Location = new System.Drawing.Point(139, 253);
            this.grupo1.Name = "grupo1";
            this.grupo1.Size = new System.Drawing.Size(767, 324);
            this.grupo1.TabIndex = 9;
            this.grupo1.TabStop = false;
            // 
            // lblGrabar
            // 
            this.lblGrabar.AutoSize = true;
            this.lblGrabar.BackColor = System.Drawing.Color.Transparent;
            this.lblGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblGrabar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblGrabar.Location = new System.Drawing.Point(382, 286);
            this.lblGrabar.Name = "lblGrabar";
            this.lblGrabar.Size = new System.Drawing.Size(52, 13);
            this.lblGrabar.TabIndex = 32;
            this.lblGrabar.Text = "Guardar";
            // 
            // lblCancelar
            // 
            this.lblCancelar.AutoSize = true;
            this.lblCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCancelar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCancelar.Location = new System.Drawing.Point(290, 288);
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(57, 13);
            this.lblCancelar.TabIndex = 32;
            this.lblCancelar.Text = "Cancelar";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEliminar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEliminar.Location = new System.Drawing.Point(21, 288);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(51, 13);
            this.lblEliminar.TabIndex = 32;
            this.lblEliminar.Text = "Eliminar";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label30.ForeColor = System.Drawing.Color.Cornsilk;
            this.label30.Location = new System.Drawing.Point(23, 347);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 13);
            this.label30.TabIndex = 32;
            this.label30.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Agenda_Telefonica.Properties.Resources.delete_remove_user_16733;
            this.btnEliminar.Location = new System.Drawing.Point(22, 235);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(47, 50);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblrequerido3);
            this.groupBox4.Controls.Add(this.lblrequerido1);
            this.groupBox4.Controls.Add(this.lblrequerido2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtCodigo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtTelefonoresidencial);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtApellidos);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtNombre);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtTelefonocelular);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(22, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 224);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // lblrequerido3
            // 
            this.lblrequerido3.AutoSize = true;
            this.lblrequerido3.BackColor = System.Drawing.Color.White;
            this.lblrequerido3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrequerido3.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido3.Location = new System.Drawing.Point(223, 164);
            this.lblrequerido3.Name = "lblrequerido3";
            this.lblrequerido3.Size = new System.Drawing.Size(13, 15);
            this.lblrequerido3.TabIndex = 35;
            this.lblrequerido3.Text = "*";
            // 
            // lblrequerido1
            // 
            this.lblrequerido1.AutoSize = true;
            this.lblrequerido1.BackColor = System.Drawing.Color.White;
            this.lblrequerido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrequerido1.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido1.Location = new System.Drawing.Point(299, 57);
            this.lblrequerido1.Name = "lblrequerido1";
            this.lblrequerido1.Size = new System.Drawing.Size(13, 15);
            this.lblrequerido1.TabIndex = 34;
            this.lblrequerido1.Text = "*";
            // 
            // lblrequerido2
            // 
            this.lblrequerido2.AutoSize = true;
            this.lblrequerido2.BackColor = System.Drawing.Color.White;
            this.lblrequerido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrequerido2.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido2.Location = new System.Drawing.Point(299, 91);
            this.lblrequerido2.Name = "lblrequerido2";
            this.lblrequerido2.Size = new System.Drawing.Size(13, 15);
            this.lblrequerido2.TabIndex = 33;
            this.lblrequerido2.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(138, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(98, 20);
            this.txtCodigo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tel. residencial:";
            // 
            // txtTelefonoresidencial
            // 
            this.txtTelefonoresidencial.BackColor = System.Drawing.Color.White;
            this.txtTelefonoresidencial.Location = new System.Drawing.Point(138, 161);
            this.txtTelefonoresidencial.Name = "txtTelefonoresidencial";
            this.txtTelefonoresidencial.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoresidencial.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(138, 89);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(177, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(138, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Tel. celular:";
            // 
            // txtTelefonocelular
            // 
            this.txtTelefonocelular.BackColor = System.Drawing.Color.White;
            this.txtTelefonocelular.Location = new System.Drawing.Point(138, 124);
            this.txtTelefonocelular.Name = "txtTelefonocelular";
            this.txtTelefonocelular.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonocelular.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Image = global::Agenda_Telefonica.Properties.Resources.guradar1;
            this.btnGrabar.Location = new System.Drawing.Point(377, 238);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(62, 45);
            this.btnGrabar.TabIndex = 24;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblrequerido5);
            this.groupBox5.Controls.Add(this.lblrequerido8);
            this.groupBox5.Controls.Add(this.lblrequerido7);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.lblrequerido6);
            this.groupBox5.Controls.Add(this.lblrequerido4);
            this.groupBox5.Controls.Add(this.txtFechadenacimiento);
            this.groupBox5.Controls.Add(this.txtEstadocivil);
            this.groupBox5.Controls.Add(this.txtSexo);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtDireccion);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtCodigopostal);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtDirecciondetrabajo);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(370, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(381, 224);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // lblrequerido5
            // 
            this.lblrequerido5.AutoSize = true;
            this.lblrequerido5.BackColor = System.Drawing.Color.White;
            this.lblrequerido5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrequerido5.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido5.Location = new System.Drawing.Point(223, 57);
            this.lblrequerido5.Name = "lblrequerido5";
            this.lblrequerido5.Size = new System.Drawing.Size(13, 15);
            this.lblrequerido5.TabIndex = 41;
            this.lblrequerido5.Text = "*";
            // 
            // lblrequerido8
            // 
            this.lblrequerido8.AutoSize = true;
            this.lblrequerido8.BackColor = System.Drawing.Color.White;
            this.lblrequerido8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrequerido8.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido8.Location = new System.Drawing.Point(270, 187);
            this.lblrequerido8.Name = "lblrequerido8";
            this.lblrequerido8.Size = new System.Drawing.Size(13, 15);
            this.lblrequerido8.TabIndex = 40;
            this.lblrequerido8.Text = "*";
            // 
            // lblrequerido7
            // 
            this.lblrequerido7.AutoSize = true;
            this.lblrequerido7.BackColor = System.Drawing.Color.White;
            this.lblrequerido7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrequerido7.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido7.Location = new System.Drawing.Point(346, 123);
            this.lblrequerido7.Name = "lblrequerido7";
            this.lblrequerido7.Size = new System.Drawing.Size(13, 15);
            this.lblrequerido7.TabIndex = 39;
            this.lblrequerido7.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(343, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 15);
            this.label15.TabIndex = 38;
            // 
            // lblrequerido6
            // 
            this.lblrequerido6.AutoSize = true;
            this.lblrequerido6.BackColor = System.Drawing.Color.White;
            this.lblrequerido6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrequerido6.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido6.Location = new System.Drawing.Point(258, 89);
            this.lblrequerido6.Name = "lblrequerido6";
            this.lblrequerido6.Size = new System.Drawing.Size(13, 15);
            this.lblrequerido6.TabIndex = 37;
            this.lblrequerido6.Text = "*";
            // 
            // lblrequerido4
            // 
            this.lblrequerido4.AutoSize = true;
            this.lblrequerido4.BackColor = System.Drawing.Color.White;
            this.lblrequerido4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrequerido4.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido4.Location = new System.Drawing.Point(269, 25);
            this.lblrequerido4.Name = "lblrequerido4";
            this.lblrequerido4.Size = new System.Drawing.Size(13, 15);
            this.lblrequerido4.TabIndex = 36;
            this.lblrequerido4.Text = "*";
            // 
            // txtFechadenacimiento
            // 
            this.txtFechadenacimiento.BackColor = System.Drawing.Color.White;
            this.txtFechadenacimiento.Location = new System.Drawing.Point(186, 184);
            this.txtFechadenacimiento.Name = "txtFechadenacimiento";
            this.txtFechadenacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechadenacimiento.TabIndex = 35;
            // 
            // txtEstadocivil
            // 
            this.txtEstadocivil.FormattingEnabled = true;
            this.txtEstadocivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.txtEstadocivil.Location = new System.Drawing.Point(185, 86);
            this.txtEstadocivil.Name = "txtEstadocivil";
            this.txtEstadocivil.Size = new System.Drawing.Size(100, 21);
            this.txtEstadocivil.TabIndex = 34;
            // 
            // txtSexo
            // 
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txtSexo.Location = new System.Drawing.Point(185, 54);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(64, 21);
            this.txtSexo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codigo postal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(185, 121);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(177, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Estado Civil:";
            // 
            // txtCodigopostal
            // 
            this.txtCodigopostal.BackColor = System.Drawing.Color.White;
            this.txtCodigopostal.Location = new System.Drawing.Point(185, 23);
            this.txtCodigopostal.Name = "txtCodigopostal";
            this.txtCodigopostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodigopostal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fecha de nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Direccion de trabajo:";
            // 
            // txtDirecciondetrabajo
            // 
            this.txtDirecciondetrabajo.BackColor = System.Drawing.Color.White;
            this.txtDirecciondetrabajo.Location = new System.Drawing.Point(185, 152);
            this.txtDirecciondetrabajo.Name = "txtDirecciondetrabajo";
            this.txtDirecciondetrabajo.Size = new System.Drawing.Size(175, 20);
            this.txtDirecciondetrabajo.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Sexo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::Agenda_Telefonica.Properties.Resources.cancelar1;
            this.btnCancelar.Location = new System.Drawing.Point(291, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(54, 45);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvContactos2
            // 
            this.dgvContactos2.AllowUserToAddRows = false;
            this.dgvContactos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContactos2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContactos2.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvContactos2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvContactos2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContactos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvContactos2.GridColor = System.Drawing.Color.IndianRed;
            this.dgvContactos2.Location = new System.Drawing.Point(139, 52);
            this.dgvContactos2.Name = "dgvContactos2";
            this.dgvContactos2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            this.dgvContactos2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContactos2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos2.Size = new System.Drawing.Size(745, 195);
            this.dgvContactos2.TabIndex = 10;
            this.dgvContactos2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos2_CellClick);
            this.dgvContactos2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos2_CellContentClick);
            // 
            // Eliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = false;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 49;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(918, 589);
            this.Controls.Add(this.dgvContactos2);
            this.Controls.Add(this.grupo1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.lblDatosNoEncontrados);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "Agenda Telefonica";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.Click += new System.EventHandler(this.FrmInicio_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grupo1.ResumeLayout(false);
            this.grupo1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label lblDatosNoEncontrados;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPantallaEditar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnVerContactos;
        private System.Windows.Forms.Button btnPantallaAgregar;
        private System.Windows.Forms.GroupBox grupo1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoresidencial;
        private System.Windows.Forms.TextBox txtCodigopostal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDirecciondetrabajo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefonocelular;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblGrabar;
        private System.Windows.Forms.Label lblCancelar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.DataGridView dgvContactos2;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtEstadocivil;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.TextBox txtFechadenacimiento;
        private System.Windows.Forms.Label lblrequerido3;
        private System.Windows.Forms.Label lblrequerido1;
        private System.Windows.Forms.Label lblrequerido2;
        private System.Windows.Forms.Label lblrequerido8;
        private System.Windows.Forms.Label lblrequerido7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblrequerido6;
        private System.Windows.Forms.Label lblrequerido4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblrequerido5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}

