using System;
using System.Windows.Forms;

namespace Faculty
{
    public partial class AsignarCalificacionesForm : Form
    {
        private ControlEscolar controlEscolar;

        private int claveMat;
        private int nuevaC;
        private string materiaSeleccionada;

        private bool matActualizada = false;
        private bool matError = false;
        
        public AsignarCalificacionesForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
            
            cmbAlumnos.DisplayMember = "ToString()";
            cmbAlumnos.ValueMember = "Matricula";
            cmbAlumnos.DataSource = controlEscolar.GetAlumnos(true);
            }

        private void AsignarCalificacionesForm_Load(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno((int)cmbAlumnos.SelectedValue);
        }

        private void cmbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno((int)cmbAlumnos.SelectedValue);
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
                claveMat = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["Clave"].Value.ToString());
        }

        private void dgvMaterias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                claveMat = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["Clave"].Value.ToString());
                nuevaC = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["NuevaC"].Value.ToString());
                materiaSeleccionada = dgvMaterias.SelectedRows[0].Cells["Materia"].Value.ToString();
                
                if (nuevaC > -1 && nuevaC <= 100) matActualizada = true;
                else matError = true;
            }

        }

        private void dgvMaterias_SelectionChanged(object sender, EventArgs e)
        {
            int matricula = (int)cmbAlumnos.SelectedValue;
            
            if(matActualizada)
            {
                matActualizada = false;
                switch (MessageBox.Show($"¿Desea cambiar la calificación del alumno " 
                                        + $"{cmbAlumnos.SelectedItem} "
                                        + $" en {materiaSeleccionada}"
                                        + $" a {nuevaC}?",
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
                        dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno(matricula);
                        break;
                }
                
            }

            if (matError)
            {
                matError = false;
                switch (MessageBox.Show($"Calificación no permitida "
                                        + $"{cmbAlumnos.SelectedItem} "
                                        + $" en {materiaSeleccionada}"
                                        + $" a {nuevaC}",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error))
                {
                    default:
                    case DialogResult.OK:
                        dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno(matricula);
                        break;
                }

            }
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void dgvMaterias_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl colCalif = (DataGridViewTextBoxEditingControl)e.Control;
            colCalif.KeyPress -= new KeyPressEventHandler(colCalif_KeyPress);
            colCalif.KeyPress += new KeyPressEventHandler(colCalif_KeyPress);
        }
        private void colCalif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }
    }
}
