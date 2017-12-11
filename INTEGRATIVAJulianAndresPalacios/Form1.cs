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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
           
        }

        Conexion conPrincipal = new Conexion();

        private void mnAgregar_Click(object sender, EventArgs e)
        {
            Agregar frmAgregar = new Agregar();
            frmAgregar.Show();
            this.Hide();
        }

        private void mnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar frmEliminar = new Eliminar();
            frmEliminar.Show();
            this.Hide();
        }

        private void mnModificar_Click(object sender, EventArgs e)
        {
            Modificar frmModificar = new Modificar();
            frmModificar.Show();
            this.Hide();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);
           /* dgvPrpal.DataSource = conPrincipal.actualizarDgvPacientes();
            conPrincipal.cerrarConexion();*/
            
        }

        private void hISTORIALDEEXAMENESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar frmBuscar = new Buscar();
            frmBuscar.Show();
            this.Hide();
        }

        private void mnBuscarDiagnostico_Click(object sender, EventArgs e)
        {
            BuscarDiagnosticos frmBuscarDiagn = new BuscarDiagnosticos();
            frmBuscarDiagn.Show();
            this.Hide();
        }

        private void fRECUENCIADIAGNOSTICOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrecuenciaDiagnosticos frmFrecDiagn = new FrecuenciaDiagnosticos();
            frmFrecDiagn.Show();
            this.Hide();
        }

        private void btnBuscarRut_Click(object sender, EventArgs e)
        {
            this.pacientesTableAdapter.BUSCAR(this.historialMedicoDataSet.Pacientes, txtMNBuscarRut.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvPrpal.DataSource = conPrincipal.actualizarDgvPacientes();
            conPrincipal.cerrarConexion();
        }
    }
}
