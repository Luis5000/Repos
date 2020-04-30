namespace LVA07P.Data
{
    partial class frmEnrolamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAssignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrollmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtCourse = new MetroFramework.Controls.MetroTextBox();
            this.txtStudent = new MetroFramework.Controls.MetroTextBox();
            this.dtmDateLow = new MetroFramework.Controls.MetroDateTime();
            this.dtmDateAssignment = new MetroFramework.Controls.MetroDateTime();
            this.lblCourse = new MetroFramework.Controls.MetroLabel();
            this.lblStudent = new MetroFramework.Controls.MetroLabel();
            this.lblDateLow = new MetroFramework.Controls.MetroLabel();
            this.lblDateAssigment = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).BeginInit();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateAssignmentDataGridViewTextBoxColumn,
            this.dateLowDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.enrollmentBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(22, 70);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(1);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatos.RowHeadersWidth = 123;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.RowTemplate.Height = 46;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(400, 472);
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
            // enrollmentBindingSource
            // 
            this.enrollmentBindingSource.DataSource = typeof(LVA07P.Data.Enrollment);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.txtCourse);
            this.pnlDatos.Controls.Add(this.txtStudent);
            this.pnlDatos.Controls.Add(this.dtmDateLow);
            this.pnlDatos.Controls.Add(this.dtmDateAssignment);
            this.pnlDatos.Controls.Add(this.lblCourse);
            this.pnlDatos.Controls.Add(this.lblStudent);
            this.pnlDatos.Controls.Add(this.lblDateLow);
            this.pnlDatos.Controls.Add(this.lblDateAssigment);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 4;
            this.pnlDatos.Location = new System.Drawing.Point(434, 70);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(1);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(403, 249);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 3;
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(140, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // txtCourse
            // 
            // 
            // 
            // 
            this.txtCourse.CustomButton.Image = null;
            this.txtCourse.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtCourse.CustomButton.Name = "";
            this.txtCourse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourse.CustomButton.TabIndex = 1;
            this.txtCourse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourse.CustomButton.UseSelectable = true;
            this.txtCourse.CustomButton.Visible = false;
            this.txtCourse.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enrollmentBindingSource, "Course", true));
            this.txtCourse.Lines = new string[0];
            this.txtCourse.Location = new System.Drawing.Point(140, 140);
            this.txtCourse.MaxLength = 32767;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.PasswordChar = '\0';
            this.txtCourse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourse.SelectedText = "";
            this.txtCourse.SelectionLength = 0;
            this.txtCourse.SelectionStart = 0;
            this.txtCourse.ShortcutsEnabled = true;
            this.txtCourse.Size = new System.Drawing.Size(200, 23);
            this.txtCourse.TabIndex = 9;
            this.txtCourse.UseSelectable = true;
            this.txtCourse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudent
            // 
            // 
            // 
            // 
            this.txtStudent.CustomButton.Image = null;
            this.txtStudent.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtStudent.CustomButton.Name = "";
            this.txtStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudent.CustomButton.TabIndex = 1;
            this.txtStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudent.CustomButton.UseSelectable = true;
            this.txtStudent.CustomButton.Visible = false;
            this.txtStudent.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enrollmentBindingSource, "Student", true));
            this.txtStudent.Lines = new string[0];
            this.txtStudent.Location = new System.Drawing.Point(140, 100);
            this.txtStudent.MaxLength = 32767;
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.PasswordChar = '\0';
            this.txtStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudent.SelectedText = "";
            this.txtStudent.SelectionLength = 0;
            this.txtStudent.SelectionStart = 0;
            this.txtStudent.ShortcutsEnabled = true;
            this.txtStudent.Size = new System.Drawing.Size(200, 23);
            this.txtStudent.TabIndex = 8;
            this.txtStudent.UseSelectable = true;
            this.txtStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtmDateLow
            // 
            this.dtmDateLow.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enrollmentBindingSource, "DateLow", true));
            this.dtmDateLow.Location = new System.Drawing.Point(140, 56);
            this.dtmDateLow.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtmDateLow.Name = "dtmDateLow";
            this.dtmDateLow.Size = new System.Drawing.Size(200, 29);
            this.dtmDateLow.TabIndex = 7;
            // 
            // dtmDateAssignment
            // 
            this.dtmDateAssignment.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.enrollmentBindingSource, "DateAssignment", true));
            this.dtmDateAssignment.Location = new System.Drawing.Point(140, 12);
            this.dtmDateAssignment.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtmDateAssignment.Name = "dtmDateAssignment";
            this.dtmDateAssignment.Size = new System.Drawing.Size(200, 29);
            this.dtmDateAssignment.TabIndex = 6;
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
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(62, 100);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(53, 19);
            this.lblStudent.TabIndex = 4;
            this.lblStudent.Text = "Student";
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
            // frmEnrolamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 437);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmEnrolamiento";
            this.Padding = new System.Windows.Forms.Padding(6, 60, 6, 7);
            this.Text = "Enrolamiento";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrollmentBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource enrollmentBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroLabel lblDateAssigment;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAssignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtCourse;
        private MetroFramework.Controls.MetroTextBox txtStudent;
        private MetroFramework.Controls.MetroDateTime dtmDateLow;
        private MetroFramework.Controls.MetroDateTime dtmDateAssignment;
        private MetroFramework.Controls.MetroLabel lblCourse;
        private MetroFramework.Controls.MetroLabel lblStudent;
        private MetroFramework.Controls.MetroLabel lblDateLow;
    }
}