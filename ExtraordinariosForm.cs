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
    public partial class ExtraordinariosForm : Form
    {
        private ControlEscolar controlEscolar;
        public ExtraordinariosForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
        }

        private void ExtraordinariosForm_Load(object sender, EventArgs e)
        {
            dgvExtraordinarios.DataSource = controlEscolar.GetExtraordinarios();
        }
    }
}
