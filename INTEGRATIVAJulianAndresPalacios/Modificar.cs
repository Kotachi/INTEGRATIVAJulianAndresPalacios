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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        Conexion conModificar = new Conexion();


        public void limpiar()
        {
            txtModDiagnostico.Text = txtModMail.Text = txtModExamen.Text = txtModNombre.Text = txtModRegistro.Text = txtModRut.Text = "";
        }
        
        private void llenarCbbModDiagnostico()
        {
            Agregar frmAgregar = new Agregar();
            for (int i = 0; i < frmAgregar.dgvAgregarDiagn.Rows.Count - 1; i++)
            {
                //MessageBox.Show(dgvAgregarDiagn.Rows[i].Cells[0].Value.ToString());
                cbbModDiagnostico.Items.Add(frmAgregar.dgvAgregarDiagn.Rows[i].Cells[0].Value.ToString());
               
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //int reg;
            DateTime modFecha = dtpModificarFecha.Value;
            try
            {
                int reg = Convert.ToInt32(txtModRegistro.Text);
                conModificar.modificarDatos(reg, txtModRut.Text, txtModNombre.Text, txtModMail.Text, txtModExamen.Text, cbbModDiagnostico.SelectedItem.ToString(), modFecha);
                dgvPacientes.DataSource = conModificar.actualizarDgvPacientes();
                conModificar.cerrarConexion();
                limpiar();
            }
            catch (ArithmeticException ae)
            {
                MessageBox.Show("Error de formato\n" + ae.Message);
            }
            

        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);
            dgvPacientes.DataSource = conModificar.actualizarDgvPacientes();
            conModificar.cerrarConexion();
            llenarCbbModDiagnostico();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = conModificar.actualizarDgvPacientes();
            conModificar.cerrarConexion();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }
    }
}
