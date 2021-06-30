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
    public partial class PromedioParcialForm : Form
    {
        private ControlEscolar controlEscolar;
        public PromedioParcialForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
        }

        private void PromedioParcialForm_Load(object sender, EventArgs e)
        {
            dgvMostrarAlumnos.DataSource = controlEscolar.GetAlumnosPromedioParcial();
        }
    }
}
