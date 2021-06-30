using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            cmbAlumnos.DisplayMember = "NombreCompleto";
            cmbAlumnos.ValueMember = "Matricula";
            cmbAlumnos.DataSource = controlEscolar.GetAlumnos(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int matricula = (int) cmbAlumnos.SelectedValue;
            dgvMaterias.DataSource = controlEscolar.MateriasActualizablesPorAlumno(matricula);
            
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
