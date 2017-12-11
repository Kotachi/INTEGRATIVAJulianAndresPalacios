using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEGRATIVAJulianAndresPalacios
{
    public partial class BuscarDiagnosticos : Form
    {
        public BuscarDiagnosticos()
        {
            InitializeComponent();
        }

        private void BuscarDiagnosticos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);

        }

        private void historialDiagnosticosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacientesTableAdapter.HistorialDiagnosticos(this.historialMedicoDataSet.Pacientes, rutToolStripTextBox.Text, fecha1ToolStripTextBox.Text, fecha2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }
    }
}
