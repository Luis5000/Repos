namespace LVA07P.Data
{
    partial class Respuesta
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
            this.responseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examQuestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblAnswer = new MetroFramework.Controls.MetroLabel();
            this.lblStudent = new MetroFramework.Controls.MetroLabel();
            this.lblExamQuestion = new MetroFramework.Controls.MetroLabel();
            this.txbAnswer = new MetroFramework.Controls.MetroTextBox();
            this.txbStudent = new MetroFramework.Controls.MetroTextBox();
            this.tbxExamQuestion = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).BeginInit();
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
            this.answerDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.examQuestionDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.responseBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(30, 69);
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
            this.metroGrid1.Size = new System.Drawing.Size(394, 260);
            this.metroGrid1.TabIndex = 0;
            // 
            // responseBindingSource
            // 
            this.responseBindingSource.DataSource = typeof(LVA07P.Data.Response);
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
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.Width = 50;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.Width = 50;
            // 
            // examQuestionDataGridViewTextBoxColumn
            // 
            this.examQuestionDataGridViewTextBoxColumn.DataPropertyName = "ExamQuestion";
            this.examQuestionDataGridViewTextBoxColumn.HeaderText = "ExamQuestion";
            this.examQuestionDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.examQuestionDataGridViewTextBoxColumn.Name = "examQuestionDataGridViewTextBoxColumn";
            this.examQuestionDataGridViewTextBoxColumn.Width = 50;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCancelar);
            this.metroPanel1.Controls.Add(this.btnGuardar);
            this.metroPanel1.Controls.Add(this.tbxExamQuestion);
            this.metroPanel1.Controls.Add(this.txbStudent);
            this.metroPanel1.Controls.Add(this.txbAnswer);
            this.metroPanel1.Controls.Add(this.lblExamQuestion);
            this.metroPanel1.Controls.Add(this.lblStudent);
            this.metroPanel1.Controls.Add(this.lblAnswer);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(482, 69);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(477, 260);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(114, 40);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(51, 19);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(112, 95);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(53, 19);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Student";
            // 
            // lblExamQuestion
            // 
            this.lblExamQuestion.AutoSize = true;
            this.lblExamQuestion.Location = new System.Drawing.Point(68, 150);
            this.lblExamQuestion.Name = "lblExamQuestion";
            this.lblExamQuestion.Size = new System.Drawing.Size(97, 19);
            this.lblExamQuestion.TabIndex = 4;
            this.lblExamQuestion.Text = "Exam Question";
            // 
            // txbAnswer
            // 
            // 
            // 
            // 
            this.txbAnswer.CustomButton.Image = null;
            this.txbAnswer.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.txbAnswer.CustomButton.Name = "";
            this.txbAnswer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbAnswer.CustomButton.TabIndex = 1;
            this.txbAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbAnswer.CustomButton.UseSelectable = true;
            this.txbAnswer.CustomButton.Visible = false;
            this.txbAnswer.Lines = new string[0];
            this.txbAnswer.Location = new System.Drawing.Point(233, 36);
            this.txbAnswer.MaxLength = 32767;
            this.txbAnswer.Name = "txbAnswer";
            this.txbAnswer.PasswordChar = '\0';
            this.txbAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbAnswer.SelectedText = "";
            this.txbAnswer.SelectionLength = 0;
            this.txbAnswer.SelectionStart = 0;
            this.txbAnswer.ShortcutsEnabled = true;
            this.txbAnswer.Size = new System.Drawing.Size(130, 23);
            this.txbAnswer.TabIndex = 5;
            this.txbAnswer.UseSelectable = true;
            this.txbAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbStudent
            // 
            // 
            // 
            // 
            this.txbStudent.CustomButton.Image = null;
            this.txbStudent.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.txbStudent.CustomButton.Name = "";
            this.txbStudent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbStudent.CustomButton.TabIndex = 1;
            this.txbStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbStudent.CustomButton.UseSelectable = true;
            this.txbStudent.CustomButton.Visible = false;
            this.txbStudent.Lines = new string[0];
            this.txbStudent.Location = new System.Drawing.Point(233, 91);
            this.txbStudent.MaxLength = 32767;
            this.txbStudent.Name = "txbStudent";
            this.txbStudent.PasswordChar = '\0';
            this.txbStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbStudent.SelectedText = "";
            this.txbStudent.SelectionLength = 0;
            this.txbStudent.SelectionStart = 0;
            this.txbStudent.ShortcutsEnabled = true;
            this.txbStudent.Size = new System.Drawing.Size(130, 23);
            this.txbStudent.TabIndex = 6;
            this.txbStudent.UseSelectable = true;
            this.txbStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxExamQuestion
            // 
            // 
            // 
            // 
            this.tbxExamQuestion.CustomButton.Image = null;
            this.tbxExamQuestion.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.tbxExamQuestion.CustomButton.Name = "";
            this.tbxExamQuestion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxExamQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxExamQuestion.CustomButton.TabIndex = 1;
            this.tbxExamQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxExamQuestion.CustomButton.UseSelectable = true;
            this.tbxExamQuestion.CustomButton.Visible = false;
            this.tbxExamQuestion.Lines = new string[0];
            this.tbxExamQuestion.Location = new System.Drawing.Point(233, 146);
            this.tbxExamQuestion.MaxLength = 32767;
            this.tbxExamQuestion.Name = "tbxExamQuestion";
            this.tbxExamQuestion.PasswordChar = '\0';
            this.tbxExamQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxExamQuestion.SelectedText = "";
            this.tbxExamQuestion.SelectionLength = 0;
            this.tbxExamQuestion.SelectionStart = 0;
            this.tbxExamQuestion.ShortcutsEnabled = true;
            this.tbxExamQuestion.Size = new System.Drawing.Size(130, 23);
            this.tbxExamQuestion.TabIndex = 7;
            this.tbxExamQuestion.UseSelectable = true;
            this.tbxExamQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxExamQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(135, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(256, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // Respuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 730);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Respuesta";
            this.Padding = new System.Windows.Forms.Padding(6, 60, 6, 7);
            this.Text = "Respuesta";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource responseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examQuestionDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox tbxExamQuestion;
        private MetroFramework.Controls.MetroTextBox txbStudent;
        private MetroFramework.Controls.MetroTextBox txbAnswer;
        private MetroFramework.Controls.MetroLabel lblExamQuestion;
        private MetroFramework.Controls.MetroLabel lblStudent;
        private MetroFramework.Controls.MetroLabel lblAnswer;
    }
}