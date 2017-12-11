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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

       

    Conexion conAgregar = new Conexion();

        public void llenarCbbIngDiagnostico()
        {
            
            for (int i = 0; i < dgvAgregarDiagn.Rows.Count - 1; i++)
            {
                //MessageBox.Show(dgvAgregarDiagn.Rows[i].Cells[0].Value.ToString());
                cbbIngDiagnostico.Items.Add(dgvAgregarDiagn.Rows[i].Cells[0].Value.ToString());
            }
        }

        public void limpiar()
        {
            txtIngRut.Text = txtIngNombre.Text = txtIngMail.Text = txtIngExamen.Text = "";
            dtpIngFecha.ResetText();
            cbbIngDiagnostico.SelectionStart=0;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaExamenA = dtpIngFecha.Value;
            if (verificarRut(txtIngRut.Text) == true)
            {
                conAgregar.AgregarPaciente(txtIngRut.Text, txtIngNombre.Text, txtIngMail.Text, txtIngExamen.Text, cbbIngDiagnostico.SelectedItem.ToString(), fechaExamenA);
                limpiar();
                dgvAgregarPacientes.DataSource = conAgregar.actualizarDgvPacientes();
                conAgregar.cerrarConexion();
            }
            else
            {
                MessageBox.Show("Ingrese un rut valido");
                limpiar();
            }
        }

        private Boolean verificarRut(String rutVer)
        {
            Boolean rutCorrecto = false;
            String rut = rutVer;
            //revisar cuando no se ingresan datos
            String[] rutProvStr = new String[9];
            int i, x, m = 2, suma = 0, dV = 0;
            String DV1 = Convert.ToString(rut.ElementAt(rut.Length - 1));
            try
            {  //filtrar. Se quitan los caracteres 		 innecesarios
                for (i = 0, x = 0; i < rut.Length; i++, x++)
                {

                    if (rut.ElementAt(i) != '.' && rut.ElementAt(i) != '-')
                    {
                        rutProvStr[x] = Convert.ToString(rut.ElementAt(i));
                    }
                    else { x--; }

                }
                //Declaracion de una variable tipo num para guardar el resultado rut
                int[] rutProvInt = new int[x];
                //Se hace el calculo de modulo 11
                i = 0;
                for (int y = (x - 2); y >= 0; y--)
                {
                    if (m > 7) { m = 2; }
                    rutProvInt[i] = Convert.ToInt32(Convert.ToString(rutProvStr[y])) * m;
                    m++;
                    suma = suma + rutProvInt[i];
                    i++;
                }
                dV = suma % 11;
                dV = 11 - dV;
                if (dV == 10 && DV1.Equals("K") || rut.Last().Equals("k"))
                {
                    MessageBox.Show("el Digito verificador es valido");
                    rutCorrecto = true;
                }
                else
                {
                    if (dV == 11 && Convert.ToInt32(DV1) == 0)
                    {
                        MessageBox.Show("el Digito verificador es valido");
                        rutCorrecto = true;
                    }
                    else
                    {
                        if (dV == Convert.ToInt32(DV1))
                        {
                            MessageBox.Show("el Digito verificador es valido");
                            rutCorrecto = true;
                        }
                        else
                        {
                            MessageBox.Show("Digito verificador invalido");
                        }
                    }
                }
            }
            catch (System.FormatException s)
            {
                MessageBox.Show("formato o rut invalido \n" + s);
            }
            return rutCorrecto;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Diagnostico' Puede moverla o quitarla según sea necesario.
            this.diagnosticoTableAdapter.Fill(this.historialMedicoDataSet.Diagnostico);
            // TODO: esta línea de código carga datos en la tabla 'historialMedicoDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.historialMedicoDataSet.Pacientes);
            llenarCbbIngDiagnostico();

        }

       
    }
}
