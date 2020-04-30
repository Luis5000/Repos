using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmPregunta : MetroFramework.Forms.MetroForm
    {
        public frmPregunta()
        {
            InitializeComponent();
        }
        private void frmPregunta_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                questionBindingSource.DataSource =
                    dataContext.Questions.ToList();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            questionBindingSource.ResetBindings(false);
            frmPregunta_Load(sender, e);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Question Question =
                    questionBindingSource.Current as Question;
                if (Question != null)
                {
                    if (dataContext.Entry<Question>(Question).State == EntityState.Detached)
                        dataContext.Set<Question>().Attach(Question);
                    if (Question.Id == 0)
                        dataContext.Entry<Question>(Question).State = EntityState.Added;
                    else
                        dataContext.Entry<Question>(Question).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Pregunta de Examen enviada");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }
        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Question Question = questionBindingSource.Current as Question;
        }
    }
}
