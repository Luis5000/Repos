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
    public partial class frmMateria : MetroFramework.Forms.MetroForm
    {
        public frmMateria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Deseas Guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            MessageBox.Show("No Hay cambios hasta finalizar el curso escolar, ¿Seguro de Guardar?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
         
    }
}
