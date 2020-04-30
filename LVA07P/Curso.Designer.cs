namespace LVA07P.Data
{
    partial class frmCurso
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
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.btnRead = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.txtSubject = new MetroFramework.Controls.MetroTextBox();
            this.lblSubject = new MetroFramework.Controls.MetroLabel();
            this.dtmDateEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtmDateBegin = new MetroFramework.Controls.MetroDateTime();
            this.txtProfessor = new MetroFramework.Controls.MetroTextBox();
            this.lblProfessor = new MetroFramework.Controls.MetroLabel();
            this.lblDateEnd = new MetroFramework.Controls.MetroLabel();
            this.lblDateBegin = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
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
            this.levelDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.examsDataGridViewTextBoxColumn,
            this.enrollmentsDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.courseBindingSource;
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
            this.grdDatos.Location = new System.Drawing.Point(27, 77);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(1);
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
            this.grdDatos.Size = new System.Drawing.Size(417, 197);
            this.grdDatos.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // examsDataGridViewTextBoxColumn
            // 
            this.examsDataGridViewTextBoxColumn.DataPropertyName = "Exams";
            this.examsDataGridViewTextBoxColumn.HeaderText = "Exams";
            this.examsDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.examsDataGridViewTextBoxColumn.Name = "examsDataGridViewTextBoxColumn";
            this.examsDataGridViewTextBoxColumn.Visible = false;
            // 
            // enrollmentsDataGridViewTextBoxColumn
            // 
            this.enrollmentsDataGridViewTextBoxColumn.DataPropertyName = "Enrollments";
            this.enrollmentsDataGridViewTextBoxColumn.HeaderText = "Enrollments";
            this.enrollmentsDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.enrollmentsDataGridViewTextBoxColumn.Name = "enrollmentsDataGridViewTextBoxColumn";
            this.enrollmentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(LVA07P.Data.Course);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnRead);
            this.pnlDatos.Controls.Add(this.btnDelete);
            this.pnlDatos.Controls.Add(this.btnCreate);
            this.pnlDatos.Controls.Add(this.btnUpdate);
            this.pnlDatos.Controls.Add(this.txtSubject);
            this.pnlDatos.Controls.Add(this.lblSubject);
            this.pnlDatos.Controls.Add(this.dtmDateEnd);
            this.pnlDatos.Controls.Add(this.dtmDateBegin);
            this.pnlDatos.Controls.Add(this.txtProfessor);
            this.pnlDatos.Controls.Add(this.lblProfessor);
            this.pnlDatos.Controls.Add(this.lblDateEnd);
            this.pnlDatos.Controls.Add(this.lblDateBegin);
            this.pnlDatos.Controls.Add(this.txtName);
            this.pnlDatos.Controls.Add(this.lblName);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 4;
            this.pnlDatos.Location = new System.Drawing.Point(467, 77);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(1);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(405, 334);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 3;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(204, 248);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(91, 29);
            this.btnRead.TabIndex = 15;
            this.btnRead.Text = "Leer";
            this.btnRead.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 29);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseSelectable = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(107, 248);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 29);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(10, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 29);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            // 
            // txtSubject
            // 
            // 
            // 
            // 
            this.txtSubject.CustomButton.Image = null;
            this.txtSubject.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtSubject.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtSubject.CustomButton.Name = "";
            this.txtSubject.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubject.CustomButton.TabIndex = 1;
            this.txtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubject.CustomButton.UseSelectable = true;
            this.txtSubject.CustomButton.Visible = false;
            this.txtSubject.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.courseBindingSource, "Subject", true));
            this.txtSubject.Lines = new string[0];
            this.txtSubject.Location = new System.Drawing.Point(107, 178);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(1);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.ShortcutsEnabled = true;
            this.txtSubject.Size = new System.Drawing.Size(278, 20);
            this.txtSubject.TabIndex = 11;
            this.txtSubject.UseSelectable = true;
            this.txtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(28, 178);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(51, 19);
            this.lblSubject.TabIndex = 10;
            this.lblSubject.Text = "Subject";
            // 
            // dtmDateEnd
            // 
            this.dtmDateEnd.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.courseBindingSource, "DateEnd", true));
            this.dtmDateEnd.Location = new System.Drawing.Point(107, 132);
            this.dtmDateEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtmDateEnd.Name = "dtmDateEnd";
            this.dtmDateEnd.Size = new System.Drawing.Size(200, 29);
            this.dtmDateEnd.TabIndex = 9;
            // 
            // dtmDateBegin
            // 
            this.dtmDateBegin.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.courseBindingSource, "DateBegin", true));
            this.dtmDateBegin.Location = new System.Drawing.Point(107, 95);
            this.dtmDateBegin.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtmDateBegin.Name = "dtmDateBegin";
            this.dtmDateBegin.Size = new System.Drawing.Size(200, 29);
            this.dtmDateBegin.TabIndex = 8;
            // 
            // txtProfessor
            // 
            // 
            // 
            // 
            this.txtProfessor.CustomButton.Image = null;
            this.txtProfessor.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtProfessor.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtProfessor.CustomButton.Name = "";
            this.txtProfessor.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtProfessor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProfessor.CustomButton.TabIndex = 1;
            this.txtProfessor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProfessor.CustomButton.UseSelectable = true;
            this.txtProfessor.CustomButton.Visible = false;
            this.txtProfessor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.courseBindingSource, "Professor", true));
            this.txtProfessor.Lines = new string[0];
            this.txtProfessor.Location = new System.Drawing.Point(107, 63);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(1);
            this.txtProfessor.MaxLength = 32767;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.PasswordChar = '\0';
            this.txtProfessor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProfessor.SelectedText = "";
            this.txtProfessor.SelectionLength = 0;
            this.txtProfessor.SelectionStart = 0;
            this.txtProfessor.ShortcutsEnabled = true;
            this.txtProfessor.Size = new System.Drawing.Size(278, 20);
            this.txtProfessor.TabIndex = 7;
            this.txtProfessor.UseSelectable = true;
            this.txtProfessor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProfessor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Location = new System.Drawing.Point(28, 63);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(64, 19);
            this.lblProfessor.TabIndex = 6;
            this.lblProfessor.Text = "Professor";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(28, 142);
            this.lblDateEnd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(62, 19);
            this.lblDateEnd.TabIndex = 5;
            this.lblDateEnd.Text = "Date End";
            // 
            // lblDateBegin
            // 
            this.lblDateBegin.AutoSize = true;
            this.lblDateBegin.Location = new System.Drawing.Point(28, 105);
            this.lblDateBegin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDateBegin.Name = "lblDateBegin";
            this.lblDateBegin.Size = new System.Drawing.Size(73, 19);
            this.lblDateBegin.TabIndex = 4;
            this.lblDateBegin.Text = "Date Begin";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.txtName.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.courseBindingSource, "Name", true));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(89, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(1);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(296, 20);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 469);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmCurso";
            this.Padding = new System.Windows.Forms.Padding(6, 60, 6, 7);
            this.Text = "Curso";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroTextBox txtName;
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
        private MetroFramework.Controls.MetroLabel lblProfessor;
        private MetroFramework.Controls.MetroLabel lblDateEnd;
        private MetroFramework.Controls.MetroLabel lblDateBegin;
        private MetroFramework.Controls.MetroTextBox txtSubject;
        private MetroFramework.Controls.MetroLabel lblSubject;
        private MetroFramework.Controls.MetroDateTime dtmDateEnd;
        private MetroFramework.Controls.MetroDateTime dtmDateBegin;
        private MetroFramework.Controls.MetroTextBox txtProfessor;
        private MetroFramework.Controls.MetroButton btnRead;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroButton btnUpdate;
    }
}