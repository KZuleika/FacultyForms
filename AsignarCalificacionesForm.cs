﻿using System;
using System.Windows.Forms;

namespace Faculty
{
    public partial class AsignarCalificacionesForm : Form
    {
        private ControlEscolar controlEscolar;
        private int claveMat;
        private int nuevaC;
        private bool matActualizada = false;
        public AsignarCalificacionesForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
            
            cmbAlumnos.DisplayMember = "ToString()";
            cmbAlumnos.ValueMember = "Matricula";
            cmbAlumnos.DataSource = controlEscolar.GetAlumnos(true);
            }

        public AsignarCalificacionesForm(ControlEscolar controlEscolar, int alumnoSeleccionado)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;

            cmbAlumnos.DisplayMember = "ToString()";
            cmbAlumnos.ValueMember = "Matricula";
            cmbAlumnos.DataSource = controlEscolar.GetAlumnos(true);
            cmbAlumnos.SelectedValue = alumnoSeleccionado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int matricula = (int) cmbAlumnos.SelectedValue;
            dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno((int)cmbAlumnos.SelectedValue);
        }

        private void AsignarCalificacionesForm_Load(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno((int) cmbAlumnos.SelectedValue);
        }

        private void dgvMaterias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvMaterias.SelectedRows.Count > 0)
            {
                claveMat = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["Clave"].Value.ToString());
                nuevaC = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["NuevaC"].Value.ToString());
                matActualizada = true;
            }
            //tbAnteriorC.Text = nuevaC.ToString();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
                claveMat = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["Clave"].Value.ToString());
            //tbAnteriorC.Text = claveMat.ToString();
        }

        private void dgvMaterias_SelectionChanged(object sender, EventArgs e)
        {
            int matricula = (int)cmbAlumnos.SelectedValue;
            if(matActualizada)
            {
                matActualizada = false;
                switch (MessageBox.Show($"¿Desea cambiar la calificación del alumno {matricula} en {claveMat} a {nuevaC}?",
                                 "Confirmación",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        controlEscolar.AsignarCalificacion(matricula, claveMat, nuevaC);
                        dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno(matricula);
                        break;
                    default:
                    case DialogResult.No:
                        Close();
                        AsignarCalificacionesForm form = new AsignarCalificacionesForm(controlEscolar, matricula);
                        form.ShowDialog();
                        break;
                }
                
            }
            
        }

    }
}
