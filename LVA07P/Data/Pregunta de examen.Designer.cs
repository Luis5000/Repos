namespace LVA07P.Data
{
    partial class frmPreguntaDeExamen
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
            this.questionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.txtResponse = new MetroFramework.Controls.MetroTextBox();
            this.lblResponse = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtQuestion = new MetroFramework.Controls.MetroTextBox();
            this.txtExam = new MetroFramework.Controls.MetroTextBox();
            this.txtContent = new MetroFramework.Controls.MetroTextBox();
            this.txtQuestionNumber = new MetroFramework.Controls.MetroTextBox();
            this.lblQuestion = new MetroFramework.Controls.MetroLabel();
            this.lblExam = new MetroFramework.Controls.MetroLabel();
            this.lblContent = new MetroFramework.Controls.MetroLabel();
            this.lblQuestionNumber = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examQuestionBindingSource)).BeginInit();
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
            this.questionNumberDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.examDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.responsesDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.examQuestionBindingSource;
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
            this.grdDatos.Location = new System.Drawing.Point(22, 61);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.grdDatos.Size = new System.Drawing.Size(482, 262);
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
            // examQuestionBindingSource
            // 
            this.examQuestionBindingSource.DataSource = typeof(LVA07P.Data.ExamQuestion);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.txtResponse);
            this.pnlDatos.Controls.Add(this.lblResponse);
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.txtQuestion);
            this.pnlDatos.Controls.Add(this.txtExam);
            this.pnlDatos.Controls.Add(this.txtContent);
            this.pnlDatos.Controls.Add(this.txtQuestionNumber);
            this.pnlDatos.Controls.Add(this.lblQuestion);
            this.pnlDatos.Controls.Add(this.lblExam);
            this.pnlDatos.Controls.Add(this.lblContent);
            this.pnlDatos.Controls.Add(this.lblQuestionNumber);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(430, 61);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(393, 303);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // txtResponse
            // 
            // 
            // 
            // 
            this.txtResponse.CustomButton.Image = null;
            this.txtResponse.CustomButton.Location = new System.Drawing.Point(39, 0);
            this.txtResponse.CustomButton.Name = "";
            this.txtResponse.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtResponse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResponse.CustomButton.TabIndex = 1;
            this.txtResponse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResponse.CustomButton.UseSelectable = true;
            this.txtResponse.CustomButton.Visible = false;
            this.txtResponse.Lines = new string[0];
            this.txtResponse.Location = new System.Drawing.Point(209, 189);
            this.txtResponse.MaxLength = 32767;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.PasswordChar = '\0';
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResponse.SelectedText = "";
            this.txtResponse.SelectionLength = 0;
            this.txtResponse.SelectionStart = 0;
            this.txtResponse.ShortcutsEnabled = true;
            this.txtResponse.Size = new System.Drawing.Size(145, 23);
            this.txtResponse.TabIndex = 13;
            this.txtResponse.UseSelectable = true;
            this.txtResponse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResponse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
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
            // txtQuestion
            // 
            // 
            // 
            // 
            this.txtQuestion.CustomButton.Image = null;
            this.txtQuestion.CustomButton.Location = new System.Drawing.Point(39, 0);
            this.txtQuestion.CustomButton.Name = "";
            this.txtQuestion.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtQuestion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuestion.CustomButton.TabIndex = 1;
            this.txtQuestion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuestion.CustomButton.UseSelectable = true;
            this.txtQuestion.CustomButton.Visible = false;
            this.txtQuestion.Lines = new string[0];
            this.txtQuestion.Location = new System.Drawing.Point(209, 145);
            this.txtQuestion.MaxLength = 32767;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.SelectionLength = 0;
            this.txtQuestion.SelectionStart = 0;
            this.txtQuestion.ShortcutsEnabled = true;
            this.txtQuestion.Size = new System.Drawing.Size(145, 23);
            this.txtQuestion.TabIndex = 9;
            this.txtQuestion.UseSelectable = true;
            this.txtQuestion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuestion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtExam
            // 
            // 
            // 
            // 
            this.txtExam.CustomButton.Image = null;
            this.txtExam.CustomButton.Location = new System.Drawing.Point(39, 0);
            this.txtExam.CustomButton.Name = "";
            this.txtExam.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtExam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExam.CustomButton.TabIndex = 1;
            this.txtExam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExam.CustomButton.UseSelectable = true;
            this.txtExam.CustomButton.Visible = false;
            this.txtExam.Lines = new string[0];
            this.txtExam.Location = new System.Drawing.Point(209, 101);
            this.txtExam.MaxLength = 32767;
            this.txtExam.Name = "txtExam";
            this.txtExam.PasswordChar = '\0';
            this.txtExam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExam.SelectedText = "";
            this.txtExam.SelectionLength = 0;
            this.txtExam.SelectionStart = 0;
            this.txtExam.ShortcutsEnabled = true;
            this.txtExam.Size = new System.Drawing.Size(145, 23);
            this.txtExam.TabIndex = 8;
            this.txtExam.UseSelectable = true;
            this.txtExam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContent
            // 
            // 
            // 
            // 
            this.txtContent.CustomButton.Image = null;
            this.txtContent.CustomButton.Location = new System.Drawing.Point(39, 0);
            this.txtContent.CustomButton.Name = "";
            this.txtContent.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtContent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContent.CustomButton.TabIndex = 1;
            this.txtContent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContent.CustomButton.UseSelectable = true;
            this.txtContent.CustomButton.Visible = false;
            this.txtContent.Lines = new string[0];
            this.txtContent.Location = new System.Drawing.Point(209, 58);
            this.txtContent.MaxLength = 32767;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.SelectedText = "";
            this.txtContent.SelectionLength = 0;
            this.txtContent.SelectionStart = 0;
            this.txtContent.ShortcutsEnabled = true;
            this.txtContent.Size = new System.Drawing.Size(145, 23);
            this.txtContent.TabIndex = 7;
            this.txtContent.UseSelectable = true;
            this.txtContent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuestionNumber
            // 
            // 
            // 
            // 
            this.txtQuestionNumber.CustomButton.Image = null;
            this.txtQuestionNumber.CustomButton.Location = new System.Drawing.Point(39, 0);
            this.txtQuestionNumber.CustomButton.Name = "";
            this.txtQuestionNumber.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtQuestionNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuestionNumber.CustomButton.TabIndex = 1;
            this.txtQuestionNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuestionNumber.CustomButton.UseSelectable = true;
            this.txtQuestionNumber.CustomButton.Visible = false;
            this.txtQuestionNumber.Lines = new string[0];
            this.txtQuestionNumber.Location = new System.Drawing.Point(209, 18);
            this.txtQuestionNumber.MaxLength = 32767;
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.PasswordChar = '\0';
            this.txtQuestionNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuestionNumber.SelectedText = "";
            this.txtQuestionNumber.SelectionLength = 0;
            this.txtQuestionNumber.SelectionStart = 0;
            this.txtQuestionNumber.ShortcutsEnabled = true;
            this.txtQuestionNumber.Size = new System.Drawing.Size(145, 23);
            this.txtQuestionNumber.TabIndex = 6;
            this.txtQuestionNumber.UseSelectable = true;
            this.txtQuestionNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuestionNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(116, 106);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(41, 19);
            this.lblExam.TabIndex = 4;
            this.lblExam.Text = "Exam";
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
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(43, 23);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(114, 19);
            this.lblQuestionNumber.TabIndex = 2;
            this.lblQuestionNumber.Text = "Question Number";
            // 
            // frmPreguntaDeExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 417);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmPreguntaDeExamen";
            this.Padding = new System.Windows.Forms.Padding(6, 60, 6, 7);
            this.Text = "Pregunta_de_examen";
            this.Load += new System.EventHandler(this.frmPreguntaDeExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examQuestionBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource examQuestionBindingSource;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtQuestion;
        private MetroFramework.Controls.MetroTextBox txtExam;
        private MetroFramework.Controls.MetroTextBox txtContent;
        private MetroFramework.Controls.MetroTextBox txtQuestionNumber;
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
        private MetroFramework.Controls.MetroTextBox txtResponse;
        private MetroFramework.Controls.MetroLabel lblResponse;
    }
}