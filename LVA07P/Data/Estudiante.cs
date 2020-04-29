﻿using System;
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
    public partial class Estudiante : MetroFramework.Forms.MetroForm
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        private void mtlEmail_Click(object sender, EventArgs e)
        {

        }
        public partial class frmEstudiantes : MetroFramework.Forms.MetroForm
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }
        private void frmEstudiantes_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctFoto.Image = null;
            StudentBindingSource.Add(new Student());
            StudentBindingSource.MoveLast();
            txtNombre.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtNombre.Focus();
            Student Student =
                StudentBindingSource.Current as Student;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MetroFramework.MetroMessageBox.Show(this,
                "¿Deseas eliminar el siguiente estudiante?",
                "Eliminar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question)==DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Student Student =
                        StudentBindingSource.Current as Student;
                    if(Student!=null)
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
            frmEstudiantes_Load(sender, e);
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
