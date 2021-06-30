using System;
using System.Windows.Forms;

namespace Faculty
{
    public partial class AsignarCalificacionesForm : Form
    {
        private ControlEscolar controlEscolar;
        public AsignarCalificacionesForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;

            cmbAlumnos.DisplayMember = "NombreCompletoMatricula";
            cmbAlumnos.ValueMember = "Matricula";
            cmbAlumnos.DataSource = controlEscolar.GetAlumnos(true);

            lstMaterias.DisplayMember = "NombreConClave";
            lstMaterias.ValueMember = "Clave";
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
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            controlEscolar.AsignarCalificacion((int)cmbAlumnos.SelectedValue, (int) lstMaterias.SelectedValue, (int) nupNuevaC.Value);
            lstMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno((int)cmbAlumnos.SelectedValue);

            MessageBox.Show($"Se ha actualizado la calificación del alumno {cmbAlumnos.SelectedValue} en {lstMaterias.SelectedValue} a {nupNuevaC.Value}",
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
