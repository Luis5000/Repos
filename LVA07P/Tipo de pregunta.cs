using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LVA07P.Data
{
    public partial class frmTipoDePregunta : MetroFramework.Forms.MetroForm
    {
        public frmTipoDePregunta()
        {
            InitializeComponent();
        }
        private void FrmTipoDePregunta_Load(object sender, EventArgs e)
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
            FrmTipoDePregunta_Load(sender, e);
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
        }
    }
}
