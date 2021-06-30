using System;
using System.Windows.Forms;

namespace Faculty
{
    public partial class AsignarCalificacionesForm : Form
    {
        private ControlEscolar controlEscolar;
        private int claveMat;
        private int nuevaC;
        public AsignarCalificacionesForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
            
            cmbAlumnos.DisplayMember = "ToString()";
            cmbAlumnos.ValueMember = "Matricula";
            cmbAlumnos.DataSource = controlEscolar.GetAlumnos(true);

            lstMaterias.DisplayMember = "ToString()";
            lstMaterias.ValueMember = "Clave";
            lstMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno((int)cmbAlumnos.SelectedValue);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            nupNuevaC.Value = 0;
            //tbNuevaC.Text = "";
            int matricula = (int) cmbAlumnos.SelectedValue;
            lstMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno(matricula);
            tbAnteriorC.Text = $"{lstMaterias.SelectedItem}";
            dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno((int)cmbAlumnos.SelectedValue);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int matricula = (int)cmbAlumnos.SelectedValue;
            int clave = (int)lstMaterias.SelectedValue;
            int calificacion = (int)nupNuevaC.Value;
            controlEscolar.AsignarCalificacion(matricula, clave, calificacion);
            lstMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno(matricula);

            MessageBox.Show($"Se ha actualizado la calificación del alumno {matricula} en {clave} a {calificacion}",
                                 "Calificación asignada",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }



        private void lstMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            nupNuevaC.Value = 0;
            //tbAnteriorC.Text = controlEscolar.GetCalificacion();
        }

        private void nupNuevaC_ValueChanged(object sender, EventArgs e)
        {
            btnActualizar.Enabled = true;
        }

        private void AsignarCalificacionesForm_Load(object sender, EventArgs e)
        {
            dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno((int) cmbAlumnos.SelectedValue);
        }

        private void dgvMaterias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvMaterias.SelectedRows.Count > 0)
                nuevaC = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["NuevaC"].Value.ToString());
            //tbAnteriorC.Text = nuevaC.ToString();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
                claveMat = Convert.ToInt32(dgvMaterias.SelectedRows[0].Cells["Clave"].Value.ToString());
            //tbAnteriorC.Text = claveMat.ToString();
        }

        //private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}


        //private void tbNuevaC_TextChanged(object sender, EventArgs e)
        //{
        //    if (tbNuevaC.Text.Trim().Length > 0)
        //        btnActualizar.Enabled = true;
        //    else
        //        btnActualizar.Enabled = false;
        //}
    }
}
