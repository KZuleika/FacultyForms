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
    public partial class PromedioTotalForm : Form
    {
        private ControlEscolar controlEscolar;
        public PromedioTotalForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
        }

        private void PromedioTotalForm_Load(object sender, EventArgs e)
        {
            dgvMostrarAlumnos.DataSource = controlEscolar.GetAlumnosPromedioTotal();
        }
    }
}
