namespace LVA07P.Data
{
    partial class Curso
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
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLevel = new MetroFramework.Controls.MetroLabel();
            this.lblDateBegin = new MetroFramework.Controls.MetroLabel();
            this.lblDateEnd = new MetroFramework.Controls.MetroLabel();
            this.lblProfessor = new MetroFramework.Controls.MetroLabel();
            this.lblSubject = new MetroFramework.Controls.MetroLabel();
            this.lblEnrollment = new MetroFramework.Controls.MetroLabel();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.tbxLevel = new MetroFramework.Controls.MetroTextBox();
            this.tbxProfessor = new MetroFramework.Controls.MetroTextBox();
            this.tbxSubject = new MetroFramework.Controls.MetroTextBox();
            this.tbxEnrollment = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.examsDataGridViewTextBoxColumn,
            this.enrollmentsDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.courseBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(16, 62);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(1);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 123;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 46;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(534, 574);
            this.metroGrid1.TabIndex = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(LVA07P.Data.Course);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCancelar);
            this.metroPanel1.Controls.Add(this.btnGuardar);
            this.metroPanel1.Controls.Add(this.metroDateTime2);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.tbxEnrollment);
            this.metroPanel1.Controls.Add(this.tbxSubject);
            this.metroPanel1.Controls.Add(this.tbxProfessor);
            this.metroPanel1.Controls.Add(this.tbxLevel);
            this.metroPanel1.Controls.Add(this.tbxName);
            this.metroPanel1.Controls.Add(this.lblEnrollment);
            this.metroPanel1.Controls.Add(this.lblSubject);
            this.metroPanel1.Controls.Add(this.lblProfessor);
            this.metroPanel1.Controls.Add(this.lblDateEnd);
            this.metroPanel1.Controls.Add(this.lblDateBegin);
            this.metroPanel1.Controls.Add(this.lblLevel);
            this.metroPanel1.Controls.Add(this.lblName);
            this.metroPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 4;
            this.metroPanel1.Location = new System.Drawing.Point(568, 62);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(444, 481);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
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
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.Width = 50;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            this.descriptionDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.Width = 50;
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            this.professorDataGridViewTextBoxColumn.Width = 50;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Width = 50;
            // 
            // examsDataGridViewTextBoxColumn
            // 
            this.examsDataGridViewTextBoxColumn.DataPropertyName = "Exams";
            this.examsDataGridViewTextBoxColumn.HeaderText = "Exams";
            this.examsDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.examsDataGridViewTextBoxColumn.Name = "examsDataGridViewTextBoxColumn";
            this.examsDataGridViewTextBoxColumn.Visible = false;
            this.examsDataGridViewTextBoxColumn.Width = 50;
            // 
            // enrollmentsDataGridViewTextBoxColumn
            // 
            this.enrollmentsDataGridViewTextBoxColumn.DataPropertyName = "Enrollments";
            this.enrollmentsDataGridViewTextBoxColumn.HeaderText = "Enrollments";
            this.enrollmentsDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.enrollmentsDataGridViewTextBoxColumn.Name = "enrollmentsDataGridViewTextBoxColumn";
            this.enrollmentsDataGridViewTextBoxColumn.Width = 50;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(101, 66);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(38, 19);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level";
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.Location = new System.Drawing.Point(66, 102);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(73, 19);
            this.lblDateBegin.TabIndex = 4;
            this.lblDateBegin.Text = "Date Begin";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(77, 135);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(62, 19);
            this.lblDateEnd.TabIndex = 5;
            this.lblDateEnd.Text = "Date End";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(75, 172);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(64, 19);
            this.lblProfessor.TabIndex = 6;
            this.lblProfessor.Text = "Professor";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(88, 209);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(51, 19);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Subject";
            // 
            // lblEnrollment
            // 
            this.lblEnrollment.AutoSize = true;
            this.lblEnrollment.Location = new System.Drawing.Point(75, 244);
            this.lblEnrollment.Name = "lblEnrollment";
            this.lblEnrollment.Size = new System.Drawing.Size(72, 19);
            this.lblEnrollment.TabIndex = 8;
            this.lblEnrollment.Text = "Enrollment";
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.CustomButton.Image = null;
            this.tbxName.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.tbxName.CustomButton.Name = "";
            this.tbxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxName.CustomButton.TabIndex = 1;
            this.tbxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxName.CustomButton.UseSelectable = true;
            this.tbxName.CustomButton.Visible = false;
            this.tbxName.Lines = new string[0];
            this.tbxName.Location = new System.Drawing.Point(194, 29);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(126, 23);
            this.tbxName.TabIndex = 9;
            this.tbxName.UseSelectable = true;
            this.tbxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxLevel
            // 
            // 
            // 
            // 
            this.tbxLevel.CustomButton.Image = null;
            this.tbxLevel.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.tbxLevel.CustomButton.Name = "";
            this.tbxLevel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxLevel.CustomButton.TabIndex = 1;
            this.tbxLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxLevel.CustomButton.UseSelectable = true;
            this.tbxLevel.CustomButton.Visible = false;
            this.tbxLevel.Lines = new string[0];
            this.tbxLevel.Location = new System.Drawing.Point(194, 61);
            this.tbxLevel.MaxLength = 32767;
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.PasswordChar = '\0';
            this.tbxLevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxLevel.SelectedText = "";
            this.tbxLevel.SelectionLength = 0;
            this.tbxLevel.SelectionStart = 0;
            this.tbxLevel.ShortcutsEnabled = true;
            this.tbxLevel.Size = new System.Drawing.Size(126, 23);
            this.tbxLevel.TabIndex = 10;
            this.tbxLevel.UseSelectable = true;
            this.tbxLevel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxLevel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxProfessor
            // 
            // 
            // 
            // 
            this.tbxProfessor.CustomButton.Image = null;
            this.tbxProfessor.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.tbxProfessor.CustomButton.Name = "";
            this.tbxProfessor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxProfessor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxProfessor.CustomButton.TabIndex = 1;
            this.tbxProfessor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxProfessor.CustomButton.UseSelectable = true;
            this.tbxProfessor.CustomButton.Visible = false;
            this.tbxProfessor.Lines = new string[0];
            this.tbxProfessor.Location = new System.Drawing.Point(194, 167);
            this.tbxProfessor.MaxLength = 32767;
            this.tbxProfessor.Name = "tbxProfessor";
            this.tbxProfessor.PasswordChar = '\0';
            this.tbxProfessor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxProfessor.SelectedText = "";
            this.tbxProfessor.SelectionLength = 0;
            this.tbxProfessor.SelectionStart = 0;
            this.tbxProfessor.ShortcutsEnabled = true;
            this.tbxProfessor.Size = new System.Drawing.Size(126, 23);
            this.tbxProfessor.TabIndex = 13;
            this.tbxProfessor.UseSelectable = true;
            this.tbxProfessor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxProfessor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxSubject
            // 
            // 
            // 
            // 
            this.tbxSubject.CustomButton.Image = null;
            this.tbxSubject.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.tbxSubject.CustomButton.Name = "";
            this.tbxSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxSubject.CustomButton.TabIndex = 1;
            this.tbxSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxSubject.CustomButton.UseSelectable = true;
            this.tbxSubject.CustomButton.Visible = false;
            this.tbxSubject.Lines = new string[0];
            this.tbxSubject.Location = new System.Drawing.Point(194, 204);
            this.tbxSubject.MaxLength = 32767;
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.PasswordChar = '\0';
            this.tbxSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxSubject.SelectedText = "";
            this.tbxSubject.SelectionLength = 0;
            this.tbxSubject.SelectionStart = 0;
            this.tbxSubject.ShortcutsEnabled = true;
            this.tbxSubject.Size = new System.Drawing.Size(126, 23);
            this.tbxSubject.TabIndex = 14;
            this.tbxSubject.UseSelectable = true;
            this.tbxSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxEnrollment
            // 
            // 
            // 
            // 
            this.tbxEnrollment.CustomButton.Image = null;
            this.tbxEnrollment.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.tbxEnrollment.CustomButton.Name = "";
            this.tbxEnrollment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxEnrollment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxEnrollment.CustomButton.TabIndex = 1;
            this.tbxEnrollment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxEnrollment.CustomButton.UseSelectable = true;
            this.tbxEnrollment.CustomButton.Visible = false;
            this.tbxEnrollment.Lines = new string[0];
            this.tbxEnrollment.Location = new System.Drawing.Point(194, 239);
            this.tbxEnrollment.MaxLength = 32767;
            this.tbxEnrollment.Name = "tbxEnrollment";
            this.tbxEnrollment.PasswordChar = '\0';
            this.tbxEnrollment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxEnrollment.SelectedText = "";
            this.tbxEnrollment.SelectionLength = 0;
            this.tbxEnrollment.SelectionStart = 0;
            this.tbxEnrollment.ShortcutsEnabled = true;
            this.tbxEnrollment.Size = new System.Drawing.Size(126, 23);
            this.tbxEnrollment.TabIndex = 15;
            this.tbxEnrollment.UseSelectable = true;
            this.tbxEnrollment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxEnrollment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.courseBindingSource, "DateBegin", true));
            this.metroDateTime1.Location = new System.Drawing.Point(194, 98);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 16;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.courseBindingSource, "DateEnd", true));
            this.metroDateTime2.Location = new System.Drawing.Point(194, 133);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(120, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(254, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 700);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Curso";
            this.Padding = new System.Windows.Forms.Padding(6, 60, 6, 7);
            this.Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enrollmentsDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox tbxEnrollment;
        private MetroFramework.Controls.MetroTextBox tbxSubject;
        private MetroFramework.Controls.MetroTextBox tbxProfessor;
        private MetroFramework.Controls.MetroTextBox tbxLevel;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroLabel lblEnrollment;
        private MetroFramework.Controls.MetroLabel lblSubject;
        private MetroFramework.Controls.MetroLabel lblProfessor;
        private MetroFramework.Controls.MetroLabel lblDateEnd;
        private MetroFramework.Controls.MetroLabel lblDateBegin;
        private MetroFramework.Controls.MetroLabel lblLevel;
    }
}