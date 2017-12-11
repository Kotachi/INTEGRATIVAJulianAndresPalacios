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
    public partial class FrecuenciaDiagnosticos : Form
    {
        public FrecuenciaDiagnosticos()
        {
            InitializeComponent();
        }

        Conexion conFrecDiagn = new Conexion();
        SqlCommand comandoFrec;



        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void FrecuenciaDiagnosticos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);

        }

        public DataTable actualizarDTFrecuencia(String diagn, DateTime fecha1, DateTime fecha2)
        {
            try
            {
                DataTable dtModPacientes = new DataTable();
                conFrecDiagn.abrirConexion();
                //comandoFrec = new SqlCommand("SELECT count(Diagnostico) FROM Pacientes WHERE Diagnostico = @diagnostico");
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = new SqlCommand("SELECT count(Diagnostico) FROM Pacientes WHERE Diagnostico = @diagnostico AND FechaExamen BETWEEN @fecha1 AND @fecha2",conFrecDiagn.conexionBD);
                adaptador.SelectCommand.Parameters.AddWithValue("@fecha2", fecha2);
                adaptador.SelectCommand.Parameters.AddWithValue("@fecha1", fecha1);
                adaptador.SelectCommand.Parameters.AddWithValue("@diagnostico",diagn);
                dtModPacientes.Clear();
                adaptador.Fill(dtModPacientes);
                conFrecDiagn.cerrarConexion();
                return dtModPacientes;

            }
            catch (SqlException se)
            {
                MessageBox.Show("Error actualizando tabla\n" + se.Message);
                conFrecDiagn.cerrarConexion();
                return null;
            }
        }

        private void btnFrecuencia_Click(object sender, EventArgs e)
        {
            dgvFrecuenciaDiagn.DataSource = actualizarDTFrecuencia(cbbFrecDiagn.SelectedItem.ToString(),Convert.ToDateTime(txtFrecFecha1.Text),Convert.ToDateTime(txtFrecFecha2.Text));
        }
    }
}
