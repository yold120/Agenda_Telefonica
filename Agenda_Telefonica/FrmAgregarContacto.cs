using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class FrmAgregarContacto : Form
    {
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-2KU2F5N\SQLEXPRESS; database=Cliente; integrated security=true");

        public FrmAgregarContacto()
        {
            InitializeComponent();
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Persona (Nombre,Apellidos) VALUES (@Nombre, @Apellidos)";
            conexion.Open();



            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
            //comando.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
            /*
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
            comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            comando.Parameters.AddWithValue("@Codigo_postal", txtCodigo_postal.Text);
            comando.Parameters.AddWithValue("@Telefono_residencial", txtTelefono_residencial.Text);
            comando.Parameters.AddWithValue("@Telefono_celular", txtTelefono_celular.Text);
            comando.Parameters.AddWithValue("@E-mail", txtEmail.Text);
            comando.Parameters.AddWithValue("@Sexo", txtSexo.Text);
            comando.Parameters.AddWithValue("@Direccion_de_trabajo", txtDireccion_de_trabajo.Text);
            comando.Parameters.AddWithValue("@Fecha_de_nacimiento", txtFecha_de_nacimiento.Text);
            comando.Parameters.AddWithValue("@Estado_civil", txtEstado_civil.Text);
            */

            comando.ExecuteNonQuery();
            MessageBox.Show("insertado");
        }
    }
}
