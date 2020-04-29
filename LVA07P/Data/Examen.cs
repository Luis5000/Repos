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
    public partial class Examen : MetroFramework.Forms.MetroForm
    {
        public Examen()
        {
            InitializeComponent();
        }
        public partial class frmExamen : MetroFramework.Forms.MetroForm
        {
            public frmExamenes()
            {
                InitializeComponent();
            }

            private void gpbExamen_Enter(object sender, EventArgs e)
            {

            }

            private void btnContinuar_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Examen programado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            private void frmExamen_Load(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    ExamBindingSource.DataSource =
                        dataContext.Exam.ToList();
                }

            }
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Exam Exam =
                        ExamBindingSource.Current as Exam;
                    if (Exam != null)
                    {
                        if (dataContext.Entry<Exam>(Exam).State == EntityState.Detached)
                            dataContext.Set<Exam>().Attach(Course);
                        if (Course.Id == 0)
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
                ExamBindingSource.ResetBindings(false);
                frmExamen_Load(sender, e);
            }
            private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                Exam Exam = ExamBindingSource.Current as Course;
                if (Exam != null && Exam.ImageUrl != null)
                    pctFoto.Image = Image.FromFile(Exam.ImageUrl);
                else
                    pctFoto.Image = null;
            }
        }
    }
}
