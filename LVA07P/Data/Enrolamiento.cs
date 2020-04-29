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
    public partial class frmEnrolamiento : MetroFramework.Forms.MetroForm
    {
        public frmEnrolamiento()
        {
            InitializeComponent();
        }
        private void frmEnrolamiento_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                EnrollmentBindingSource.DataSource =
                    dataContext.Enrollment.ToList();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            EnrollmentBindingSource.ResetBindings(false);
            frmEnrolamiento_Load(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Enrollment Enrollment =
                    EnrollmentBindingSource.Current as Enrollment;
                if (Enrollment != null)
                {
                    if (dataContext.Entry<Enrollment>(Enrollment).State == EntityState.Detached)
                        dataContext.Set<Enrollment>().Attach(Enrollment);
                    if (employee.Id == 0)
                        dataContext.Entry<Enrollment>(Enrollment).State = EntityState.Added;
                    else
                        dataContext.Entry<Enrollment>(Enrollment).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Enrollment Enrollment = EnrollmentBindingSource.Current as Enrollment;
            if (Enrollment != null && Enrollment.ImageUrl != null)
                pctFoto.Image = Image.FromFile(Enrollment.ImageUrl);
            else
                pctFoto.Image = null;

        }
    }
}

