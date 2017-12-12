using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        Conexion conHisDiagn = new Conexion();
        SqlCommand comandoHis;

        private void BuscarDiagnosticos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);

        }

        private void historialDiagnosticosToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.pacientesTableAdapter.HistorialDiagnosticos(this.historialMedicoDataSet.Pacientes, rutToolStripTextBox.Text, fecha1ToolStripTextBox.Text, fecha2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/
            DateTime fecha1 = Convert.ToDateTime(fecha1ToolStripTextBox.Text);
            DateTime fecha2 = Convert.ToDateTime(fecha2ToolStripTextBox.Text);
            dgvHisDiagn.DataSource =  historialDiagnostico(rutToolStripTextBox.Text,cbbDiagnBus.SelectedItem.ToString(), fecha1,fecha2);
            conHisDiagn.cerrarConexion();

        }

        private DataTable historialDiagnostico(String rut, String diagn, DateTime fecha1, DateTime fecha2)
        {
            try
            {
                DataTable dtModPacientes = new DataTable();
                conHisDiagn.abrirConexion();
                //comandoFrec = new SqlCommand("SELECT count(Diagnostico) FROM Pacientes WHERE Diagnostico = @diagnostico");
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = new SqlCommand("SELECT * FROM Pacientes WHERE Rut = @rut AND Diagnostico = @diagnostico AND FechaExamen BETWEEN @fecha1 AND @fecha2 ORDER BY Diagnostico", conHisDiagn.conexionBD);
                adaptador.SelectCommand.Parameters.AddWithValue("@fecha2", fecha2);
                adaptador.SelectCommand.Parameters.AddWithValue("@fecha1", fecha1);
                adaptador.SelectCommand.Parameters.AddWithValue("@rut", rut);
                adaptador.SelectCommand.Parameters.AddWithValue("@diagnostico", diagn);

                dtModPacientes.Clear();
                adaptador.Fill(dtModPacientes);
                conHisDiagn .cerrarConexion();
                return dtModPacientes;

            }
            catch (SqlException se)
            {
                MessageBox.Show("Error actualizando tabla\n" + se.Message);
                conHisDiagn .cerrarConexion();
                return null;
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
