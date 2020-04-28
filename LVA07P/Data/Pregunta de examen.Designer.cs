namespace LVA07P.Data
{
    partial class Pregunta_de_examen
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
            this.examQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblQuestionNumber = new MetroFramework.Controls.MetroLabel();
            this.lblContent = new MetroFramework.Controls.MetroLabel();
            this.lblExam = new MetroFramework.Controls.MetroLabel();
            this.lblQuestion = new MetroFramework.Controls.MetroLabel();
            this.tbxQuestionNumber = new MetroFramework.Controls.MetroTextBox();
            this.txbContent = new MetroFramework.Controls.MetroTextBox();
            this.txbExam = new MetroFramework.Controls.MetroTextBox();
            this.txbQuestion = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResponse = new MetroFramework.Controls.MetroLabel();
            this.txbResponse = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examQuestionBindingSource)).BeginInit();
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
            this.questionNumberDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.examDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.responsesDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.examQuestionBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(22, 61);
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
            this.metroGrid1.Size = new System.Drawing.Size(482, 262);
            this.metroGrid1.TabIndex = 0;
            // 
            // examQuestionBindingSource
            // 
            this.examQuestionBindingSource.DataSource = typeof(LVA07P.Data.ExamQuestion);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txbResponse);
            this.metroPanel1.Controls.Add(this.lblResponse);
            this.metroPanel1.Controls.Add(this.btnCancelar);
            this.metroPanel1.Controls.Add(this.btnGuardar);
            this.metroPanel1.Controls.Add(this.txbQuestion);
            this.metroPanel1.Controls.Add(this.txbExam);
            this.metroPanel1.Controls.Add(this.txbContent);
            this.metroPanel1.Controls.Add(this.tbxQuestionNumber);
            this.metroPanel1.Controls.Add(this.lblQuestion);
            this.metroPanel1.Controls.Add(this.lblExam);
            this.metroPanel1.Controls.Add(this.lblContent);
            this.metroPanel1.Controls.Add(this.lblQuestionNumber);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(562, 61);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(393, 303);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(43, 23);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(114, 19);
            this.lblQuestionNumber.TabIndex = 2;
            this.lblQuestionNumber.Text = "Question Number";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(102, 63);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(55, 19);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "Content";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(116, 106);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(41, 19);
            this.lblExam.TabIndex = 4;
            this.lblExam.Text = "Exam";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(96, 150);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(61, 19);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question";
            // 
            // tbxQuestionNumber
            // 
            // 
            // 
            // 
            this.tbxQuestionNumber.CustomButton.Image = null;
            this.tbxQuestionNumber.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.tbxQuestionNumber.CustomButton.Name = "";
            this.tbxQuestionNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxQuestionNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxQuestionNumber.CustomButton.TabIndex = 1;
            this.tbxQuestionNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxQuestionNumber.CustomButton.UseSelectable = true;
            this.tbxQuestionNumber.CustomButton.Visible = false;
            this.tbxQuestionNumber.Lines = new string[0];
            this.tbxQuestionNumber.Location = new System.Drawing.Point(209, 18);
            this.tbxQuestionNumber.MaxLength = 32767;
            this.tbxQuestionNumber.Name = "tbxQuestionNumber";
            this.tbxQuestionNumber.PasswordChar = '\0';
            this.tbxQuestionNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxQuestionNumber.SelectedText = "";
            this.tbxQuestionNumber.SelectionLength = 0;
            this.tbxQuestionNumber.SelectionStart = 0;
            this.tbxQuestionNumber.ShortcutsEnabled = true;
            this.tbxQuestionNumber.Size = new System.Drawing.Size(145, 23);
            this.tbxQuestionNumber.TabIndex = 6;
            this.tbxQuestionNumber.UseSelectable = true;
            this.tbxQuestionNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxQuestionNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbContent
            // 
            // 
            // 
            // 
            this.txbContent.CustomButton.Image = null;
            this.txbContent.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txbContent.CustomButton.Name = "";
            this.txbContent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbContent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbContent.CustomButton.TabIndex = 1;
            this.txbContent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbContent.CustomButton.UseSelectable = true;
            this.txbContent.CustomButton.Visible = false;
            this.txbContent.Lines = new string[0];
            this.txbContent.Location = new System.Drawing.Point(209, 58);
            this.txbContent.MaxLength = 32767;
            this.txbContent.Name = "txbContent";
            this.txbContent.PasswordChar = '\0';
            this.txbContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbContent.SelectedText = "";
            this.txbContent.SelectionLength = 0;
            this.txbContent.SelectionStart = 0;
            this.txbContent.ShortcutsEnabled = true;
            this.txbContent.Size = new System.Drawing.Size(145, 23);
            this.txbContent.TabIndex = 7;
            this.txbContent.UseSelectable = true;
            this.txbContent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbContent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbExam
            // 
            // 
            // 
            // 
            this.txbExam.CustomButton.Image = null;
            this.txbExam.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txbExam.CustomButton.Name = "";
            this.txbExam.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbExam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbExam.CustomButton.TabIndex = 1;
            this.txbExam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbExam.CustomButton.UseSelectable = true;
            this.txbExam.CustomButton.Visible = false;
            this.txbExam.Lines = new string[0];
            this.txbExam.Location = new System.Drawing.Point(209, 101);
            this.txbExam.MaxLength = 32767;
            this.txbExam.Name = "txbExam";
            this.txbExam.PasswordChar = '\0';
            this.txbExam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbExam.SelectedText = "";
            this.txbExam.SelectionLength = 0;
            this.txbExam.SelectionStart = 0;
            this.txbExam.ShortcutsEnabled = true;
            this.txbExam.Size = new System.Drawing.Size(145, 23);
            this.txbExam.TabIndex = 8;
            this.txbExam.UseSelectable = true;
            this.txbExam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbExam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbQuestion
            // 
            // 
            // 
            // 
            this.txbQuestion.CustomButton.Image = null;
            this.txbQuestion.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txbQuestion.CustomButton.Name = "";
            this.txbQuestion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbQuestion.CustomButton.TabIndex = 1;
            this.txbQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbQuestion.CustomButton.UseSelectable = true;
            this.txbQuestion.CustomButton.Visible = false;
            this.txbQuestion.Lines = new string[0];
            this.txbQuestion.Location = new System.Drawing.Point(209, 145);
            this.txbQuestion.MaxLength = 32767;
            this.txbQuestion.Name = "txbQuestion";
            this.txbQuestion.PasswordChar = '\0';
            this.txbQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbQuestion.SelectedText = "";
            this.txbQuestion.SelectionLength = 0;
            this.txbQuestion.SelectionStart = 0;
            this.txbQuestion.ShortcutsEnabled = true;
            this.txbQuestion.Size = new System.Drawing.Size(145, 23);
            this.txbQuestion.TabIndex = 9;
            this.txbQuestion.UseSelectable = true;
            this.txbQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(116, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
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
            // questionNumberDataGridViewTextBoxColumn
            // 
            this.questionNumberDataGridViewTextBoxColumn.DataPropertyName = "QuestionNumber";
            this.questionNumberDataGridViewTextBoxColumn.HeaderText = "QuestionNumber";
            this.questionNumberDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.questionNumberDataGridViewTextBoxColumn.Name = "questionNumberDataGridViewTextBoxColumn";
            this.questionNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.Width = 50;
            // 
            // examDataGridViewTextBoxColumn
            // 
            this.examDataGridViewTextBoxColumn.DataPropertyName = "Exam";
            this.examDataGridViewTextBoxColumn.HeaderText = "Exam";
            this.examDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.examDataGridViewTextBoxColumn.Name = "examDataGridViewTextBoxColumn";
            this.examDataGridViewTextBoxColumn.Width = 50;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.Width = 50;
            // 
            // responsesDataGridViewTextBoxColumn
            // 
            this.responsesDataGridViewTextBoxColumn.DataPropertyName = "Responses";
            this.responsesDataGridViewTextBoxColumn.HeaderText = "Responses";
            this.responsesDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.responsesDataGridViewTextBoxColumn.Name = "responsesDataGridViewTextBoxColumn";
            this.responsesDataGridViewTextBoxColumn.Visible = false;
            this.responsesDataGridViewTextBoxColumn.Width = 50;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(93, 194);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(64, 19);
            this.lblResponse.TabIndex = 12;
            this.lblResponse.Text = "Response";
            // 
            // txbResponse
            // 
            // 
            // 
            // 
            this.txbResponse.CustomButton.Image = null;
            this.txbResponse.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txbResponse.CustomButton.Name = "";
            this.txbResponse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbResponse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbResponse.CustomButton.TabIndex = 1;
            this.txbResponse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbResponse.CustomButton.UseSelectable = true;
            this.txbResponse.CustomButton.Visible = false;
            this.txbResponse.Lines = new string[0];
            this.txbResponse.Location = new System.Drawing.Point(209, 189);
            this.txbResponse.MaxLength = 32767;
            this.txbResponse.Name = "txbResponse";
            this.txbResponse.PasswordChar = '\0';
            this.txbResponse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbResponse.SelectedText = "";
            this.txbResponse.SelectionLength = 0;
            this.txbResponse.SelectionStart = 0;
            this.txbResponse.ShortcutsEnabled = true;
            this.txbResponse.Size = new System.Drawing.Size(145, 23);
            this.txbResponse.TabIndex = 13;
            this.txbResponse.UseSelectable = true;
            this.txbResponse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbResponse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Pregunta_de_examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 708);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Pregunta_de_examen";
            this.Padding = new System.Windows.Forms.Padding(6, 21, 6, 7);
            this.Text = "Pregunta_de_examen";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examQuestionBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource examQuestionBindingSource;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txbQuestion;
        private MetroFramework.Controls.MetroTextBox txbExam;
        private MetroFramework.Controls.MetroTextBox txbContent;
        private MetroFramework.Controls.MetroTextBox tbxQuestionNumber;
        private MetroFramework.Controls.MetroLabel lblQuestion;
        private MetroFramework.Controls.MetroLabel lblExam;
        private MetroFramework.Controls.MetroLabel lblContent;
        private MetroFramework.Controls.MetroLabel lblQuestionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txbResponse;
        private MetroFramework.Controls.MetroLabel lblResponse;
    }
}