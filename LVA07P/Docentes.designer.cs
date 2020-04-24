namespace WindowsFormsApplication1
{
    partial class frmDocentes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtCorreoElectrónico = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblCorreoElectrónico = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNumeroDeEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNumeroDeEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpdatosF = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIsr = new System.Windows.Forms.Label();
            this.lblNumerodeN = new System.Windows.Forms.Label();
            this.lblHomo = new System.Windows.Forms.Label();
            this.lblNss = new System.Windows.Forms.Label();
            this.lblRfc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMateriasImpartidas = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblEspecialización = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.pcbDocentes = new System.Windows.Forms.PictureBox();
            this.grpGenero.SuspendLayout();
            this.grpDatosPersonales.SuspendLayout();
            this.grpdatosF.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.cmbGenero);
            this.grpGenero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpGenero.Location = new System.Drawing.Point(38, 575);
            this.grpGenero.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpGenero.Size = new System.Drawing.Size(453, 171);
            this.grpGenero.TabIndex = 0;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(38, 63);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(365, 45);
            this.cmbGenero.TabIndex = 22;
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.txtCorreoElectrónico);
            this.grpDatosPersonales.Controls.Add(this.txtTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtDireccion);
            this.grpDatosPersonales.Controls.Add(this.lblCorreoElectrónico);
            this.grpDatosPersonales.Controls.Add(this.lblDirección);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtApellidos);
            this.grpDatosPersonales.Controls.Add(this.txtNumeroDeEmpleado);
            this.grpDatosPersonales.Controls.Add(this.lblApellidos);
            this.grpDatosPersonales.Controls.Add(this.lblNumeroDeEmpleado);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpDatosPersonales.Location = new System.Drawing.Point(38, 34);
            this.grpDatosPersonales.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpDatosPersonales.Size = new System.Drawing.Size(1260, 524);
            this.grpDatosPersonales.TabIndex = 1;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // txtCorreoElectrónico
            // 
            this.txtCorreoElectrónico.Location = new System.Drawing.Point(383, 435);
            this.txtCorreoElectrónico.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtCorreoElectrónico.Name = "txtCorreoElectrónico";
            this.txtCorreoElectrónico.Size = new System.Drawing.Size(821, 44);
            this.txtCorreoElectrónico.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(383, 361);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(821, 44);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(383, 287);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(821, 44);
            this.txtDireccion.TabIndex = 9;
            // 
            // lblCorreoElectrónico
            // 
            this.lblCorreoElectrónico.AutoSize = true;
            this.lblCorreoElectrónico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCorreoElectrónico.Location = new System.Drawing.Point(29, 444);
            this.lblCorreoElectrónico.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblCorreoElectrónico.Name = "lblCorreoElectrónico";
            this.lblCorreoElectrónico.Size = new System.Drawing.Size(282, 37);
            this.lblCorreoElectrónico.TabIndex = 8;
            this.lblCorreoElectrónico.Text = "Correo Electrónico";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDirección.Location = new System.Drawing.Point(19, 296);
            this.lblDirección.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(150, 37);
            this.lblDirección.TabIndex = 7;
            this.lblDirección.Text = "Dirección";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefono.Location = new System.Drawing.Point(29, 370);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(141, 37);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(383, 139);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(821, 44);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtNumeroDeEmpleado
            // 
            this.txtNumeroDeEmpleado.Location = new System.Drawing.Point(383, 213);
            this.txtNumeroDeEmpleado.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtNumeroDeEmpleado.Name = "txtNumeroDeEmpleado";
            this.txtNumeroDeEmpleado.Size = new System.Drawing.Size(821, 44);
            this.txtNumeroDeEmpleado.TabIndex = 4;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApellidos.Location = new System.Drawing.Point(19, 148);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(147, 37);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNumeroDeEmpleado
            // 
            this.lblNumeroDeEmpleado.AutoSize = true;
            this.lblNumeroDeEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumeroDeEmpleado.Location = new System.Drawing.Point(19, 222);
            this.lblNumeroDeEmpleado.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblNumeroDeEmpleado.Name = "lblNumeroDeEmpleado";
            this.lblNumeroDeEmpleado.Size = new System.Drawing.Size(329, 37);
            this.lblNumeroDeEmpleado.TabIndex = 2;
            this.lblNumeroDeEmpleado.Text = "Número de Empleado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(19, 74);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 37);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(383, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(821, 44);
            this.txtNombre.TabIndex = 0;
            // 
            // grpdatosF
            // 
            this.grpdatosF.Controls.Add(this.textBox5);
            this.grpdatosF.Controls.Add(this.textBox4);
            this.grpdatosF.Controls.Add(this.textBox3);
            this.grpdatosF.Controls.Add(this.textBox2);
            this.grpdatosF.Controls.Add(this.textBox1);
            this.grpdatosF.Controls.Add(this.lblIsr);
            this.grpdatosF.Controls.Add(this.lblNumerodeN);
            this.grpdatosF.Controls.Add(this.lblHomo);
            this.grpdatosF.Controls.Add(this.lblNss);
            this.grpdatosF.Controls.Add(this.lblRfc);
            this.grpdatosF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpdatosF.Location = new System.Drawing.Point(1317, 108);
            this.grpdatosF.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpdatosF.Name = "grpdatosF";
            this.grpdatosF.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpdatosF.Size = new System.Drawing.Size(1514, 453);
            this.grpdatosF.TabIndex = 2;
            this.grpdatosF.TabStop = false;
            this.grpdatosF.Text = "Datos Fiscales";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(440, 287);
            this.textBox5.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(235, 44);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(440, 139);
            this.textBox4.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1008, 44);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(440, 361);
            this.textBox3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1008, 44);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(440, 213);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1008, 44);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1008, 44);
            this.textBox1.TabIndex = 12;
            // 
            // lblIsr
            // 
            this.lblIsr.AutoSize = true;
            this.lblIsr.BackColor = System.Drawing.Color.SandyBrown;
            this.lblIsr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIsr.Location = new System.Drawing.Point(67, 148);
            this.lblIsr.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblIsr.Name = "lblIsr";
            this.lblIsr.Size = new System.Drawing.Size(68, 37);
            this.lblIsr.TabIndex = 4;
            this.lblIsr.Text = "ISR";
            // 
            // lblNumerodeN
            // 
            this.lblNumerodeN.AutoSize = true;
            this.lblNumerodeN.BackColor = System.Drawing.Color.SandyBrown;
            this.lblNumerodeN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumerodeN.Location = new System.Drawing.Point(67, 370);
            this.lblNumerodeN.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblNumerodeN.Name = "lblNumerodeN";
            this.lblNumerodeN.Size = new System.Drawing.Size(297, 37);
            this.lblNumerodeN.TabIndex = 3;
            this.lblNumerodeN.Text = "Número de Nómina";
            // 
            // lblHomo
            // 
            this.lblHomo.AutoSize = true;
            this.lblHomo.BackColor = System.Drawing.Color.SandyBrown;
            this.lblHomo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHomo.Location = new System.Drawing.Point(67, 296);
            this.lblHomo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblHomo.Name = "lblHomo";
            this.lblHomo.Size = new System.Drawing.Size(192, 37);
            this.lblHomo.TabIndex = 2;
            this.lblHomo.Text = "Homo Clave";
            // 
            // lblNss
            // 
            this.lblNss.AutoSize = true;
            this.lblNss.BackColor = System.Drawing.Color.SandyBrown;
            this.lblNss.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNss.Location = new System.Drawing.Point(67, 222);
            this.lblNss.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblNss.Name = "lblNss";
            this.lblNss.Size = new System.Drawing.Size(83, 37);
            this.lblNss.TabIndex = 1;
            this.lblNss.Text = "NSS";
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.BackColor = System.Drawing.Color.SandyBrown;
            this.lblRfc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRfc.Location = new System.Drawing.Point(67, 74);
            this.lblRfc.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(82, 37);
            this.lblRfc.TabIndex = 0;
            this.lblRfc.Text = "RFC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(57, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(57, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(871, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Materias Impartidas";
            // 
            // cmbMateriasImpartidas
            // 
            this.cmbMateriasImpartidas.FormattingEnabled = true;
            this.cmbMateriasImpartidas.Items.AddRange(new object[] {
            "Matemáticas I",
            "Matemáticas II",
            "Matemáticas III",
            "Álgebra I",
            "Álgebra II",
            "Álgebra III",
            "Cálculo I",
            "Cálculo II"});
            this.cmbMateriasImpartidas.Location = new System.Drawing.Point(1245, 151);
            this.cmbMateriasImpartidas.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmbMateriasImpartidas.Name = "cmbMateriasImpartidas";
            this.cmbMateriasImpartidas.Size = new System.Drawing.Size(1008, 45);
            this.cmbMateriasImpartidas.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Biología",
            "Español",
            "Geografía",
            "Historia",
            "Matemáticas"});
            this.comboBox1.Location = new System.Drawing.Point(1245, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1008, 45);
            this.comboBox1.TabIndex = 20;
            // 
            // lblEspecialización
            // 
            this.lblEspecialización.AutoSize = true;
            this.lblEspecialización.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEspecialización.Location = new System.Drawing.Point(871, 57);
            this.lblEspecialización.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEspecialización.Name = "lblEspecialización";
            this.lblEspecialización.Size = new System.Drawing.Size(237, 37);
            this.lblEspecialización.TabIndex = 21;
            this.lblEspecialización.Text = "Especialización";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCargo);
            this.panel1.Controls.Add(this.cmbPuesto);
            this.panel1.Controls.Add(this.lblEspecialización);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbMateriasImpartidas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(535, 578);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2296, 282);
            this.panel1.TabIndex = 16;
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Docente",
            "Administrativo",
            "Coordinador"});
            this.cmbCargo.Location = new System.Drawing.Point(209, 48);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(546, 45);
            this.cmbCargo.TabIndex = 23;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Tiempo Completo",
            "Medio Tiempo"});
            this.cmbPuesto.Location = new System.Drawing.Point(209, 151);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(546, 45);
            this.cmbPuesto.TabIndex = 22;
            // 
            // pcbDocentes
            // 
            this.pcbDocentes.Image = global::LVA07P.Properties.Resources.maestro;
            this.pcbDocentes.Location = new System.Drawing.Point(1200, 920);
            this.pcbDocentes.Name = "pcbDocentes";
            this.pcbDocentes.Size = new System.Drawing.Size(1182, 970);
            this.pcbDocentes.TabIndex = 17;
            this.pcbDocentes.TabStop = false;
            // 
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(3032, 2097);
            this.Controls.Add(this.pcbDocentes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpdatosF);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.grpGenero);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "frmDocentes";
            this.Text = "Docentes";
            this.grpGenero.ResumeLayout(false);
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpdatosF.ResumeLayout(false);
            this.grpdatosF.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNumeroDeEmpleado;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNumeroDeEmpleado;
        private System.Windows.Forms.TextBox txtCorreoElectrónico;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblCorreoElectrónico;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox grpdatosF;
        private System.Windows.Forms.Label lblIsr;
        private System.Windows.Forms.Label lblNumerodeN;
        private System.Windows.Forms.Label lblHomo;
        private System.Windows.Forms.Label lblNss;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMateriasImpartidas;
        private System.Windows.Forms.Label lblEspecialización;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.PictureBox pcbDocentes;
    }
}

