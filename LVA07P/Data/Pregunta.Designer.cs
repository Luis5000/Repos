namespace LVA07P.Data
{
    partial class frmPregunta
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
            this.examQuestionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroTextBox();
            this.txtQuestionType = new MetroFramework.Controls.MetroTextBox();
            this.txtContent = new MetroFramework.Controls.MetroTextBox();
            this.txtQuestionNumber = new MetroFramework.Controls.MetroTextBox();
            this.lblQuestionType = new MetroFramework.Controls.MetroLabel();
            this.lblContent = new MetroFramework.Controls.MetroLabel();
            this.lblQuestionNumber = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
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
            this.examQuestionsDataGridViewTextBoxColumn,
            this.questionTypeDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.questionBindingSource;
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
            this.grdDatos.Location = new System.Drawing.Point(67, 211);
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
            this.grdDatos.Size = new System.Drawing.Size(1200, 615);
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
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(LVA07P.Data.Question);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.txtQuestionType);
            this.pnlDatos.Controls.Add(this.txtContent);
            this.pnlDatos.Controls.Add(this.txtQuestionNumber);
            this.pnlDatos.Controls.Add(this.lblQuestionType);
            this.pnlDatos.Controls.Add(this.lblContent);
            this.pnlDatos.Controls.Add(this.lblQuestionNumber);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 28;
            this.pnlDatos.Location = new System.Drawing.Point(1355, 211);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1232, 754);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 32;
            // 
            // btnCancelar
            // 
            // 
            // 
            // 
            this.btnCancelar.CustomButton.Image = null;
            this.btnCancelar.CustomButton.Location = new System.Drawing.Point(551, 3);
            this.btnCancelar.CustomButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCancelar.CustomButton.Name = "";
            this.btnCancelar.CustomButton.Size = new System.Drawing.Size(200, 179);
            this.btnCancelar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCancelar.CustomButton.TabIndex = 1;
            this.btnCancelar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancelar.CustomButton.UseSelectable = true;
            this.btnCancelar.CustomButton.Visible = false;
            this.btnCancelar.Lines = new string[] {
        "Cancelar"};
            this.btnCancelar.Location = new System.Drawing.Point(800, 495);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCancelar.MaxLength = 32767;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PasswordChar = '\0';
            this.btnCancelar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnCancelar.SelectedText = "";
            this.btnCancelar.SelectionLength = 0;
            this.btnCancelar.SelectionStart = 0;
            this.btnCancelar.ShortcutsEnabled = true;
            this.btnCancelar.Size = new System.Drawing.Size(238, 65);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnCancelar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.btnGuardar.CustomButton.Image = null;
            this.btnGuardar.CustomButton.Location = new System.Drawing.Point(551, 3);
            this.btnGuardar.CustomButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGuardar.CustomButton.Name = "";
            this.btnGuardar.CustomButton.Size = new System.Drawing.Size(200, 179);
            this.btnGuardar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGuardar.CustomButton.TabIndex = 1;
            this.btnGuardar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGuardar.CustomButton.UseSelectable = true;
            this.btnGuardar.CustomButton.Visible = false;
            this.btnGuardar.Lines = new string[] {
        "Guardar"};
            this.btnGuardar.Location = new System.Drawing.Point(399, 495);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGuardar.MaxLength = 32767;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.PasswordChar = '\0';
            this.btnGuardar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnGuardar.SelectedText = "";
            this.btnGuardar.SelectionLength = 0;
            this.btnGuardar.SelectionStart = 0;
            this.btnGuardar.ShortcutsEnabled = true;
            this.btnGuardar.Size = new System.Drawing.Size(238, 65);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnGuardar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQuestionType
            // 
            // 
            // 
            // 
            this.txtQuestionType.CustomButton.Image = null;
            this.txtQuestionType.CustomButton.Location = new System.Drawing.Point(1260, 3);
            this.txtQuestionType.CustomButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtQuestionType.CustomButton.Name = "";
            this.txtQuestionType.CustomButton.Size = new System.Drawing.Size(200, 179);
            this.txtQuestionType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuestionType.CustomButton.TabIndex = 1;
            this.txtQuestionType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuestionType.CustomButton.UseSelectable = true;
            this.txtQuestionType.CustomButton.Visible = false;
            this.txtQuestionType.Lines = new string[0];
            this.txtQuestionType.Location = new System.Drawing.Point(618, 330);
            this.txtQuestionType.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtQuestionType.MaxLength = 32767;
            this.txtQuestionType.Name = "txtQuestionType";
            this.txtQuestionType.PasswordChar = '\0';
            this.txtQuestionType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuestionType.SelectedText = "";
            this.txtQuestionType.SelectionLength = 0;
            this.txtQuestionType.SelectionStart = 0;
            this.txtQuestionType.ShortcutsEnabled = true;
            this.txtQuestionType.Size = new System.Drawing.Size(462, 65);
            this.txtQuestionType.TabIndex = 7;
            this.txtQuestionType.UseSelectable = true;
            this.txtQuestionType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuestionType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContent
            // 
            // 
            // 
            // 
            this.txtContent.CustomButton.Image = null;
            this.txtContent.CustomButton.Location = new System.Drawing.Point(1260, 3);
            this.txtContent.CustomButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtContent.CustomButton.Name = "";
            this.txtContent.CustomButton.Size = new System.Drawing.Size(200, 179);
            this.txtContent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContent.CustomButton.TabIndex = 1;
            this.txtContent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContent.CustomButton.UseSelectable = true;
            this.txtContent.CustomButton.Visible = false;
            this.txtContent.Lines = new string[0];
            this.txtContent.Location = new System.Drawing.Point(618, 194);
            this.txtContent.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtContent.MaxLength = 32767;
            this.txtContent.Name = "txtContent";
            this.txtContent.PasswordChar = '\0';
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.SelectedText = "";
            this.txtContent.SelectionLength = 0;
            this.txtContent.SelectionStart = 0;
            this.txtContent.ShortcutsEnabled = true;
            this.txtContent.Size = new System.Drawing.Size(462, 65);
            this.txtContent.TabIndex = 6;
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
            this.txtQuestionNumber.CustomButton.Location = new System.Drawing.Point(1260, 3);
            this.txtQuestionNumber.CustomButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtQuestionNumber.CustomButton.Name = "";
            this.txtQuestionNumber.CustomButton.Size = new System.Drawing.Size(200, 179);
            this.txtQuestionNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuestionNumber.CustomButton.TabIndex = 1;
            this.txtQuestionNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuestionNumber.CustomButton.UseSelectable = true;
            this.txtQuestionNumber.CustomButton.Visible = false;
            this.txtQuestionNumber.Lines = new string[0];
            this.txtQuestionNumber.Location = new System.Drawing.Point(618, 71);
            this.txtQuestionNumber.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtQuestionNumber.MaxLength = 32767;
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.PasswordChar = '\0';
            this.txtQuestionNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuestionNumber.SelectedText = "";
            this.txtQuestionNumber.SelectionLength = 0;
            this.txtQuestionNumber.SelectionStart = 0;
            this.txtQuestionNumber.ShortcutsEnabled = true;
            this.txtQuestionNumber.Size = new System.Drawing.Size(462, 65);
            this.txtQuestionNumber.TabIndex = 5;
            this.txtQuestionNumber.UseSelectable = true;
            this.txtQuestionNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuestionNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Location = new System.Drawing.Point(228, 344);
            this.lblQuestionType.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(92, 19);
            this.lblQuestionType.TabIndex = 4;
            this.lblQuestionType.Text = "Question Type";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(345, 208);
            this.lblContent.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(55, 19);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "Content";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(158, 85);
            this.lblQuestionNumber.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(114, 19);
            this.lblQuestionNumber.TabIndex = 2;
            this.lblQuestionNumber.Text = "Question Number";
            // 
            // frmPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3316, 2069);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmPregunta";
            this.Padding = new System.Windows.Forms.Padding(19, 171, 19, 20);
            this.Text = "Pregunta";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examQuestionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTypeDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroTextBox btnCancelar;
        private MetroFramework.Controls.MetroTextBox btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtQuestionType;
        private MetroFramework.Controls.MetroTextBox txtContent;
        private MetroFramework.Controls.MetroTextBox txtQuestionNumber;
        private MetroFramework.Controls.MetroLabel lblQuestionType;
        private MetroFramework.Controls.MetroLabel lblContent;
        private MetroFramework.Controls.MetroLabel lblQuestionNumber;
    }
}