using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmCurso : MetroFramework.Forms.MetroForm
    {
        public frmCurso()
        {
            InitializeComponent();
        }
            private void frmCursos_Load(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    courseBindingSource.DataSource =
                        dataContext.Courses.ToList();
                }
            }
            private void btnUpdate_Click(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Course Course =
                        courseBindingSource.Current as Course;
                    if (Course != null)
                    {
                        if (dataContext.Entry<Course>(Course).State == EntityState.Detached)
                            dataContext.Set<Course>().Attach(Course);
                        if (Course.Id == 0)
                            dataContext.Entry<Course>(Course).State = EntityState.Added;
                        else
                            dataContext.Entry<Course>(Course).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Curso guardado");
                        grdDatos.Refresh();
                        pnlDatos.Enabled = false;
                    }
                }
            }
            private void btnCancel_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = false;
                courseBindingSource.ResetBindings(false);
                frmCursos_Load(sender, e);
            }
            private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                Course Course = courseBindingSource.Current as Course;
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,
                "¿Quieres eliminar el registro?",
                "Eliminar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Course Course =
                        courseBindingSource.Current as Course;
                    if (Course != null)
                    {
                        if (dataContext.Entry<Course>(Course).State == EntityState.Detached)
                            dataContext.Set<Course>().Attach(Course);
                        dataContext.Entry<Course>(Course).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Empleado eliminado");
                        courseBindingSource.RemoveCurrent();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }


    }
}

