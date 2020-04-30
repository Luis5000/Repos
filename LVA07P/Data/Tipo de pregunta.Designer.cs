namespace LVA07P.Data
{
    partial class frmTipoDePregunta
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
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multipleChoiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtClosedAnswer = new MetroFramework.Controls.MetroTextBox();
            this.txtMultipleChoice = new MetroFramework.Controls.MetroTextBox();
            this.txtOpenAnswer = new MetroFramework.Controls.MetroTextBox();
            this.lblClosedAnswer = new MetroFramework.Controls.MetroLabel();
            this.lblMultipleChoice = new MetroFramework.Controls.MetroLabel();
            this.lblOpenAnswer = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypeBindingSource)).BeginInit();
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
            this.levelDataGridViewTextBoxColumn,
            this.openAnswerDataGridViewTextBoxColumn,
            this.multipleChoiceDataGridViewTextBoxColumn,
            this.closedAnswerDataGridViewTextBoxColumn,
            this.questionsDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.questionTypeBindingSource;
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
            this.grdDatos.Location = new System.Drawing.Point(23, 69);
            this.grdDatos.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.grdDatos.Size = new System.Drawing.Size(387, 274);
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
            // questionTypeBindingSource
            // 
            this.questionTypeBindingSource.DataSource = typeof(LVA07P.Data.QuestionType);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnCancelar);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.txtClosedAnswer);
            this.pnlDatos.Controls.Add(this.txtMultipleChoice);
            this.pnlDatos.Controls.Add(this.txtOpenAnswer);
            this.pnlDatos.Controls.Add(this.lblClosedAnswer);
            this.pnlDatos.Controls.Add(this.lblMultipleChoice);
            this.pnlDatos.Controls.Add(this.lblOpenAnswer);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(455, 69);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(483, 274);
            this.pnlDatos.TabIndex = 1;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
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
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(137, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            // 
            // txtClosedAnswer
            // 
            // 
            // 
            // 
            this.txtClosedAnswer.CustomButton.Image = null;
            this.txtClosedAnswer.CustomButton.Location = new System.Drawing.Point(49, 0);
            this.txtClosedAnswer.CustomButton.Name = "";
            this.txtClosedAnswer.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtClosedAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClosedAnswer.CustomButton.TabIndex = 1;
            this.txtClosedAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClosedAnswer.CustomButton.UseSelectable = true;
            this.txtClosedAnswer.CustomButton.Visible = false;
            this.txtClosedAnswer.Lines = new string[0];
            this.txtClosedAnswer.Location = new System.Drawing.Point(187, 151);
            this.txtClosedAnswer.MaxLength = 32767;
            this.txtClosedAnswer.Name = "txtClosedAnswer";
            this.txtClosedAnswer.PasswordChar = '\0';
            this.txtClosedAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClosedAnswer.SelectedText = "";
            this.txtClosedAnswer.SelectionLength = 0;
            this.txtClosedAnswer.SelectionStart = 0;
            this.txtClosedAnswer.ShortcutsEnabled = true;
            this.txtClosedAnswer.Size = new System.Drawing.Size(178, 23);
            this.txtClosedAnswer.TabIndex = 7;
            this.txtClosedAnswer.UseSelectable = true;
            this.txtClosedAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClosedAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMultipleChoice
            // 
            // 
            // 
            // 
            this.txtMultipleChoice.CustomButton.Image = null;
            this.txtMultipleChoice.CustomButton.Location = new System.Drawing.Point(49, 0);
            this.txtMultipleChoice.CustomButton.Name = "";
            this.txtMultipleChoice.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtMultipleChoice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMultipleChoice.CustomButton.TabIndex = 1;
            this.txtMultipleChoice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMultipleChoice.CustomButton.UseSelectable = true;
            this.txtMultipleChoice.CustomButton.Visible = false;
            this.txtMultipleChoice.Lines = new string[0];
            this.txtMultipleChoice.Location = new System.Drawing.Point(187, 85);
            this.txtMultipleChoice.MaxLength = 32767;
            this.txtMultipleChoice.Name = "txtMultipleChoice";
            this.txtMultipleChoice.PasswordChar = '\0';
            this.txtMultipleChoice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMultipleChoice.SelectedText = "";
            this.txtMultipleChoice.SelectionLength = 0;
            this.txtMultipleChoice.SelectionStart = 0;
            this.txtMultipleChoice.ShortcutsEnabled = true;
            this.txtMultipleChoice.Size = new System.Drawing.Size(178, 23);
            this.txtMultipleChoice.TabIndex = 6;
            this.txtMultipleChoice.UseSelectable = true;
            this.txtMultipleChoice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMultipleChoice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOpenAnswer
            // 
            // 
            // 
            // 
            this.txtOpenAnswer.CustomButton.Image = null;
            this.txtOpenAnswer.CustomButton.Location = new System.Drawing.Point(49, 0);
            this.txtOpenAnswer.CustomButton.Name = "";
            this.txtOpenAnswer.CustomButton.Size = new System.Drawing.Size(7, 7);
            this.txtOpenAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpenAnswer.CustomButton.TabIndex = 1;
            this.txtOpenAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpenAnswer.CustomButton.UseSelectable = true;
            this.txtOpenAnswer.CustomButton.Visible = false;
            this.txtOpenAnswer.Lines = new string[0];
            this.txtOpenAnswer.Location = new System.Drawing.Point(187, 14);
            this.txtOpenAnswer.MaxLength = 32767;
            this.txtOpenAnswer.Name = "txtOpenAnswer";
            this.txtOpenAnswer.PasswordChar = '\0';
            this.txtOpenAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOpenAnswer.SelectedText = "";
            this.txtOpenAnswer.SelectionLength = 0;
            this.txtOpenAnswer.SelectionStart = 0;
            this.txtOpenAnswer.ShortcutsEnabled = true;
            this.txtOpenAnswer.Size = new System.Drawing.Size(178, 23);
            this.txtOpenAnswer.TabIndex = 5;
            this.txtOpenAnswer.UseSelectable = true;
            this.txtOpenAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOpenAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // lblMultipleChoice
            // 
            this.lblMultipleChoice.AutoSize = true;
            this.lblMultipleChoice.Location = new System.Drawing.Point(46, 90);
            this.lblMultipleChoice.Name = "lblMultipleChoice";
            this.lblMultipleChoice.Size = new System.Drawing.Size(100, 19);
            this.lblMultipleChoice.TabIndex = 3;
            this.lblMultipleChoice.Text = "Multiple Choice";
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
            // frmTipoDePregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 428);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.grdDatos);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmTipoDePregunta";
            this.Padding = new System.Windows.Forms.Padding(6, 60, 6, 7);
            this.Text = "Tipo_de_pregunta";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTypeBindingSource)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.BindingSource questionTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multipleChoiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionsDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtClosedAnswer;
        private MetroFramework.Controls.MetroTextBox txtMultipleChoice;
        private MetroFramework.Controls.MetroTextBox txtOpenAnswer;
        private MetroFramework.Controls.MetroLabel lblClosedAnswer;
        private MetroFramework.Controls.MetroLabel lblMultipleChoice;
        private MetroFramework.Controls.MetroLabel lblOpenAnswer;
    }
}