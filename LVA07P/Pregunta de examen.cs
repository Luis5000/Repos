using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmPreguntaDeExamen : MetroFramework.Forms.MetroForm
    {
        public frmPreguntaDeExamen()
        {
            InitializeComponent();
        }
        private void FrmPreguntaDeExamen_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                examQuestionBindingSource.DataSource =
                    dataContext.ExamQuestions.ToList();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            examQuestionBindingSource.ResetBindings(false);
            FrmPreguntaDeExamen_Load(sender, e);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                ExamQuestion ExamQuestion =
                    examQuestionBindingSource.Current as ExamQuestion;
                if (ExamQuestion != null)
                {
                    if (dataContext.Entry<ExamQuestion>(ExamQuestion).State == EntityState.Detached)
                        dataContext.Set<ExamQuestion>().Attach(ExamQuestion);
                    if (ExamQuestion.Id == 0)
                        dataContext.Entry<ExamQuestion>(ExamQuestion).State = EntityState.Added;
                    else
                        dataContext.Entry<ExamQuestion>(ExamQuestion).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Pregunta de Examen guardada");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }
        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExamQuestion ExamQuestion = examQuestionBindingSource.Current as ExamQuestion;
        }
    }
}
