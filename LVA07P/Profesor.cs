using System;
using System.Data.Entity;
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
                    professorBindingSource.DataSource =
                        dataContext.Professors.ToList();
                }
                pnlDatos.Enabled = false;
                Professor Professor = professorBindingSource.Current as Professor;
            }
            private void btnAgregar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = true;
                professorBindingSource.Add(new Student());
                professorBindingSource.MoveLast();
                txtName.Focus();
            }
            private void btnEditar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = true;
                txtName.Focus();
                Professor Professor =
                    professorBindingSource.Current as Professor;
            }
            private void btnCancelar_Click(object sender, EventArgs e)
            {
                pnlDatos.Enabled = false;
                professorBindingSource.ResetBindings(false);
                frmProfesor_Load(sender, e);
            }
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Professor Professor =
                        professorBindingSource.Current as Professor;
                    if (Professor != null)
                    {
                        if (dataContext.Entry<Professor>(Professor).State == EntityState.Detached)
                            dataContext.Set<Professor>().Attach(Professor);
                        if (Professor.Id == 0)
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
                Professor Professor = professorBindingSource.Current as Professor;
            }

        private void btnEliminar_Click_1(object sender, EventArgs e)
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
                        professorBindingSource.Current as Professor;
                    if (Professor != null)
                    {
                        if (dataContext.Entry<Professor>(Professor).State == EntityState.Detached)
                            dataContext.Set<Professor>().Attach(Professor);
                        dataContext.Entry<Professor>(Professor).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Docente eliminado");
                        professorBindingSource.RemoveCurrent();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }
    }
}
