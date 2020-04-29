namespace LVA07P.Data
{
    partial class Enrolamiento
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
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblDateAssigment = new MetroFramework.Controls.MetroLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAssignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDateLow = new MetroFramework.Controls.MetroLabel();
            this.lblStudent = new MetroFramework.Controls.MetroLabel();
            this.lblCourse = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.tbxStudent = new MetroFramework.Controls.MetroTextBox();
            this.tbxCourse = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
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
            this.dateAssignmentDataGridViewTextBoxColumn,
            this.dateLowDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.enrollmentBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(22, 70);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.metroGrid1.Size = new System.Drawing.Size(400, 472);
            this.metroGrid1.TabIndex = 0;
            // 
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataSource = typeof(LVA07P.Data.Enrollment);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCancelar);
            this.metroPanel1.Controls.Add(this.btnGuardar);
            this.metroPanel1.Controls.Add(this.tbxCourse);
            this.metroPanel1.Controls.Add(this.tbxStudent);
            this.metroPanel1.Controls.Add(this.metroDateTime2);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.lblCourse);
            this.metroPanel1.Controls.Add(this.lblStudent);
            this.metroPanel1.Controls.Add(this.lblDateLow);
            this.metroPanel1.Controls.Add(this.lblDateAssigment);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 4;
            this.metroPanel1.Location = new System.Drawing.Point(434, 70);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(403, 472);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 3;
            // 
            // lblDateAssigment
            // 
            this.lblDateAssigment.AutoSize = true;
            this.lblDateAssigment.Location = new System.Drawing.Point(15, 22);
            this.lblDateAssigment.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDateAssigment.Name = "lblDateAssigment";
            this.lblDateAssigment.Size = new System.Drawing.Size(100, 19);
            this.lblDateAssigment.TabIndex = 2;
            this.lblDateAssigment.Text = "Date Assigment";
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
            // dateAssignmentDataGridViewTextBoxColumn
            // 
            this.dateAssignmentDataGridViewTextBoxColumn.DataPropertyName = "DateAssignment";
            this.dateAssignmentDataGridViewTextBoxColumn.HeaderText = "DateAssignment";
            this.dateAssignmentDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.dateAssignmentDataGridViewTextBoxColumn.Name = "dateAssignmentDataGridViewTextBoxColumn";
            this.dateAssignmentDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateLowDataGridViewTextBoxColumn
            // 
            this.dateLowDataGridViewTextBoxColumn.DataPropertyName = "DateLow";
            this.dateLowDataGridViewTextBoxColumn.HeaderText = "DateLow";
            this.dateLowDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.dateLowDataGridViewTextBoxColumn.Name = "dateLowDataGridViewTextBoxColumn";
            this.dateLowDataGridViewTextBoxColumn.Width = 50;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.Width = 50;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Width = 50;
            // 
            // lblDateLow
            // 
            this.lblDateLow.AutoSize = true;
            this.lblDateLow.Location = new System.Drawing.Point(55, 58);
            this.lblDateLow.Name = "lblDateLow";
            this.lblDateLow.Size = new System.Drawing.Size(60, 19);
            this.lblDateLow.TabIndex = 3;
            this.lblDateLow.Text = "Date low";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(62, 100);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(53, 19);
            this.lblStudent.TabIndex = 4;
            this.lblStudent.Text = "Student";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(65, 145);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 19);
            this.lblCourse.TabIndex = 5;
            this.lblCourse.Text = "Course";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enrollmentBindingSource, "DateAssignment", true));
            this.metroDateTime1.Location = new System.Drawing.Point(140, 12);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 6;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enrollmentBindingSource, "DateLow", true));
            this.metroDateTime2.Location = new System.Drawing.Point(140, 56);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 7;
            // 
            // tbxStudent
            // 
            // 
            // 
            // 
            this.tbxStudent.CustomButton.Image = null;
            this.tbxStudent.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbxStudent.CustomButton.Name = "";
            this.tbxStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxStudent.CustomButton.TabIndex = 1;
            this.tbxStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxStudent.CustomButton.UseSelectable = true;
            this.tbxStudent.CustomButton.Visible = false;
            this.tbxStudent.Lines = new string[0];
            this.tbxStudent.Location = new System.Drawing.Point(140, 100);
            this.tbxStudent.MaxLength = 32767;
            this.tbxStudent.Name = "tbxStudent";
            this.tbxStudent.PasswordChar = '\0';
            this.tbxStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxStudent.SelectedText = "";
            this.tbxStudent.SelectionLength = 0;
            this.tbxStudent.SelectionStart = 0;
            this.tbxStudent.ShortcutsEnabled = true;
            this.tbxStudent.Size = new System.Drawing.Size(200, 23);
            this.tbxStudent.TabIndex = 8;
            this.tbxStudent.UseSelectable = true;
            this.tbxStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxCourse
            // 
            // 
            // 
            // 
            this.tbxCourse.CustomButton.Image = null;
            this.tbxCourse.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tbxCourse.CustomButton.Name = "";
            this.tbxCourse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxCourse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCourse.CustomButton.TabIndex = 1;
            this.tbxCourse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxCourse.CustomButton.UseSelectable = true;
            this.tbxCourse.CustomButton.Visible = false;
            this.tbxCourse.Lines = new string[0];
            this.tbxCourse.Location = new System.Drawing.Point(140, 140);
            this.tbxCourse.MaxLength = 32767;
            this.tbxCourse.Name = "tbxCourse";
            this.tbxCourse.PasswordChar = '\0';
            this.tbxCourse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCourse.SelectedText = "";
            this.tbxCourse.SelectionLength = 0;
            this.tbxCourse.SelectionStart = 0;
            this.tbxCourse.ShortcutsEnabled = true;
            this.tbxCourse.Size = new System.Drawing.Size(200, 23);
            this.tbxCourse.TabIndex = 9;
            this.tbxCourse.UseSelectable = true;
            this.tbxCourse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxCourse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(140, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // Enrolamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 733);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Enrolamiento";
            this.Padding = new System.Windows.Forms.Padding(6, 21, 6, 7);
            this.Text = "Enrolamiento";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblDateAssigment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAssignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox tbxCourse;
        private MetroFramework.Controls.MetroTextBox tbxStudent;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel lblCourse;
        private MetroFramework.Controls.MetroLabel lblStudent;
        private MetroFramework.Controls.MetroLabel lblDateLow;
    }
}