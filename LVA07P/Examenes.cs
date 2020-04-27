using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVA07P
{
    public partial class frmExamenes : MetroFramework.Forms.MetroForm
    {
        public frmExamenes()
        {
            InitializeComponent();
        }

        private void gpbExamenes_Enter(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Examen programado con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
