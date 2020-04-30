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
                SubjectBindingSource.DataSource =
                    dataContext.Subject.ToList();
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Subject Subject =
                    SubjectBindingSource.Current as Subject;
                if (Subject != null)
                {
                    if (dataContext.Entry<Subject>(Subject).State == EntityState.Detached)
                        dataContext.Set<Subject>().Attach(Course);
                    if (Course.Id == 0)
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
            SubjectBindingSource.ResetBindings(false);
            frmCourse(sender, e);
        }
        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Subject Subject = SubjectBindingSource.Current as Subject;
            if (Subject != null && frmCurso.ImageUrl != null)
                pctFoto.Image = Image.FromFile(Subject.ImageUrl);
            else
                pctFoto.Image = null;
        }
    }
}

