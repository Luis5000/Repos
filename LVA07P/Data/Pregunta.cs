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
    public partial class Pregunta : MetroFramework.Forms.MetroForm
    {
        public Pregunta()
        {
            InitializeComponent();
        }
        private void frmPregunta_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                QuestionBindingSource.DataSource =
                    dataContext.Question.ToList();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            QuestionBindingSource.ResetBindings(false);
            frmPregunta_Load(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Question Question =
                    QuestionBindingSource.Current as Question;
                if (Question != null)
                {
                    if (dataContext.Entry<Question>(Question).State == EntityState.Detached)
                        dataContext.Set<Question>().Attach(Question);
                    if (employee.Id == 0)
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
            Question Question = QuestionBindingSource.Current as Question;
            if (Question != null && Question.ImageUrl != null)
                pctFoto.Image = Image.FromFile(Question.ImageUrl);
            else
                pctFoto.Image = null;
        }
    }
}
