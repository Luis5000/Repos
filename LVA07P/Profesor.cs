using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmProfesor : MetroFramework.Forms.MetroForm
    {
        public frmProfesor()
        {
            InitializeComponent();
        }
            private void frmProfesor_Load(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    ProfessorBindingSource.DataSource =
                        dataContext.Professor.ToList();
                }
                pnlDatos.Enabled = false;
                Professor Professor = ProfessorBindingSource.Current as Professor;
            }
            private void btnAgregar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = true;
                ProfessorBindingSource.Add(new Student());
                ProfessorBindingSource.MoveLast();
                txtNombre.Focus();
            }
            private void btnEditar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = true;
                txtNombre.Focus();
                Professor Professor =
                    ProfessorBindingSource.Current as Professor;
            }
            private void btnEliminar_Click(object sender, EventArgs e)
            {
                if (MetroFramework.MetroMessageBox.Show(this,
                    "¿Deseas el registro del Docente",
                    "Eliminar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    using (DataContext dataContext = new DataContext())
                    {
                        Professor Professor =
                            ProfessorBindingSource.Current as Professor;
                        if (Professor != null)
                        {
                            if (dataContext.Entry<Professor>(Professor).State == EntityState.Detached)
                                dataContext.Set<Professor>().Attach(Professor);
                            dataContext.Entry<Professor>(Professor).State = EntityState.Deleted;
                            dataContext.SaveChanges();
                            MetroFramework.MetroMessageBox.Show(this, "Docente eliminado");
                            ProfessorBindingSource.RemoveCurrent();
                            pnlDatos.Enabled = false;
                        }
                    }
                }
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = false;
                ProfessorBindingSource.ResetBindings(false);
                frmProfesor_Load(sender, e);
            }
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Professor Professor =
                        ProfessorBindingSource.Current as Student;
                    if (Professor != null)
                    {
                        if (dataContext.Entry<Professor>(Professor).State == EntityState.Detached)
                            dataContext.Set<Professor>().Attach(Professor);
                        if (Student.Id == 0)
                            dataContext.Entry<Professor>(Professor).State = EntityState.Added;
                        else
                            dataContext.Entry<Professor>(Professor).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Docente registrado y guardado");
                        grdDatos.Refresh();
                        pnlDatos.Enabled = false;
                    }
                }
            }
            private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                Professor Professor = ProfessorBindingSource.Current as Professor;
            }
    }
}
