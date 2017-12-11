using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;


namespace INTEGRATIVAJulianAndresPalacios
{
    class Conexion
    {
        public SqlConnection conexionBD;
        private SqlCommand comandos;
        private String urlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\Desktop\\CODIGOS FUENTE\\INTEGRATIVAJulianAndresPalacios\\INTEGRATIVAJulianAndresPalacios\\HistorialMedico.mdf;Integrated Security=True";

        public Conexion()
        {
            try
            {
                conexionBD = new SqlConnection(urlCon);
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error de conexion\n" + se.Message);
            }
        }

        public void abrirConexion()
        {
            try
            {
                conexionBD.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                conexionBD.Close();
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexionBD.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        public void AgregarPaciente(String rut, String nombre, String mail, String examen, String diagnostico, DateTime fechaExamen)
        {
            try
            {
                abrirConexion();
                comandos = new SqlCommand("INSERT INTO Pacientes (Rut,Nombre,Mail,Examen,Diagnostico,FechaExamen) VALUES (@rut, @nombre, @mail, @examen, @diagnostico, @fechaExamen)", conexionBD);
                comandos.Parameters.AddWithValue("@rut", rut);
                comandos.Parameters.AddWithValue("@nombre", nombre);
                comandos.Parameters.AddWithValue("@mail", mail);
                comandos.Parameters.AddWithValue("@examen", examen);
                comandos.Parameters.AddWithValue("@diagnostico", diagnostico);
                comandos.Parameters.AddWithValue("@fechaExamen", fechaExamen);
                int insertOK = comandos.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Datos ingresados");
                }
                cerrarConexion();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error ingresando datos\n" + se.Message);
                cerrarConexion();
            }
        }

        public void eliminarPaciente(int reg /*, String diagnostico, DateTime eliminarFecha*/)
        {

            try
            {
                abrirConexion();
                comandos = new SqlCommand("DELETE FROM Pacientes WHERE Registro = @registro", conexionBD);
                comandos.Parameters.AddWithValue("@registro", reg);
                /*comandos.Parameters.AddWithValue("@diagnostico", diagnostico);
                comandos.Parameters.AddWithValue("@fechaExamen", eliminarFecha);*/
                int insertOK = comandos.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Datos Eliminados");
                }
                cerrarConexion();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error eliminando datos\n" + se.Message);
                cerrarConexion();
            }
        }

        public void modificarDatos(int registro, String rut, String nombre, String mail, String examen, String diagnostico, DateTime modFecha)
        {
            try
            {
                abrirConexion();
                comandos = new SqlCommand("UPDATE Pacientes SET Rut = @rut, Nombre = @nombre, Mail = @mail, Examen = @examen, Diagnostico = @diagnostico, FechaExamen = @fechaExamen WHERE Registro = @registro", conexionBD);
                comandos.Parameters.AddWithValue("@registro", registro);
                comandos.Parameters.AddWithValue("@rut", rut);
                comandos.Parameters.AddWithValue("@nombre", nombre);
                comandos.Parameters.AddWithValue("@mail", mail);
                comandos.Parameters.AddWithValue("@examen", examen);
                comandos.Parameters.AddWithValue("@diagnostico", diagnostico);
                comandos.Parameters.AddWithValue("@fechaExamen", modFecha);
                int insertOK = comandos.ExecuteNonQuery();
                if (insertOK >= 0)
                {
                    MessageBox.Show("Datos Modificados");
                }
                cerrarConexion();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error modificando datos\n" + se.Message);
                cerrarConexion();
            }
        }

        public DataTable actualizarDgvPacientes()
        {
            try
            {
                DataTable dtModPacientes = new DataTable();
                abrirConexion();
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Pacientes", conexionBD);
                dtModPacientes.Clear();
                adaptador.Fill(dtModPacientes);
                return dtModPacientes;
                
            }
            catch (SqlException se)
            {
                MessageBox.Show("Error actualizando tabla\n" + se.Message);
                cerrarConexion();
                return null;
            }
        }
    }
}
