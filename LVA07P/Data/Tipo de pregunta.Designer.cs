namespace LVA07P.Data
{
    partial class Tipo_de_pregunta
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
            this.questionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multipleChoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblOpenAnswer = new MetroFramework.Controls.MetroLabel();
            this.lblMultipleChoice = new MetroFramework.Controls.MetroLabel();
            this.lblClosedAnswer = new MetroFramework.Controls.MetroLabel();
            this.txbOpenAnswer = new MetroFramework.Controls.MetroTextBox();
            this.txbMultipleChoice = new MetroFramework.Controls.MetroTextBox();
            this.txbClosedAnswer = new MetroFramework.Controls.MetroTextBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypeBindingSource)).BeginInit();
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
            this.levelDataGridViewTextBoxColumn,
            this.openAnswerDataGridViewTextBoxColumn,
            this.multipleChoiceDataGridViewTextBoxColumn,
            this.closedAnswerDataGridViewTextBoxColumn,
            this.questionsDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.questionTypeBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(23, 69);
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
            this.metroGrid1.Size = new System.Drawing.Size(387, 274);
            this.metroGrid1.TabIndex = 0;
            // 
            // questionTypeBindingSource
            // 
            this.questionTypeBindingSource.DataSource = typeof(LVA07P.Data.QuestionType);
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
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.Visible = false;
            this.levelDataGridViewTextBoxColumn.Width = 50;
            // 
            // openAnswerDataGridViewTextBoxColumn
            // 
            this.openAnswerDataGridViewTextBoxColumn.DataPropertyName = "OpenAnswer";
            this.openAnswerDataGridViewTextBoxColumn.HeaderText = "OpenAnswer";
            this.openAnswerDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.openAnswerDataGridViewTextBoxColumn.Name = "openAnswerDataGridViewTextBoxColumn";
            this.openAnswerDataGridViewTextBoxColumn.Width = 50;
            // 
            // multipleChoiceDataGridViewTextBoxColumn
            // 
            this.multipleChoiceDataGridViewTextBoxColumn.DataPropertyName = "MultipleChoice";
            this.multipleChoiceDataGridViewTextBoxColumn.HeaderText = "MultipleChoice";
            this.multipleChoiceDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.multipleChoiceDataGridViewTextBoxColumn.Name = "multipleChoiceDataGridViewTextBoxColumn";
            this.multipleChoiceDataGridViewTextBoxColumn.Width = 50;
            // 
            // closedAnswerDataGridViewTextBoxColumn
            // 
            this.closedAnswerDataGridViewTextBoxColumn.DataPropertyName = "ClosedAnswer";
            this.closedAnswerDataGridViewTextBoxColumn.HeaderText = "ClosedAnswer";
            this.closedAnswerDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.closedAnswerDataGridViewTextBoxColumn.Name = "closedAnswerDataGridViewTextBoxColumn";
            this.closedAnswerDataGridViewTextBoxColumn.Width = 50;
            // 
            // questionsDataGridViewTextBoxColumn
            // 
            this.questionsDataGridViewTextBoxColumn.DataPropertyName = "Questions";
            this.questionsDataGridViewTextBoxColumn.HeaderText = "Questions";
            this.questionsDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.questionsDataGridViewTextBoxColumn.Name = "questionsDataGridViewTextBoxColumn";
            this.questionsDataGridViewTextBoxColumn.Visible = false;
            this.questionsDataGridViewTextBoxColumn.Width = 50;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCancelar);
            this.metroPanel1.Controls.Add(this.btnGuardar);
            this.metroPanel1.Controls.Add(this.txbClosedAnswer);
            this.metroPanel1.Controls.Add(this.txbMultipleChoice);
            this.metroPanel1.Controls.Add(this.txbOpenAnswer);
            this.metroPanel1.Controls.Add(this.lblClosedAnswer);
            this.metroPanel1.Controls.Add(this.lblMultipleChoice);
            this.metroPanel1.Controls.Add(this.lblOpenAnswer);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(455, 69);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(483, 274);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblOpenAnswer
            // 
            this.lblOpenAnswer.AutoSize = true;
            this.lblOpenAnswer.Location = new System.Drawing.Point(46, 19);
            this.lblOpenAnswer.Name = "lblOpenAnswer";
            this.lblOpenAnswer.Size = new System.Drawing.Size(88, 19);
            this.lblOpenAnswer.TabIndex = 2;
            this.lblOpenAnswer.Text = "Open Answer";
            // 
            // lblMultipleChoice
            // 
            this.lblMultipleChoice.AutoSize = true;
            this.lblMultipleChoice.Location = new System.Drawing.Point(46, 90);
            this.lblMultipleChoice.Name = "lblMultipleChoice";
            this.lblMultipleChoice.Size = new System.Drawing.Size(100, 19);
            this.lblMultipleChoice.TabIndex = 3;
            this.lblMultipleChoice.Text = "Multiple Choice";
            // 
            // lblClosedAnswer
            // 
            this.lblClosedAnswer.AutoSize = true;
            this.lblClosedAnswer.Location = new System.Drawing.Point(46, 156);
            this.lblClosedAnswer.Name = "lblClosedAnswer";
            this.lblClosedAnswer.Size = new System.Drawing.Size(95, 19);
            this.lblClosedAnswer.TabIndex = 4;
            this.lblClosedAnswer.Text = "Closed Answer";
            // 
            // txbOpenAnswer
            // 
            // 
            // 
            // 
            this.txbOpenAnswer.CustomButton.Image = null;
            this.txbOpenAnswer.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txbOpenAnswer.CustomButton.Name = "";
            this.txbOpenAnswer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbOpenAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbOpenAnswer.CustomButton.TabIndex = 1;
            this.txbOpenAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbOpenAnswer.CustomButton.UseSelectable = true;
            this.txbOpenAnswer.CustomButton.Visible = false;
            this.txbOpenAnswer.Lines = new string[0];
            this.txbOpenAnswer.Location = new System.Drawing.Point(187, 14);
            this.txbOpenAnswer.MaxLength = 32767;
            this.txbOpenAnswer.Name = "txbOpenAnswer";
            this.txbOpenAnswer.PasswordChar = '\0';
            this.txbOpenAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbOpenAnswer.SelectedText = "";
            this.txbOpenAnswer.SelectionLength = 0;
            this.txbOpenAnswer.SelectionStart = 0;
            this.txbOpenAnswer.ShortcutsEnabled = true;
            this.txbOpenAnswer.Size = new System.Drawing.Size(178, 23);
            this.txbOpenAnswer.TabIndex = 5;
            this.txbOpenAnswer.UseSelectable = true;
            this.txbOpenAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbOpenAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbMultipleChoice
            // 
            // 
            // 
            // 
            this.txbMultipleChoice.CustomButton.Image = null;
            this.txbMultipleChoice.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txbMultipleChoice.CustomButton.Name = "";
            this.txbMultipleChoice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbMultipleChoice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbMultipleChoice.CustomButton.TabIndex = 1;
            this.txbMultipleChoice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbMultipleChoice.CustomButton.UseSelectable = true;
            this.txbMultipleChoice.CustomButton.Visible = false;
            this.txbMultipleChoice.Lines = new string[0];
            this.txbMultipleChoice.Location = new System.Drawing.Point(187, 85);
            this.txbMultipleChoice.MaxLength = 32767;
            this.txbMultipleChoice.Name = "txbMultipleChoice";
            this.txbMultipleChoice.PasswordChar = '\0';
            this.txbMultipleChoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMultipleChoice.SelectedText = "";
            this.txbMultipleChoice.SelectionLength = 0;
            this.txbMultipleChoice.SelectionStart = 0;
            this.txbMultipleChoice.ShortcutsEnabled = true;
            this.txbMultipleChoice.Size = new System.Drawing.Size(178, 23);
            this.txbMultipleChoice.TabIndex = 6;
            this.txbMultipleChoice.UseSelectable = true;
            this.txbMultipleChoice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbMultipleChoice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbClosedAnswer
            // 
            // 
            // 
            // 
            this.txbClosedAnswer.CustomButton.Image = null;
            this.txbClosedAnswer.CustomButton.Location = new System.Drawing.Point(156, 1);
            this.txbClosedAnswer.CustomButton.Name = "";
            this.txbClosedAnswer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbClosedAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbClosedAnswer.CustomButton.TabIndex = 1;
            this.txbClosedAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbClosedAnswer.CustomButton.UseSelectable = true;
            this.txbClosedAnswer.CustomButton.Visible = false;
            this.txbClosedAnswer.Lines = new string[0];
            this.txbClosedAnswer.Location = new System.Drawing.Point(187, 151);
            this.txbClosedAnswer.MaxLength = 32767;
            this.txbClosedAnswer.Name = "txbClosedAnswer";
            this.txbClosedAnswer.PasswordChar = '\0';
            this.txbClosedAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbClosedAnswer.SelectedText = "";
            this.txbClosedAnswer.SelectionLength = 0;
            this.txbClosedAnswer.SelectionStart = 0;
            this.txbClosedAnswer.ShortcutsEnabled = true;
            this.txbClosedAnswer.Size = new System.Drawing.Size(178, 23);
            this.txbClosedAnswer.TabIndex = 7;
            this.txbClosedAnswer.UseSelectable = true;
            this.txbClosedAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbClosedAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(137, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(257, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // Tipo_de_pregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 739);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Tipo_de_pregunta";
            this.Padding = new System.Windows.Forms.Padding(6, 21, 6, 7);
            this.Text = "Tipo_de_pregunta";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypeBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource questionTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multipleChoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionsDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txbClosedAnswer;
        private MetroFramework.Controls.MetroTextBox txbMultipleChoice;
        private MetroFramework.Controls.MetroTextBox txbOpenAnswer;
        private MetroFramework.Controls.MetroLabel lblClosedAnswer;
        private MetroFramework.Controls.MetroLabel lblMultipleChoice;
        private MetroFramework.Controls.MetroLabel lblOpenAnswer;
    }
}