using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class Curso : MetroFramework.Forms.MetroForm
    {
        public Curso()
        {
            InitializeComponent();
        }
        public partial class frmCursos : MetroFramework.Forms.MetroForm
        {
            public frmCursos()
            {
                InitializeComponent();
            }
            private void frmCursos_Load(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    CourseBindingSource.DataSource =
                        dataContext.Course.ToList();
                }

            }
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Course Course =
                        CourseBindingSource.Current as Course;
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
            private void btnCancelar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = false;
                CourseBindingSource.ResetBindings(false);
                frmCursos(sender, e);
            }
            private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                Course Course = CourseBindingSource.Current as Course;
                if (Course != null && Curso.ImageUrl != null)
                    pctFoto.Image = Image.FromFile(Curso.ImageUrl);
                else
                    pctFoto.Image = null;
            }

        }
    }
}
