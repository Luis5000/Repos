using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmPreguntaDeExamen : MetroFramework.Forms.MetroForm
    {
        public frmPreguntaDeExamen()
        {
            InitializeComponent();
        }
        private void frmPregunta_de_examen_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                ExamQuestionBindingSource.DataSource =
                    dataContext.ExamQuestion.ToList();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            ExamQuestionBindingSource.ResetBindings(false);
            frmPregunta_de_examen_Load(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                ExamQuestion ExamQuestion =
                    ExamQuestionBindingSource.Current as ExamQuestion;
                if (ExamQuestion != null)
                {
                    if (dataContext.Entry<ExamQuestion>(ExamQuestion).State == EntityState.Detached)
                        dataContext.Set<ExamQuestion>().Attach(ExamQuestion);
                    if (employee.Id == 0)
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
            ExamQuestion ExamQuestion = ExamQuestionBindingSource.Current as ExamQuestion;
            if (ExamQuestion != null && ExamQuestion.ImageUrl != null)
                pctFoto.Image = Image.FromFile(ExamQuestion.ImageUrl);
            else
                pctFoto.Image = null;
        }

        private void frmPreguntaDeExamen_Load(object sender, EventArgs e)
        {

        }
    }
}
