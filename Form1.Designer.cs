namespace veterinaria_1._3
{
    partial class AtencionVet
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
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.Atencion = new System.Windows.Forms.Label();
            this.txtAtencion = new System.Windows.Forms.TextBox();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASCOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(307, 58);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(176, 23);
            this.cboTipo.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnNuevo.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(12, 324);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(73, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mascota:";
            // 
            // txtMascota
            // 
            this.txtMascota.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMascota.Location = new System.Drawing.Point(307, 89);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.Size = new System.Drawing.Size(176, 20);
            this.txtMascota.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditar.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(147, 324);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGrabar.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(450, 324);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(102, 23);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCancelar.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(574, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSalir.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(742, 324);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha";
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(593, 123);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(121, 20);
            this.txtImporte.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(531, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Importe";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(593, 56);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(240, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(261, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(307, 122);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(45, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // Atencion
            // 
            this.Atencion.AutoSize = true;
            this.Atencion.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atencion.Location = new System.Drawing.Point(519, 91);
            this.Atencion.Name = "Atencion";
            this.Atencion.Size = new System.Drawing.Size(61, 15);
            this.Atencion.TabIndex = 27;
            this.Atencion.Text = "Atencion:";
            // 
            // txtAtencion
            // 
            this.txtAtencion.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtencion.Location = new System.Drawing.Point(593, 91);
            this.txtAtencion.Name = "txtAtencion";
            this.txtAtencion.Size = new System.Drawing.Size(251, 20);
            this.txtAtencion.TabIndex = 8;
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCliente.Location = new System.Drawing.Point(12, 15);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(156, 28);
            this.lblNroCliente.TabIndex = 28;
            this.lblNroCliente.Text = "Cliente Nro ";
            this.lblNroCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(73, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(176, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(73, 122);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(123, 20);
            this.txtDni.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Aprellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "DNI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Nombre";
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.AllowUserToAddRows = false;
            this.dgvMascotas.AllowUserToDeleteRows = false;
            this.dgvMascotas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.NOMBRE,
            this.DNI,
            this.MASCOTA,
            this.EDAD,
            this.IMPORTE,
            this.CONSULTA});
            this.dgvMascotas.Location = new System.Drawing.Point(14, 175);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.ReadOnly = true;
            this.dgvMascotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMascotas.Size = new System.Drawing.Size(747, 128);
            this.dgvMascotas.TabIndex = 9;
            this.dgvMascotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellClick);
            this.dgvMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellContentClick);
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "APELLIDO";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // MASCOTA
            // 
            this.MASCOTA.HeaderText = "MASCOTA";
            this.MASCOTA.Name = "MASCOTA";
            this.MASCOTA.ReadOnly = true;
            // 
            // EDAD
            // 
            this.EDAD.HeaderText = "EDAD";
            this.EDAD.Name = "EDAD";
            this.EDAD.ReadOnly = true;
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            this.IMPORTE.ReadOnly = true;
            // 
            // CONSULTA
            // 
            this.CONSULTA.HeaderText = "CONSULTA";
            this.CONSULTA.Name = "CONSULTA";
            this.CONSULTA.ReadOnly = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBorrar.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(267, 324);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(102, 23);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAgregar.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(742, 122);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 23);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // AtencionVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 368);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNroCliente);
            this.Controls.Add(this.txtAtencion);
            this.Controls.Add(this.Atencion);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMascota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cboTipo);
            this.Name = "AtencionVet";
            this.Text = "AtencionVet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMascota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label Atencion;
        private System.Windows.Forms.TextBox txtAtencion;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASCOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONSULTA;
        private System.Windows.Forms.Button btnAgregar;
    }
}

