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
            tbNuevaC.Text = "";
            int matricula = (int) cmbAlumnos.SelectedValue;
            lstMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno(matricula);
            tbAnteriorC.Text = $"{lstMaterias.SelectedItem}";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }


        private void tbNuevaC_TextChanged(object sender, EventArgs e)
        {
            if (tbNuevaC.Text.Trim().Length > 0)
                btnActualizar.Enabled = true;
            else
                btnActualizar.Enabled = false;
        }

        private void lstMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            tbNuevaC.Text = "";
        }

        //private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
