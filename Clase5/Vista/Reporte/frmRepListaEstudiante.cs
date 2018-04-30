using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase5.Vista.Reporte
{
    public partial class frmRepListaEstudiante : Form
    {
        public frmRepListaEstudiante()
        {
            InitializeComponent();
        }

        private void frmRepListaEstudiante_Load(object sender, EventArgs e)
        {
            this.sprListaEstudianteTableAdapter.Fill(this.dsFunciones.sprListaEstudiante);
            this.reportViewer1.RefreshReport();
        }
    }
}
