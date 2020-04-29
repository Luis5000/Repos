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
    public partial class Tipo_de_pregunta : MetroFramework.Forms.MetroForm
    {
        public Tipo_de_pregunta()
        {
            InitializeComponent();
        }
         private void frmTipo_de_pregunta_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                QuestionTypeBindingSource.DataSource =
                    dataContext.QuestionType.ToList();
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            QuestionTypeBindingSource.ResetBindings(false);
            frmTipo_de_pregunta_Load(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                QuestionType QuestionType =
                    QuestionTypeBindingSource.Current as QuestionType;
                if (QuestionType != null)
                {
                    if (dataContext.Entry<QuestionType>(QuestionType).State == EntityState.Detached)
                        dataContext.Set<QuestionType>().Attach(QuestionType);
                    if (employee.Id == 0)
                        dataContext.Entry<QuestionType>(QuestionType).State = EntityState.Added;
                    else
                        dataContext.Entry<QuestionType>(QuestionType).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Guardado");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QuestionType QuestionType = QuestionTypeBindingSource.Current as QuestionType;
            if (QuestionType != null && QuestionType.ImageUrl != null)
                pctFoto.Image = Image.FromFile(QuestionType.ImageUrl);
            else
                pctFoto.Image = null;
    }
}
