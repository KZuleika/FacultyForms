﻿using System;
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
    public partial class MainForm : Form
    {
        private ControlEscolar controlEscolar;

        public MainForm()
        {
            InitializeComponent();
            controlEscolar = new ControlEscolar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlEscolar.Close();
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarAlumnosForm form = new MostrarAlumnosForm(controlEscolar);
            form.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMateriasForm form = new MostrarMateriasForm(controlEscolar);
            form.ShowDialog();
        }

        private void altaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAlumnosForm form = new AltaAlumnosForm(controlEscolar);
            form.ShowDialog();
        }

        private void altaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarCalificacionesForm form = new AsignarCalificacionesForm();
            form.ShowDialog();
        }
    }
}
