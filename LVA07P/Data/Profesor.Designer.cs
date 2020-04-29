namespace LVA07P.Data
{
    partial class Profesor
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
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiringDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblPhone = new MetroFramework.Controls.MetroLabel();
            this.lblHiringDate = new MetroFramework.Controls.MetroLabel();
            this.lblCourses = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.tbxLastName = new MetroFramework.Controls.MetroTextBox();
            this.tbxEmail = new MetroFramework.Controls.MetroTextBox();
            this.tbxPhone = new MetroFramework.Controls.MetroTextBox();
            this.tbxCourses = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
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
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.hiringDateDataGridViewTextBoxColumn,
            this.coursesDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.professorBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(21, 62);
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
            this.metroGrid1.Size = new System.Drawing.Size(480, 487);
            this.metroGrid1.TabIndex = 0;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(LVA07P.Data.Professor);
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
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tbxCourses);
            this.metroPanel1.Controls.Add(this.tbxPhone);
            this.metroPanel1.Controls.Add(this.tbxEmail);
            this.metroPanel1.Controls.Add(this.tbxLastName);
            this.metroPanel1.Controls.Add(this.tbxName);
            this.metroPanel1.Controls.Add(this.metroDateTime1);
            this.metroPanel1.Controls.Add(this.lblCourses);
            this.metroPanel1.Controls.Add(this.lblHiringDate);
            this.metroPanel1.Controls.Add(this.lblPhone);
            this.metroPanel1.Controls.Add(this.lblEmail);
            this.metroPanel1.Controls.Add(this.lblLastName);
            this.metroPanel1.Controls.Add(this.lblName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(526, 62);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(511, 487);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(75, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 19);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
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
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(100, 147);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 19);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
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
            // metroDateTime1
            // 
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.professorBindingSource, "HiringDate", true));
            this.metroDateTime1.Location = new System.Drawing.Point(206, 180);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(173, 29);
            this.metroDateTime1.TabIndex = 8;
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.CustomButton.Image = null;
            this.tbxName.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.tbxName.CustomButton.Name = "";
            this.tbxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxName.CustomButton.TabIndex = 1;
            this.tbxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxName.CustomButton.UseSelectable = true;
            this.tbxName.CustomButton.Visible = false;
            this.tbxName.Lines = new string[0];
            this.tbxName.Location = new System.Drawing.Point(206, 27);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(173, 23);
            this.tbxName.TabIndex = 9;
            this.tbxName.UseSelectable = true;
            this.tbxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxLastName
            // 
            // 
            // 
            // 
            this.tbxLastName.CustomButton.Image = null;
            this.tbxLastName.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.tbxLastName.CustomButton.Name = "";
            this.tbxLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxLastName.CustomButton.TabIndex = 1;
            this.tbxLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxLastName.CustomButton.UseSelectable = true;
            this.tbxLastName.CustomButton.Visible = false;
            this.tbxLastName.Lines = new string[0];
            this.tbxLastName.Location = new System.Drawing.Point(206, 60);
            this.tbxLastName.MaxLength = 32767;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.PasswordChar = '\0';
            this.tbxLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxLastName.SelectedText = "";
            this.tbxLastName.SelectionLength = 0;
            this.tbxLastName.SelectionStart = 0;
            this.tbxLastName.ShortcutsEnabled = true;
            this.tbxLastName.Size = new System.Drawing.Size(173, 23);
            this.tbxLastName.TabIndex = 10;
            this.tbxLastName.UseSelectable = true;
            this.tbxLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxEmail
            // 
            // 
            // 
            // 
            this.tbxEmail.CustomButton.Image = null;
            this.tbxEmail.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.tbxEmail.CustomButton.Name = "";
            this.tbxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxEmail.CustomButton.TabIndex = 1;
            this.tbxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxEmail.CustomButton.UseSelectable = true;
            this.tbxEmail.CustomButton.Visible = false;
            this.tbxEmail.Lines = new string[0];
            this.tbxEmail.Location = new System.Drawing.Point(206, 101);
            this.tbxEmail.MaxLength = 32767;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.PasswordChar = '\0';
            this.tbxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxEmail.SelectedText = "";
            this.tbxEmail.SelectionLength = 0;
            this.tbxEmail.SelectionStart = 0;
            this.tbxEmail.ShortcutsEnabled = true;
            this.tbxEmail.Size = new System.Drawing.Size(173, 23);
            this.tbxEmail.TabIndex = 11;
            this.tbxEmail.UseSelectable = true;
            this.tbxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxPhone
            // 
            // 
            // 
            // 
            this.tbxPhone.CustomButton.Image = null;
            this.tbxPhone.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.tbxPhone.CustomButton.Name = "";
            this.tbxPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPhone.CustomButton.TabIndex = 1;
            this.tbxPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPhone.CustomButton.UseSelectable = true;
            this.tbxPhone.CustomButton.Visible = false;
            this.tbxPhone.Lines = new string[0];
            this.tbxPhone.Location = new System.Drawing.Point(206, 142);
            this.tbxPhone.MaxLength = 32767;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.PasswordChar = '\0';
            this.tbxPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPhone.SelectedText = "";
            this.tbxPhone.SelectionLength = 0;
            this.tbxPhone.SelectionStart = 0;
            this.tbxPhone.ShortcutsEnabled = true;
            this.tbxPhone.Size = new System.Drawing.Size(173, 23);
            this.tbxPhone.TabIndex = 12;
            this.tbxPhone.UseSelectable = true;
            this.tbxPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxCourses
            // 
            // 
            // 
            // 
            this.tbxCourses.CustomButton.Image = null;
            this.tbxCourses.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.tbxCourses.CustomButton.Name = "";
            this.tbxCourses.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxCourses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCourses.CustomButton.TabIndex = 1;
            this.tbxCourses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxCourses.CustomButton.UseSelectable = true;
            this.tbxCourses.CustomButton.Visible = false;
            this.tbxCourses.Lines = new string[0];
            this.tbxCourses.Location = new System.Drawing.Point(206, 229);
            this.tbxCourses.MaxLength = 32767;
            this.tbxCourses.Name = "tbxCourses";
            this.tbxCourses.PasswordChar = '\0';
            this.tbxCourses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCourses.SelectedText = "";
            this.tbxCourses.SelectionLength = 0;
            this.tbxCourses.SelectionStart = 0;
            this.tbxCourses.ShortcutsEnabled = true;
            this.tbxCourses.Size = new System.Drawing.Size(173, 23);
            this.tbxCourses.TabIndex = 13;
            this.tbxCourses.UseSelectable = true;
            this.tbxCourses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxCourses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 743);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Profesor";
            this.Padding = new System.Windows.Forms.Padding(6, 21, 6, 7);
            this.Text = "Profesor";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiringDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblCourses;
        private MetroFramework.Controls.MetroLabel lblHiringDate;
        private MetroFramework.Controls.MetroLabel lblPhone;
        private MetroFramework.Controls.MetroTextBox tbxCourses;
        private MetroFramework.Controls.MetroTextBox tbxPhone;
        private MetroFramework.Controls.MetroTextBox tbxEmail;
        private MetroFramework.Controls.MetroTextBox tbxLastName;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}