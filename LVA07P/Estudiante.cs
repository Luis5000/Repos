using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace LVA07P.Data
{
    public partial class frmEstudiante : MetroFramework.Forms.MetroForm
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }
        private void MtlEmail_Click(object sender, EventArgs e)
        {

        }
        public partial class FrmEstudiantes : MetroFramework.Forms.MetroForm
        {
            private void FrmEstudiantes_Load(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    StudentBindingSource.DataSource =
                        dataContext.Student.ToList();
                }
                pnlDatos.Enabled = false;
                Student Student = StudentBindingSource.Current as Student;
                if (Student != null && Student.ImageUrl != null)
                    pctFoto.Image = Image.FromFile(Student.ImageUrl);
                else
                    pctFoto.Image = null;
            }
            private void BtnAgregar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = true;
                pctFoto.Image = null;
                StudentBindingSource.Add(new Student());
                StudentBindingSource.MoveLast();
                txtName.Focus();
            }
            private void btnEditar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = true;
                txtName.Focus();
                Student Student = StudentBindingSource.Current as Student;
            }
            private void btnEliminar_Click(object sender, EventArgs e)
            {
                if (MetroFramework.MetroMessageBox.Show(this,
                    "¿Deseas eliminar el siguiente estudiante?",
                    "Eliminar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    using (DataContext dataContext = new DataContext())
                    {
                        Student Student =
                            StudentBindingSource.Current as Student;
                        if (Student != null)
                        {
                            if (dataContext.Entry<Student>(Student).State == EntityState.Detached)
                                dataContext.Set<Student>().Attach(Student);
                            dataContext.Entry<Student>(Student).State = EntityState.Deleted;
                            dataContext.SaveChanges();
                            MetroFramework.MetroMessageBox.Show(this, "Estudiante eliinado");
                            StudentBindingSource.RemoveCurrent();
                            pctFoto.Image = null;
                            pnlDatos.Enabled = false;
                        }
                    }
                }
            }
            private void btnCancelar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = false;
                StudentBindingSource.ResetBindings(false);
                FrmEstudiantes_Load(sender, e);
            }
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Student Student =
                        StudentBindingSource.Current as Student;
                    if (Student != null)
                    {
                        if (dataContext.Entry<Student>(Student).State == EntityState.Detached)
                            dataContext.Set<Student>().Attach(Student);
                        if (Student.Id == 0)
                            dataContext.Entry<Student>(Student).State = EntityState.Added;
                        else
                            dataContext.Entry<Student>(Student).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Estudiante registrado y guardado");
                        grdDatos.Refresh();
                        pnlDatos.Enabled = false;
                    }
                }
            }
            private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                Student Student = StudentBindingSource.Current as Student;
                if (Student != null && Student.ImageUrl != null)
                    pctFoto.Image = Image.FromFile(Student.ImageUrl);
                else
                    pctFoto.Image = null;
            }
        }
        private void pctFoto_Click(object sender, EventArgs e)
        {

        }
    }
}