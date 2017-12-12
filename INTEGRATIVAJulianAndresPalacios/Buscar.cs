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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        Conexion conHisExa = new Conexion();

        private void Buscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);

        }

        //Busqueda de paciente ordenando por fecha
        private void historialExamenesToolStripButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.pacientesTableAdapter.HistorialExamenes(this.historialMedicoDataSet.Pacientes, rutToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/
            dgvHistExam.DataSource = historialExamenes(rutToolStripTextBox.Text);
            conHisExa.cerrarConexion();
            limpiar();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private DataTable historialExamenes (String rut)
        {
            try
            {
                DataTable dtModPacientes = new DataTable();
                conHisExa.abrirConexion();
                //comandoFrec = new SqlCommand("SELECT count(Diagnostico) FROM Pacientes WHERE Diagnostico = @diagnostico");
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = new SqlCommand("SELECT * FROM Pacientes WHERE Rut = @rut ORDER BY FechaExamen", conHisExa.conexionBD);
                adaptador.SelectCommand.Parameters.AddWithValue("@rut", rut);

                dtModPacientes.Clear();
                adaptador.Fill(dtModPacientes);
                conHisExa.cerrarConexion();
                return dtModPacientes;

            }
            catch (SqlException se)
            {
                MessageBox.Show("Error actualizando tabla\n" + se.Message);
                conHisExa.cerrarConexion();
                return null;
            }
        }

        public void limpiar()
        {
            rutToolStripTextBox.Text = "";
        }
    }
}
