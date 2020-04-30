using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmRespuesta : MetroFramework.Forms.MetroForm
    {
        public frmRespuesta()
        {
            InitializeComponent();
        }
        private void frmRespuesta_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                responseBindingSource.DataSource =
                    dataContext.Responses.ToList();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            responseBindingSource.ResetBindings(false);
            frmRespuesta_Load(sender, e);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Response Response =
                    responseBindingSource.Current as Response;
                if (Response != null)
                {
                    if (dataContext.Entry<Response>(Response).State == EntityState.Detached)
                        dataContext.Set<Response>().Attach(Response);
                    if (Response.Id == 0)
                        dataContext.Entry<Response>(Response).State = EntityState.Added;
                    else
                        dataContext.Entry<Response>(Response).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Respuesta enviada");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Response Response = responseBindingSource.Current as Response;
        }
    }
}
