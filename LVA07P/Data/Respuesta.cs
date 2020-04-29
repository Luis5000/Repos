using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class Respuesta : MetroFramework.Forms.MetroForm
    {
        public Respuesta()
        {
            InitializeComponent();
        }
        private void frmRespuesta_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                ResponseBindingSource.DataSource =
                    dataContext.Response.ToList();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            ResponseBindingSource.ResetBindings(false);
            frmRespuesta_Load(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Response Response =
                    ResponseBindingSource.Current as Response;
                if (Response != null)
                {
                    if (dataContext.Entry<Response>(Response).State == EntityState.Detached)
                        dataContext.Set<Response>().Attach(Response);
                    if (employee.Id == 0)
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
            Response Response = ResponseBindingSource.Current as Response;
            if (Response != null && Response.ImageUrl != null)
                pctFoto.Image = Image.FromFile(Response.ImageUrl);
            else
                pctFoto.Image = null;
        }
    }
}
