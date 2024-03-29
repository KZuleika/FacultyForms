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
    public partial class MostrarAlumnosForm : Form
    {
        private ControlEscolar controlEscolar;
        public MostrarAlumnosForm(ControlEscolar controlEscolar)
        {
            InitializeComponent();
            this.controlEscolar = controlEscolar;
        }

        private void MostrarAlumnosForm_Load(object sender, EventArgs e)
        {
            dgvMostrarAlumnos.DataSource = controlEscolar.GetAlumnos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
