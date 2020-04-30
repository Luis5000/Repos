using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmMateria : MetroFramework.Forms.MetroForm
    {
        public frmMateria()
        {
            InitializeComponent();
        }
        private void frmMateria_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                subjectBindingSource.DataSource =
                    dataContext.Subjects.ToList();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Subject Subject =
                    subjectBindingSource.Current as Subject;
                if (Subject != null)
                {
                    if (dataContext.Entry<Subject>(Subject).State == EntityState.Detached)
                        dataContext.Set<Subject>().Attach(Subject);
                    if (Subject.Id == 0)
                        dataContext.Entry<Subject>(Subject).State = EntityState.Added;
                    else
                        dataContext.Entry<Subject>(Subject).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Materia guardada");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            subjectBindingSource.ResetBindings(false);
            frmMateria_Load(sender, e);
        }
        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Subject Subject = subjectBindingSource.Current as Subject;
        }
    }
}

