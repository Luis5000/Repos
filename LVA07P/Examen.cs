using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmExamen : MetroFramework.Forms.MetroForm
    {
        public frmExamen()
        {
            InitializeComponent();
        }
            private void btnContinuar_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Examen programado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            private void frmExamen_Load(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    examBindingSource.DataSource =
                        dataContext.Exams.ToList();
                }
            }
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Exam Exam =
                        examBindingSource.Current as Exam;
                    if (Exam != null)
                    {
                        if (dataContext.Entry<Exam>(Exam).State == EntityState.Detached)
                            dataContext.Set<Exam>().Attach(Exam);
                        if (Exam.Id == 0)
                            dataContext.Entry<Exam>(Exam).State = EntityState.Added;
                        else
                            dataContext.Entry<Exam>(Exam).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Examen guardado");
                        grdDatos.Refresh();
                        pnlDatos.Enabled = false;
                    }
                }
            }
            private void btnCancelar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = false;
                examBindingSource.ResetBindings(false);
                frmExamen_Load(sender, e);
            }
            private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                Exam Exam = examBindingSource.Current as Exam;
            }
    }
}
