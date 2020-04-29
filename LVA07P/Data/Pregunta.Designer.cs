namespace LVA07P.Data
{
    partial class Pregunta
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
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examQuestionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblQuestionNumber = new MetroFramework.Controls.MetroLabel();
            this.lblContent = new MetroFramework.Controls.MetroLabel();
            this.lblQuestionType = new MetroFramework.Controls.MetroLabel();
            this.txbQuestionNumber = new MetroFramework.Controls.MetroTextBox();
            this.txbContent = new MetroFramework.Controls.MetroTextBox();
            this.txbQuestionType = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
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
            this.examQuestionsDataGridViewTextBoxColumn,
            this.questionTypeDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.questionBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(21, 74);
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
            this.metroGrid1.Size = new System.Drawing.Size(379, 216);
            this.metroGrid1.TabIndex = 0;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(LVA07P.Data.Question);
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
            // examQuestionsDataGridViewTextBoxColumn
            // 
            this.examQuestionsDataGridViewTextBoxColumn.DataPropertyName = "ExamQuestions";
            this.examQuestionsDataGridViewTextBoxColumn.HeaderText = "ExamQuestions";
            this.examQuestionsDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.examQuestionsDataGridViewTextBoxColumn.Name = "examQuestionsDataGridViewTextBoxColumn";
            this.examQuestionsDataGridViewTextBoxColumn.Visible = false;
            this.examQuestionsDataGridViewTextBoxColumn.Width = 50;
            // 
            // questionTypeDataGridViewTextBoxColumn
            // 
            this.questionTypeDataGridViewTextBoxColumn.DataPropertyName = "QuestionType";
            this.questionTypeDataGridViewTextBoxColumn.HeaderText = "QuestionType";
            this.questionTypeDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.questionTypeDataGridViewTextBoxColumn.Name = "questionTypeDataGridViewTextBoxColumn";
            this.questionTypeDataGridViewTextBoxColumn.Width = 50;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCancelar);
            this.metroPanel1.Controls.Add(this.btnGuardar);
            this.metroPanel1.Controls.Add(this.txbQuestionType);
            this.metroPanel1.Controls.Add(this.txbContent);
            this.metroPanel1.Controls.Add(this.txbQuestionNumber);
            this.metroPanel1.Controls.Add(this.lblQuestionType);
            this.metroPanel1.Controls.Add(this.lblContent);
            this.metroPanel1.Controls.Add(this.lblQuestionNumber);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(428, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(389, 265);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(50, 30);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(114, 19);
            this.lblQuestionNumber.TabIndex = 2;
            this.lblQuestionNumber.Text = "Question Number";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(109, 73);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(55, 19);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "Content";
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Location = new System.Drawing.Point(72, 121);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(92, 19);
            this.lblQuestionType.TabIndex = 4;
            this.lblQuestionType.Text = "Question Type";
            // 
            // txbQuestionNumber
            // 
            // 
            // 
            // 
            this.txbQuestionNumber.CustomButton.Image = null;
            this.txbQuestionNumber.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txbQuestionNumber.CustomButton.Name = "";
            this.txbQuestionNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbQuestionNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbQuestionNumber.CustomButton.TabIndex = 1;
            this.txbQuestionNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbQuestionNumber.CustomButton.UseSelectable = true;
            this.txbQuestionNumber.CustomButton.Visible = false;
            this.txbQuestionNumber.Lines = new string[0];
            this.txbQuestionNumber.Location = new System.Drawing.Point(195, 25);
            this.txbQuestionNumber.MaxLength = 32767;
            this.txbQuestionNumber.Name = "txbQuestionNumber";
            this.txbQuestionNumber.PasswordChar = '\0';
            this.txbQuestionNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbQuestionNumber.SelectedText = "";
            this.txbQuestionNumber.SelectionLength = 0;
            this.txbQuestionNumber.SelectionStart = 0;
            this.txbQuestionNumber.ShortcutsEnabled = true;
            this.txbQuestionNumber.Size = new System.Drawing.Size(146, 23);
            this.txbQuestionNumber.TabIndex = 5;
            this.txbQuestionNumber.UseSelectable = true;
            this.txbQuestionNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbQuestionNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbContent
            // 
            // 
            // 
            // 
            this.txbContent.CustomButton.Image = null;
            this.txbContent.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txbContent.CustomButton.Name = "";
            this.txbContent.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbContent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbContent.CustomButton.TabIndex = 1;
            this.txbContent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbContent.CustomButton.UseSelectable = true;
            this.txbContent.CustomButton.Visible = false;
            this.txbContent.Lines = new string[0];
            this.txbContent.Location = new System.Drawing.Point(195, 68);
            this.txbContent.MaxLength = 32767;
            this.txbContent.Name = "txbContent";
            this.txbContent.PasswordChar = '\0';
            this.txbContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbContent.SelectedText = "";
            this.txbContent.SelectionLength = 0;
            this.txbContent.SelectionStart = 0;
            this.txbContent.ShortcutsEnabled = true;
            this.txbContent.Size = new System.Drawing.Size(146, 23);
            this.txbContent.TabIndex = 6;
            this.txbContent.UseSelectable = true;
            this.txbContent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbContent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbQuestionType
            // 
            // 
            // 
            // 
            this.txbQuestionType.CustomButton.Image = null;
            this.txbQuestionType.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txbQuestionType.CustomButton.Name = "";
            this.txbQuestionType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbQuestionType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbQuestionType.CustomButton.TabIndex = 1;
            this.txbQuestionType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbQuestionType.CustomButton.UseSelectable = true;
            this.txbQuestionType.CustomButton.Visible = false;
            this.txbQuestionType.Lines = new string[0];
            this.txbQuestionType.Location = new System.Drawing.Point(195, 116);
            this.txbQuestionType.MaxLength = 32767;
            this.txbQuestionType.Name = "txbQuestionType";
            this.txbQuestionType.PasswordChar = '\0';
            this.txbQuestionType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbQuestionType.SelectedText = "";
            this.txbQuestionType.SelectionLength = 0;
            this.txbQuestionType.SelectionStart = 0;
            this.txbQuestionType.ShortcutsEnabled = true;
            this.txbQuestionType.Size = new System.Drawing.Size(146, 23);
            this.txbQuestionType.TabIndex = 7;
            this.txbQuestionType.UseSelectable = true;
            this.txbQuestionType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbQuestionType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.btnGuardar.CustomButton.Image = null;
            this.btnGuardar.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.btnGuardar.CustomButton.Name = "";
            this.btnGuardar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.btnGuardar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardar.CustomButton.TabIndex = 1;
            this.btnGuardar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.CustomButton.UseSelectable = true;
            this.btnGuardar.CustomButton.Visible = false;
            this.btnGuardar.Lines = new string[] {
        "Guardar"};
            this.btnGuardar.Location = new System.Drawing.Point(126, 174);
            this.btnGuardar.MaxLength = 32767;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.PasswordChar = '\0';
            this.btnGuardar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnGuardar.SelectedText = "";
            this.btnGuardar.SelectionLength = 0;
            this.btnGuardar.SelectionStart = 0;
            this.btnGuardar.ShortcutsEnabled = true;
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnGuardar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelar
            // 
            // 
            // 
            // 
            this.btnCancelar.CustomButton.Image = null;
            this.btnCancelar.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.btnCancelar.CustomButton.Name = "";
            this.btnCancelar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.btnCancelar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCancelar.CustomButton.TabIndex = 1;
            this.btnCancelar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancelar.CustomButton.UseSelectable = true;
            this.btnCancelar.CustomButton.Visible = false;
            this.btnCancelar.Lines = new string[] {
        "Cancelar"};
            this.btnCancelar.Location = new System.Drawing.Point(249, 174);
            this.btnCancelar.MaxLength = 32767;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PasswordChar = '\0';
            this.btnCancelar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnCancelar.SelectedText = "";
            this.btnCancelar.SelectionLength = 0;
            this.btnCancelar.SelectionStart = 0;
            this.btnCancelar.ShortcutsEnabled = true;
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnCancelar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 727);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Pregunta";
            this.Padding = new System.Windows.Forms.Padding(6, 21, 6, 7);
            this.Text = "Pregunta";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examQuestionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTypeDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox btnCancelar;
        private MetroFramework.Controls.MetroTextBox btnGuardar;
        private MetroFramework.Controls.MetroTextBox txbQuestionType;
        private MetroFramework.Controls.MetroTextBox txbContent;
        private MetroFramework.Controls.MetroTextBox txbQuestionNumber;
        private MetroFramework.Controls.MetroLabel lblQuestionType;
        private MetroFramework.Controls.MetroLabel lblContent;
        private MetroFramework.Controls.MetroLabel lblQuestionNumber;
    }
}