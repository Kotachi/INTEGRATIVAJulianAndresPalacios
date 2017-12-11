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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
           
        }

        Conexion conEliminar = new Conexion();

        public void limpiar()
        {
            txtEliRut.Text = txtEliDiagnostico.Text = "";
            dtpEliminarFecha.ResetText();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DateTime eliminarFecha = dtpEliminarFecha.Value;
            int reg = Convert.ToInt32(txtEliRut.Text);
            conEliminar.eliminarPaciente(reg /*, txtEliDiagnostico.Text, eliminarFecha*/);
            dgvEliRegistros.DataSource = conEliminar.actualizarDgvPacientes();
            conEliminar.cerrarConexion();
            limpiar();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);
            dgvEliRegistros.DataSource = conEliminar.actualizarDgvPacientes();
            conEliminar.cerrarConexion();
        }
    }
}
