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
    public partial class AlumnosMateriasReprobadasForm : Form
    {
        private ControlEscolar controlEscolar;
        public AlumnosMateriasReprobadasForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;

            cmbAlumnos.DisplayMember = "NombreCompletoMatricula";
            cmbAlumnos.ValueMember = "Matricula";
            cmbAlumnos.DataSource = controlEscolar.GetAlumnosReprobados();
        }

        private void AlumnosMateriasReprobadasForm_Load(object sender, EventArgs e)
        {
            int matricula = (int)cmbAlumnos.SelectedValue;
            lstMaterias.DataSource = controlEscolar.GetMateriasReprobadasPorAlumno(matricula);
        }

        private void cmbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int matricula = (int)cmbAlumnos.SelectedValue;
            lstMaterias.DataSource = controlEscolar.GetMateriasReprobadasPorAlumno(matricula);
        }
    }
}
