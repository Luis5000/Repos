namespace LVA07P.Data
{
    partial class frmProfesor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiringDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.txtCourses = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.dtmHiringDate = new MetroFramework.Controls.MetroDateTime();
            this.lblCourses = new MetroFramework.Controls.MetroLabel();
            this.lblHiringDate = new MetroFramework.Controls.MetroLabel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoGenerateColumns = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.hiringDateDataGridViewTextBoxColumn,
            this.coursesDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.professorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(21, 62);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersWidth = 123;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.RowTemplate.Height = 46;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(480, 487);
            this.grdDatos.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 50;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 50;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 50;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 50;
            // 
            // hiringDateDataGridViewTextBoxColumn
            // 
            this.hiringDateDataGridViewTextBoxColumn.DataPropertyName = "HiringDate";
            this.hiringDateDataGridViewTextBoxColumn.HeaderText = "HiringDate";
            this.hiringDateDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.hiringDateDataGridViewTextBoxColumn.Name = "hiringDateDataGridViewTextBoxColumn";
            this.hiringDateDataGridViewTextBoxColumn.Width = 50;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            this.coursesDataGridViewTextBoxColumn.DataPropertyName = "Courses";
            this.coursesDataGridViewTextBoxColumn.HeaderText = "Courses";
            this.coursesDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            this.coursesDataGridViewTextBoxColumn.Width = 50;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(LVA07P.Data.Professor);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnEditar);
            this.pnlDatos.Controls.Add(this.btnEliminar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnAgregar);
            this.pnlDatos.Controls.Add(this.txtCourses);
            this.pnlDatos.Controls.Add(this.txtPhone);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.txtLastName);
            this.pnlDatos.Controls.Add(this.txtName);
            this.pnlDatos.Controls.Add(this.dtmHiringDate);
            this.pnlDatos.Controls.Add(this.lblCourses);
            this.pnlDatos.Controls.Add(this.lblHiringDate);
            this.pnlDatos.Controls.Add(this.lblPhone);
            this.pnlDatos.Controls.Add(this.lblEmail);
            this.pnlDatos.Controls.Add(this.lblLastName);
            this.pnlDatos.Controls.Add(this.lblName);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(540, 37);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(503, 340);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // txtCourses
            // 
            // 
            // 
            // 
            this.txtCourses.CustomButton.Image = null;
            this.txtCourses.CustomButton.Location = new System.Drawing.Point(48, 0);
            this.txtCourses.CustomButton.Name = "";
            this.txtCourses.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtCourses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourses.CustomButton.TabIndex = 1;
            this.txtCourses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourses.CustomButton.UseSelectable = true;
            this.txtCourses.CustomButton.Visible = false;
            this.txtCourses.Lines = new string[0];
            this.txtCourses.Location = new System.Drawing.Point(206, 229);
            this.txtCourses.MaxLength = 32767;
            this.txtCourses.Name = "txtCourses";
            this.txtCourses.PasswordChar = '\0';
            this.txtCourses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourses.SelectedText = "";
            this.txtCourses.SelectionLength = 0;
            this.txtCourses.SelectionStart = 0;
            this.txtCourses.ShortcutsEnabled = true;
            this.txtCourses.Size = new System.Drawing.Size(173, 23);
            this.txtCourses.TabIndex = 13;
            this.txtCourses.UseSelectable = true;
            this.txtCourses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(48, 0);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(206, 142);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(173, 23);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(48, 0);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(206, 101);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(173, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(48, 0);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(206, 60);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(173, 23);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(48, 0);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(206, 27);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(173, 23);
            this.txtName.TabIndex = 9;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtmHiringDate
            // 
            this.dtmHiringDate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.professorBindingSource, "HiringDate", true));
            this.dtmHiringDate.Location = new System.Drawing.Point(206, 180);
            this.dtmHiringDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtmHiringDate.Name = "dtmHiringDate";
            this.dtmHiringDate.Size = new System.Drawing.Size(173, 29);
            this.dtmHiringDate.TabIndex = 8;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(91, 234);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(55, 19);
            this.lblCourses.TabIndex = 7;
            this.lblCourses.Text = "Courses";
            this.lblCourses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHiringDate
            // 
            this.lblHiringDate.AutoSize = true;
            this.lblHiringDate.Location = new System.Drawing.Point(71, 190);
            this.lblHiringDate.Name = "lblHiringDate";
            this.lblHiringDate.Size = new System.Drawing.Size(75, 19);
            this.lblHiringDate.TabIndex = 6;
            this.lblHiringDate.Text = "Hiring Date";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(100, 147);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(105, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(75, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 19);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(101, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 275);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 26);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(397, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 26);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(302, 275);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 26);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(112, 275);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 26);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(207, 275);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 26);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 461);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmProfesor";
            this.Padding = new System.Windows.Forms.Padding(6, 60, 6, 7);
            this.Text = "Profesor";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiringDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblCourses;
        private MetroFramework.Controls.MetroLabel lblHiringDate;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroTextBox txtCourses;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroDateTime dtmHiringDate;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnEditar;
    }
}