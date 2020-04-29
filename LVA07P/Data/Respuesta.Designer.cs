namespace LVA07P.Data
{
    partial class frmRespuesta
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
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examQuestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtExamQuestion = new MetroFramework.Controls.MetroTextBox();
            this.txtStudent = new MetroFramework.Controls.MetroTextBox();
            this.txtAnswer = new MetroFramework.Controls.MetroTextBox();
            this.lblExamQuestion = new MetroFramework.Controls.MetroLabel();
            this.lblStudent = new MetroFramework.Controls.MetroLabel();
            this.lblAnswer = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).BeginInit();
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
            this.answerDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn,
            this.examQuestionDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.responseBindingSource;
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
            this.grdDatos.Location = new System.Drawing.Point(95, 196);
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
            this.grdDatos.Size = new System.Drawing.Size(1248, 740);
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
            // responseBindingSource
            // 
            this.responseBindingSource.DataSource = typeof(LVA07P.Data.Response);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.txtExamQuestion);
            this.pnlDatos.Controls.Add(this.txtStudent);
            this.pnlDatos.Controls.Add(this.txtAnswer);
            this.pnlDatos.Controls.Add(this.lblExamQuestion);
            this.pnlDatos.Controls.Add(this.lblStudent);
            this.pnlDatos.Controls.Add(this.lblAnswer);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 28;
            this.pnlDatos.Location = new System.Drawing.Point(1526, 196);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1511, 740);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(811, 595);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(238, 65);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(428, 595);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(238, 65);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // txtExamQuestion
            // 
            // 
            // 
            // 
            this.txtExamQuestion.CustomButton.Image = null;
            this.txtExamQuestion.CustomButton.Location = new System.Drawing.Point(1102, 3);
            this.txtExamQuestion.CustomButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtExamQuestion.CustomButton.Name = "";
            this.txtExamQuestion.CustomButton.Size = new System.Drawing.Size(200, 179);
            this.txtExamQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExamQuestion.CustomButton.TabIndex = 1;
            this.txtExamQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExamQuestion.CustomButton.UseSelectable = true;
            this.txtExamQuestion.CustomButton.Visible = false;
            this.txtExamQuestion.Lines = new string[0];
            this.txtExamQuestion.Location = new System.Drawing.Point(738, 416);
            this.txtExamQuestion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtExamQuestion.MaxLength = 32767;
            this.txtExamQuestion.Name = "txtExamQuestion";
            this.txtExamQuestion.PasswordChar = '\0';
            this.txtExamQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExamQuestion.SelectedText = "";
            this.txtExamQuestion.SelectionLength = 0;
            this.txtExamQuestion.SelectionStart = 0;
            this.txtExamQuestion.ShortcutsEnabled = true;
            this.txtExamQuestion.Size = new System.Drawing.Size(412, 65);
            this.txtExamQuestion.TabIndex = 7;
            this.txtExamQuestion.UseSelectable = true;
            this.txtExamQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExamQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudent
            // 
            // 
            // 
            // 
            this.txtStudent.CustomButton.Image = null;
            this.txtStudent.CustomButton.Location = new System.Drawing.Point(1102, 3);
            this.txtStudent.CustomButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtStudent.CustomButton.Name = "";
            this.txtStudent.CustomButton.Size = new System.Drawing.Size(200, 179);
            this.txtStudent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudent.CustomButton.TabIndex = 1;
            this.txtStudent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudent.CustomButton.UseSelectable = true;
            this.txtStudent.CustomButton.Visible = false;
            this.txtStudent.Lines = new string[0];
            this.txtStudent.Location = new System.Drawing.Point(738, 259);
            this.txtStudent.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtStudent.MaxLength = 32767;
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.PasswordChar = '\0';
            this.txtStudent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudent.SelectedText = "";
            this.txtStudent.SelectionLength = 0;
            this.txtStudent.SelectionStart = 0;
            this.txtStudent.ShortcutsEnabled = true;
            this.txtStudent.Size = new System.Drawing.Size(412, 65);
            this.txtStudent.TabIndex = 6;
            this.txtStudent.UseSelectable = true;
            this.txtStudent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAnswer
            // 
            // 
            // 
            // 
            this.txtAnswer.CustomButton.Image = null;
            this.txtAnswer.CustomButton.Location = new System.Drawing.Point(1102, 3);
            this.txtAnswer.CustomButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtAnswer.CustomButton.Name = "";
            this.txtAnswer.CustomButton.Size = new System.Drawing.Size(200, 179);
            this.txtAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnswer.CustomButton.TabIndex = 1;
            this.txtAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnswer.CustomButton.UseSelectable = true;
            this.txtAnswer.CustomButton.Visible = false;
            this.txtAnswer.Lines = new string[0];
            this.txtAnswer.Location = new System.Drawing.Point(738, 102);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtAnswer.MaxLength = 32767;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.PasswordChar = '\0';
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnswer.SelectedText = "";
            this.txtAnswer.SelectionLength = 0;
            this.txtAnswer.SelectionStart = 0;
            this.txtAnswer.ShortcutsEnabled = true;
            this.txtAnswer.Size = new System.Drawing.Size(412, 65);
            this.txtAnswer.TabIndex = 5;
            this.txtAnswer.UseSelectable = true;
            this.txtAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblExamQuestion
            // 
            this.lblExamQuestion.AutoSize = true;
            this.lblExamQuestion.Location = new System.Drawing.Point(215, 427);
            this.lblExamQuestion.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblExamQuestion.Name = "lblExamQuestion";
            this.lblExamQuestion.Size = new System.Drawing.Size(97, 19);
            this.lblExamQuestion.TabIndex = 4;
            this.lblExamQuestion.Text = "Exam Question";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(355, 270);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(53, 19);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Student";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(361, 114);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(51, 19);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer";
            // 
            // frmRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3449, 2078);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmRespuesta";
            this.Padding = new System.Windows.Forms.Padding(19, 171, 19, 20);
            this.Text = "Respuesta";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource responseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examQuestionDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtExamQuestion;
        private MetroFramework.Controls.MetroTextBox txtStudent;
        private MetroFramework.Controls.MetroTextBox txtAnswer;
        private MetroFramework.Controls.MetroLabel lblExamQuestion;
        private MetroFramework.Controls.MetroLabel lblStudent;
        private MetroFramework.Controls.MetroLabel lblAnswer;
    }
}