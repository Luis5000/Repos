namespace WindowsFormsApplication1
{
    partial class frmStudent
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los reCourse que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los reCourse administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtCorreoElectronicoII = new System.Windows.Forms.TextBox();
            this.labelArroba = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatosEscolares = new System.Windows.Forms.GroupBox();
            this.cmbGradoAIngresar = new System.Windows.Forms.ComboBox();
            this.cmbGradoFinalizado = new System.Windows.Forms.ComboBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtEscuelaDeProcedencia = new System.Windows.Forms.TextBox();
            this.lblEscuelaDeProcedencia = new System.Windows.Forms.Label();
            this.lblGradoFinalizado = new System.Windows.Forms.Label();
            this.lblGradoAIngresar = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.pnlGuardar = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarYSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpDatosPersonales.SuspendLayout();
            this.grpDatosEscolares.SuspendLayout();
            this.pnlGuardar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.txtCorreoElectronicoII);
            this.grpDatosPersonales.Controls.Add(this.labelArroba);
            this.grpDatosPersonales.Controls.Add(this.grpGenero);
            this.grpDatosPersonales.Controls.Add(this.txtTelefono);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtDireccion);
            this.grpDatosPersonales.Controls.Add(this.lblDireccion);
            this.grpDatosPersonales.Controls.Add(this.txtEdad);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.lblEdad);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.txtCorreoElectronico);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblCorreoElectronico);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(1422, 749);
            this.grpDatosPersonales.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpDatosPersonales.Size = new System.Drawing.Size(1317, 757);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // txtCorreoElectronicoII
            // 
            this.txtCorreoElectronicoII.Location = new System.Drawing.Point(922, 290);
            this.txtCorreoElectronicoII.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtCorreoElectronicoII.Name = "txtCorreoElectronicoII";
            this.txtCorreoElectronicoII.Size = new System.Drawing.Size(368, 44);
            this.txtCorreoElectronicoII.TabIndex = 15;
            // 
            // labelArroba
            // 
            this.labelArroba.AutoSize = true;
            this.labelArroba.Location = new System.Drawing.Point(846, 299);
            this.labelArroba.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelArroba.Name = "labelArroba";
            this.labelArroba.Size = new System.Drawing.Size(47, 37);
            this.labelArroba.TabIndex = 14;
            this.labelArroba.Text = "@";
            // 
            // grpGenero
            // 
            this.grpGenero.Location = new System.Drawing.Point(29, 586);
            this.grpGenero.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpGenero.Size = new System.Drawing.Size(497, 151);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(333, 512);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(957, 44);
            this.txtTelefono.TabIndex = 13;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(19, 521);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(141, 37);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(333, 438);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(957, 44);
            this.txtDireccion.TabIndex = 11;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(19, 447);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(150, 37);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(333, 364);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(118, 44);
            this.txtEdad.TabIndex = 9;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(19, 151);
            this.lblApellidoPaterno.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(252, 37);
            this.lblApellidoPaterno.TabIndex = 7;
            this.lblApellidoPaterno.Text = "Apellido Paterno";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(333, 142);
            this.txtApellidoPaterno.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(957, 44);
            this.txtApellidoPaterno.TabIndex = 4;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(19, 373);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(92, 37);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(333, 216);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(957, 44);
            this.txtApellidoMaterno.TabIndex = 3;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(19, 225);
            this.lblApellidoMaterno.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(257, 37);
            this.lblApellidoMaterno.TabIndex = 6;
            this.lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(333, 290);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(485, 44);
            this.txtCorreoElectronico.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(333, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(957, 44);
            this.txtNombre.TabIndex = 0;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(19, 299);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(278, 37);
            this.lblCorreoElectronico.TabIndex = 5;
            this.lblCorreoElectronico.Text = "Correo electrónico";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 77);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(179, 37);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre (s)";
            // 
            // grpDatosEscolares
            // 
            this.grpDatosEscolares.Controls.Add(this.cmbGradoAIngresar);
            this.grpDatosEscolares.Controls.Add(this.cmbGradoFinalizado);
            this.grpDatosEscolares.Controls.Add(this.lblPromedio);
            this.grpDatosEscolares.Controls.Add(this.txtPromedio);
            this.grpDatosEscolares.Controls.Add(this.txtEscuelaDeProcedencia);
            this.grpDatosEscolares.Controls.Add(this.lblEscuelaDeProcedencia);
            this.grpDatosEscolares.Controls.Add(this.lblGradoFinalizado);
            this.grpDatosEscolares.Controls.Add(this.lblGradoAIngresar);
            this.grpDatosEscolares.Controls.Add(this.txtMatricula);
            this.grpDatosEscolares.Controls.Add(this.lblMatricula);
            this.grpDatosEscolares.Location = new System.Drawing.Point(1422, 71);
            this.grpDatosEscolares.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpDatosEscolares.Name = "grpDatosEscolares";
            this.grpDatosEscolares.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpDatosEscolares.Size = new System.Drawing.Size(1317, 444);
            this.grpDatosEscolares.TabIndex = 1;
            this.grpDatosEscolares.TabStop = false;
            this.grpDatosEscolares.Text = "Datos Escolares";
            // 
            // cmbGradoAIngresar
            // 
            this.cmbGradoAIngresar.FormattingEnabled = true;
            this.cmbGradoAIngresar.Items.AddRange(new object[] {
            "1° Preparatoria",
            "1° Cuatrimestre Licenciatura",
            "1° Semestre Licenciatura"});
            this.cmbGradoAIngresar.Location = new System.Drawing.Point(459, 213);
            this.cmbGradoAIngresar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmbGradoAIngresar.Name = "cmbGradoAIngresar";
            this.cmbGradoAIngresar.Size = new System.Drawing.Size(628, 45);
            this.cmbGradoAIngresar.TabIndex = 9;
            // 
            // cmbGradoFinalizado
            // 
            this.cmbGradoFinalizado.FormattingEnabled = true;
            this.cmbGradoFinalizado.Items.AddRange(new object[] {
            "3° Secundaria",
            "3° Preparatoria"});
            this.cmbGradoFinalizado.Location = new System.Drawing.Point(459, 142);
            this.cmbGradoFinalizado.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmbGradoFinalizado.Name = "cmbGradoFinalizado";
            this.cmbGradoFinalizado.Size = new System.Drawing.Size(628, 45);
            this.cmbGradoFinalizado.TabIndex = 8;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(51, 373);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(154, 37);
            this.lblPromedio.TabIndex = 7;
            this.lblPromedio.Text = "Promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(459, 364);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(137, 44);
            this.txtPromedio.TabIndex = 2;
            // 
            // txtEscuelaDeProcedencia
            // 
            this.txtEscuelaDeProcedencia.Location = new System.Drawing.Point(459, 290);
            this.txtEscuelaDeProcedencia.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtEscuelaDeProcedencia.Name = "txtEscuelaDeProcedencia";
            this.txtEscuelaDeProcedencia.Size = new System.Drawing.Size(802, 44);
            this.txtEscuelaDeProcedencia.TabIndex = 4;
            // 
            // lblEscuelaDeProcedencia
            // 
            this.lblEscuelaDeProcedencia.AutoSize = true;
            this.lblEscuelaDeProcedencia.Location = new System.Drawing.Point(51, 299);
            this.lblEscuelaDeProcedencia.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEscuelaDeProcedencia.Name = "lblEscuelaDeProcedencia";
            this.lblEscuelaDeProcedencia.Size = new System.Drawing.Size(360, 37);
            this.lblEscuelaDeProcedencia.TabIndex = 2;
            this.lblEscuelaDeProcedencia.Text = "Escuela de Procedencia";
            // 
            // lblGradoFinalizado
            // 
            this.lblGradoFinalizado.AutoSize = true;
            this.lblGradoFinalizado.Location = new System.Drawing.Point(51, 151);
            this.lblGradoFinalizado.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblGradoFinalizado.Name = "lblGradoFinalizado";
            this.lblGradoFinalizado.Size = new System.Drawing.Size(263, 37);
            this.lblGradoFinalizado.TabIndex = 3;
            this.lblGradoFinalizado.Text = "Grado Finalizado";
            // 
            // lblGradoAIngresar
            // 
            this.lblGradoAIngresar.AutoSize = true;
            this.lblGradoAIngresar.Location = new System.Drawing.Point(51, 225);
            this.lblGradoAIngresar.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblGradoAIngresar.Name = "lblGradoAIngresar";
            this.lblGradoAIngresar.Size = new System.Drawing.Size(260, 37);
            this.lblGradoAIngresar.TabIndex = 2;
            this.lblGradoAIngresar.Text = "Grado a Ingresar";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(459, 68);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(802, 44);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(51, 77);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(147, 37);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // pnlGuardar
            // 
            this.pnlGuardar.Controls.Add(this.btnSalir);
            this.pnlGuardar.Controls.Add(this.btnGuardarYSalir);
            this.pnlGuardar.Controls.Add(this.btnGuardar);
            this.pnlGuardar.Location = new System.Drawing.Point(1422, 532);
            this.pnlGuardar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pnlGuardar.Name = "pnlGuardar";
            this.pnlGuardar.Size = new System.Drawing.Size(1317, 139);
            this.pnlGuardar.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(966, 31);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(304, 65);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardarYSalir
            // 
            this.btnGuardarYSalir.Location = new System.Drawing.Point(523, 31);
            this.btnGuardarYSalir.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGuardarYSalir.Name = "btnGuardarYSalir";
            this.btnGuardarYSalir.Size = new System.Drawing.Size(304, 65);
            this.btnGuardarYSalir.TabIndex = 1;
            this.btnGuardarYSalir.Text = "Guardar y Salir";
            this.btnGuardarYSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(60, 31);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(304, 65);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2869, 2097);
            this.Controls.Add(this.pnlGuardar);
            this.Controls.Add(this.grpDatosEscolares);
            this.Controls.Add(this.grpDatosPersonales);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "frmStudent";
            this.Text = "-";
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpDatosEscolares.ResumeLayout(false);
            this.grpDatosEscolares.PerformLayout();
            this.pnlGuardar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.GroupBox grpDatosEscolares;
        private System.Windows.Forms.Label lblGradoFinalizado;
        private System.Windows.Forms.Label lblGradoAIngresar;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtEscuelaDeProcedencia;
        private System.Windows.Forms.Label lblEscuelaDeProcedencia;
        private System.Windows.Forms.Panel pnlGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarYSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCorreoElectronicoII;
        private System.Windows.Forms.Label labelArroba;
        private System.Windows.Forms.ComboBox cmbGradoAIngresar;
        private System.Windows.Forms.ComboBox cmbGradoFinalizado;
    }
}

