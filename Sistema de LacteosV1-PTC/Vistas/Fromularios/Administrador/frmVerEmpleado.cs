using Modelos.Conexion;
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

namespace Vistas.Fromularios.Administrador
{
    public partial class frmVerEmpleado : Form
    {
        

        public frmVerEmpleado()
        {
            InitializeComponent();

        }
        private void MostrarTdosLosEmpleados()
        {
            ConexionDB conexionDB = new ConexionDB();
            conexionDB.conexion.Open();
            string consulta = "SELECT idUsuario, nombreUsuario, correoElectronico, contraseña FROM Usuarios WHERE id_Rol = 32";

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionDB.conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dvgEmpleados.DataSource = tabla;

            conexionDB.cerrar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            string valorBuscado = txtBuscar.Text;

            if (valorBuscado != "")
            {
                conexionDB.conexion.Open();
                string consulta = "SELECT idUsuario, nombreUsuario, correoElectronico, contraseña FROM Usuarios WHERE id_Rol = 32 AND (nombreUsuario = @valor OR idUsuario = @valorID)";

                SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
                comando.Parameters.AddWithValue("@valor", valorBuscado);
                comando.Parameters.AddWithValue("@valorID", valorBuscado);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dvgEmpleados.DataSource = tabla;
                dvgEmpleados.AutoGenerateColumns = true;

                conexionDB.cerrar();
            }
            else
            {
                MessageBox.Show("Escribi un nombre de usuario o un id.");
            }

        }



        private void frmVerEmpleado_Load(object sender, EventArgs e)
        {

            MostrarTdosLosEmpleados();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarTdosLosEmpleados();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            if (dvgEmpleados.SelectedRows.Count > 0)
            {
                string idSeleccionado = dvgEmpleados.SelectedRows[0].Cells["idUsuario"].Value.ToString();

                conexionDB.conexion.Open();

                string consulta = "DELETE FROM Usuarios WHERE idUsuario = @id";
                SqlCommand comando = new SqlCommand(consulta, conexionDB.conexion);
                comando.Parameters.AddWithValue("@id", idSeleccionado);
                comando.ExecuteNonQuery();

                conexionDB.cerrar();

                MessageBox.Show("Empleado eliminado correctamente.");

                MostrarTdosLosEmpleados();
            }
            else
            {
                MessageBox.Show("Seleccioná un empleado para eliminar.");
            }

        }
    }
}
