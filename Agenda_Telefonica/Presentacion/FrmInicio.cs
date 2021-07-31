using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Agenda_Telefonica.Datos;
using Agenda_Telefonica.Entidades;



namespace Agenda_Telefonica
{
    public partial class FrmInicio : Form
    {
        private static DataTable dt = new DataTable();
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = FContacto.GetAll();

                dt = ds.Tables[0];
                dgvContactos2.DataSource = dt;
                // dgvClientes.Enabled = false;
                if (dt.Rows.Count > 0)
                {
                    lblDatosNoEncontrados.Visible = false;
                    btnEliminar.Visible = false;
                    lblEliminar.Visible = false;
                    btnCancelar.Visible = false;
                    lblCancelar.Visible = false;
                    btnGrabar.Visible = false;
                    lblGrabar.Visible = false;

                    lblrequerido1.Visible = false;
                    lblrequerido2.Visible = false;
                    lblrequerido3.Visible = false;
                    lblrequerido4.Visible = false;
                    lblrequerido5.Visible = false;
                    lblrequerido6.Visible = false;
                    lblrequerido7.Visible = false;
                    lblrequerido8.Visible = false;

                    dgvContactos2_CellClick(null, null);


                    this.dgvContactos2.Columns["Codigo"].Visible = false;
                    this.dgvContactos2.Columns["Nombre"].Visible = true;
                    this.dgvContactos2.Columns["Apellidos"].Visible = true;
                    this.dgvContactos2.Columns["Direccion"].Visible = false;
                    this.dgvContactos2.Columns["Codigopostal"].Visible = false;
                    this.dgvContactos2.Columns["Telefonoresidencial"].Visible = false;
                    this.dgvContactos2.Columns["Telefonocelular"].Visible = true;
                    this.dgvContactos2.Columns["Email"].Visible = true;
                    this.dgvContactos2.Columns["Sexo"].Visible = false;
                    this.dgvContactos2.Columns["Direcciondetrabajo"].Visible = false;
                    this.dgvContactos2.Columns["Fechadenacimiento"].Visible = false;
                    this.dgvContactos2.Columns["Estadocivil"].Visible = false;

                }
                else
                {
                    lblDatosNoEncontrados.Visible = true;
                }

                MostrarGuardarCancelar(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = ValidarDatos();

                if (sResultado == "")
                {
                    if (txtCodigo.Text == "")
                    {
                        Contacto contacto = new Contacto();
                        contacto.Nombre = txtNombre.Text;
                        contacto.Apellidos = txtApellidos.Text;
                        contacto.Direccion = txtDireccion.Text;
                        contacto.Codigopostal = txtCodigopostal.Text;
                        contacto.Telefonoresidencial = txtTelefonoresidencial.Text;
                        contacto.Telefonocelular = txtTelefonocelular.Text;
                        contacto.Email = txtEmail.Text;
                        contacto.Sexo = txtSexo.Text;
                        contacto.Direcciondetrabajo = txtDirecciondetrabajo.Text;
                        contacto.Fechadenacimiento = txtFechadenacimiento.Text;
                        contacto.Estadocivil = txtEstadocivil.Text;


                        if (FContacto.Insertar(contacto) > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente");
                            FrmInicio_Load(null, null);
                        }
                    }
                    else
                    {
                        Contacto contacto = new Contacto();
                        contacto.Codigo = Convert.ToInt32(txtCodigo.Text);
                        contacto.Nombre = txtNombre.Text;
                        contacto.Apellidos = txtApellidos.Text;
                        contacto.Direccion = txtDireccion.Text;
                        contacto.Codigopostal = txtCodigopostal.Text;
                        contacto.Telefonoresidencial = txtTelefonoresidencial.Text;
                        contacto.Telefonocelular = txtTelefonocelular.Text;
                        contacto.Email = txtEmail.Text;
                        contacto.Sexo = txtSexo.Text;
                        contacto.Direcciondetrabajo = txtDirecciondetrabajo.Text;
                        contacto.Fechadenacimiento = txtFechadenacimiento.Text;
                        contacto.Estadocivil = txtEstadocivil.Text;

                        if (FContacto.Actualizar(contacto) == 1)
                        {
                            MessageBox.Show("Datos Modificados correctamente");
                            FrmInicio_Load(null, null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan cargar Datos: \n" + sResultado);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        public string ValidarDatos()
        {
            //se validan los datos, demanera que no puedan estar en blanco los siguientes...
            string Resultado = "";
            if (txtNombre.Text == "")
            {
                Resultado = Resultado + " Nombre \n";
            }
            if (txtApellidos.Text == "")
            {
                Resultado = Resultado + "Apellidos \n";
            }
            if (txtDireccion.Text == "")
            {
                Resultado = Resultado + " Direccion \n";
            }
            if (txtCodigopostal.Text == "")
            {
                Resultado = Resultado + "Codigopostal \n";
            }
            if (txtTelefonoresidencial.Text == "")
            {
                Resultado = Resultado + "Telefonoresidencial \n";
            }
            
            if (txtSexo.Text == "")
            {
                Resultado = Resultado + " Sexo \n";
            }
            
            if (txtFechadenacimiento.Text == "")
            {
                Resultado = Resultado + " Fechadenacimiento \n";
            }
            if (txtEstadocivil.Text == "")
            {
                Resultado = Resultado + " Estadocivil \n";
            }


            return Resultado;
        }

        public void MostrarGuardarCancelar(bool b)
        {
            //btnGuardar.Visible = b;
            //btnCancelar.Visible = b;
            //btnNuevo.Visible = !b;
            //btnEditar.Visible = !b;
            


            //grupo2.Visible = !b;


            txtNombre.Enabled = b;
            txtApellidos.Enabled = b;
            txtDireccion.Enabled = b;
            txtCodigopostal.Enabled = b;
            txtTelefonoresidencial.Enabled = b;
            txtTelefonocelular.Enabled = b;
            txtEmail.Enabled = b;
            txtSexo.Enabled = b;
            txtDirecciondetrabajo.Enabled = b;
            txtFechadenacimiento.Enabled = b;
            txtEstadocivil.Enabled = b;



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);

            btnEliminar.Visible = false;
            lblEliminar.Visible = false;
            btnCancelar.Visible = false;
            lblCancelar.Visible = false;
            btnGrabar.Visible = false;
            lblGrabar.Visible = false;

            lblrequerido1.Visible = false;
            lblrequerido2.Visible = false;
            lblrequerido3.Visible = false;
            lblrequerido4.Visible = false;
            lblrequerido5.Visible = false;
            lblrequerido6.Visible = false;
            lblrequerido7.Visible = false;
            lblrequerido8.Visible = false;

            btnPantallaAgregar.Enabled = true;
            dgvContactos2.Enabled = true;
            btnPantallaEditar.Enabled = true;
            dgvContactos2_CellClick(null, null);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            try
            {
                
                if (MessageBox.Show("¿Realmente desea eliminar los clientes seleccionados?", "Eliminacion de Cliente",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    foreach (DataGridViewRow row in dgvContactos2.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Contacto contacto = new Contacto();
                            contacto.Codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
                            if (FContacto.Eliminar(contacto) != 1)
                            {
                                MessageBox.Show("El cliente no pudo ser eliminado", "Eliminacion de Cliente",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }

                    FrmInicio_Load(null, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy());
                dv.RowFilter = cmbBuscar.Text + " Like '" + txtBuscar.Text + "%'";

                dgvContactos2.DataSource = dv;

                if (dv.Count == 0)
                {
                    lblDatosNoEncontrados.Visible = true;
                }
                else
                {
                    lblDatosNoEncontrados.Visible = false;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



       

        

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPantallaAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {

        }

        private void btnPantallaAgregar_Click_1(object sender, EventArgs e)
        {
            btnEliminar.Visible = false;
            lblEliminar.Visible = false;

            btnCancelar.Visible = true;
            lblCancelar.Visible = true;
            btnGrabar.Visible = true;
            lblGrabar.Visible = true;

            
            lblrequerido1.Visible = true;
            lblrequerido2.Visible = true;
            lblrequerido3.Visible = true;
            lblrequerido4.Visible = true;
            lblrequerido5.Visible = true;
            lblrequerido6.Visible = true;
            lblrequerido7.Visible = true;
            lblrequerido8.Visible = true;

            btnPantallaEditar.Enabled = false;
            dgvContactos2.Enabled = false;
            MostrarGuardarCancelar(true);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtCodigopostal.Text = "";
            txtTelefonoresidencial.Text = "";
            txtTelefonocelular.Text = "";
            txtEmail.Text = "";
            txtSexo.Text = "";
            txtDirecciondetrabajo.Text = "";
            txtFechadenacimiento.Text = "";
            txtEstadocivil.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnPantallaEditar_Click(object sender, EventArgs e)
        {
            btnPantallaAgregar.Enabled = false;
            btnEliminar.Visible = true;
            lblEliminar.Visible = true;
            btnCancelar.Visible = true;
            lblCancelar.Visible = true;
            btnGrabar.Visible = true;
            lblGrabar.Visible = true;

          
         
            lblrequerido1.Visible = true;
            lblrequerido2.Visible = true;
            lblrequerido3.Visible = true;
            lblrequerido4.Visible = true;
            lblrequerido5.Visible = true;
            lblrequerido6.Visible = true;
            lblrequerido7.Visible = true;
            lblrequerido8.Visible = true;


            MostrarGuardarCancelar(true);
            
        }

        private void btnVerContactos_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = false;
            lblEliminar.Visible = false;
            btnCancelar.Visible = false;
            lblCancelar.Visible = false;
            btnGrabar.Visible = false;
            lblGrabar.Visible = false;

           
            lblrequerido1.Visible = false;
            lblrequerido2.Visible = false;
            lblrequerido3.Visible = false;
            lblrequerido4.Visible = false;
            lblrequerido5.Visible = false;
            lblrequerido6.Visible = false;
            lblrequerido7.Visible = false;
            lblrequerido8.Visible = false;

            this.dgvContactos2.Columns["Codigo"].Visible = true;
            this.dgvContactos2.Columns["Nombre"].Visible = true;
            this.dgvContactos2.Columns["Apellidos"].Visible = true;
            this.dgvContactos2.Columns["Direccion"].Visible = true;
            this.dgvContactos2.Columns["Codigopostal"].Visible = true;
            this.dgvContactos2.Columns["Telefonoresidencial"].Visible = true;
            this.dgvContactos2.Columns["Telefonocelular"].Visible = true;
            this.dgvContactos2.Columns["Email"].Visible = true;
            this.dgvContactos2.Columns["Sexo"].Visible = true;
            this.dgvContactos2.Columns["Direcciondetrabajo"].Visible = true;
            this.dgvContactos2.Columns["Fechadenacimiento"].Visible = true;
            this.dgvContactos2.Columns["Estadocivil"].Visible = true;

        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            btnPantallaAgregar.Enabled = true;
            btnPantallaEditar.Enabled = true;

            try
            {
                string sResultado = ValidarDatos();

                if (sResultado == "")
                {
                    if (txtCodigo.Text == "")
                    {
                        Contacto contacto = new Contacto();
                        contacto.Nombre = txtNombre.Text;
                        contacto.Apellidos = txtApellidos.Text;
                        contacto.Direccion = txtDireccion.Text;
                        contacto.Codigopostal = txtCodigopostal.Text;
                        contacto.Telefonoresidencial = txtTelefonoresidencial.Text;
                        contacto.Telefonocelular = txtTelefonocelular.Text;
                        contacto.Email = txtEmail.Text;
                        contacto.Sexo = txtSexo.Text;
                        contacto.Direcciondetrabajo = txtDirecciondetrabajo.Text;
                        contacto.Fechadenacimiento = txtFechadenacimiento.Text;
                        contacto.Estadocivil = txtEstadocivil.Text;


                        if (FContacto.Insertar(contacto) > 0)
                        {
                            MessageBox.Show("Datos insertados correctamente");
                            FrmInicio_Load(null, null);
                        }
                    }
                    else
                    {
                        Contacto contacto = new Contacto();
                        contacto.Codigo = Convert.ToInt32(txtCodigo.Text);
                        contacto.Nombre = txtNombre.Text;
                        contacto.Apellidos = txtApellidos.Text;
                        contacto.Direccion = txtDireccion.Text;
                        contacto.Codigopostal = txtCodigopostal.Text;
                        contacto.Telefonoresidencial = txtTelefonoresidencial.Text;
                        contacto.Telefonocelular = txtTelefonocelular.Text;
                        contacto.Email = txtEmail.Text;
                        contacto.Sexo = txtSexo.Text;
                        contacto.Direcciondetrabajo = txtDirecciondetrabajo.Text;
                        contacto.Fechadenacimiento = txtFechadenacimiento.Text;
                        contacto.Estadocivil = txtEstadocivil.Text;

                        if (FContacto.Actualizar(contacto) == 1)
                        {
                            MessageBox.Show("Datos Modificados correctamente");
                            FrmInicio_Load(null, null);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Faltan cargar Datos: \n" + sResultado);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnAyuda_Click_1(object sender, EventArgs e)
        {
            FrmAyuda frm = new FrmAyuda();

            frm.Show();


        }

        private void dgvContactos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvContactos2.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar =
                    (DataGridViewCheckBoxCell)dgvContactos2.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dgvContactos2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContactos2.CurrentRow != null)
            {
                txtCodigo.Text = dgvContactos2.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvContactos2.CurrentRow.Cells[2].Value.ToString();
                txtApellidos.Text = dgvContactos2.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvContactos2.CurrentRow.Cells[4].Value.ToString();
                txtCodigopostal.Text = dgvContactos2.CurrentRow.Cells[5].Value.ToString();
                txtTelefonoresidencial.Text = dgvContactos2.CurrentRow.Cells[6].Value.ToString();
                txtTelefonocelular.Text = dgvContactos2.CurrentRow.Cells[7].Value.ToString();
                txtEmail.Text = dgvContactos2.CurrentRow.Cells[8].Value.ToString();
                txtSexo.Text = dgvContactos2.CurrentRow.Cells[9].Value.ToString();
                txtDirecciondetrabajo.Text = dgvContactos2.CurrentRow.Cells[10].Value.ToString();
                txtFechadenacimiento.Text = dgvContactos2.CurrentRow.Cells[11].Value.ToString();
                txtEstadocivil.Text = dgvContactos2.CurrentRow.Cells[12].Value.ToString();

            }
        }

        private void txtFechadenacimiento_ValueChanged(object sender, EventArgs e)
        {
            
            //fecha1 = dtp_fecha_inicio.Value.Date.ToString("dd/MM/yyyy");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            btnEliminar.Visible = false;
            lblEliminar.Visible = false;
            btnCancelar.Visible = false;
            lblCancelar.Visible = false;
            btnGrabar.Visible = false;
            lblGrabar.Visible = false;

            lblrequerido1.Visible = false;
            lblrequerido2.Visible = false;
            lblrequerido3.Visible = false;


            this.dgvContactos2.Columns["Codigo"].Visible = false;
                    this.dgvContactos2.Columns["Nombre"].Visible = true;
                    this.dgvContactos2.Columns["Apellidos"].Visible = true;
                    this.dgvContactos2.Columns["Direccion"].Visible = false;
                    this.dgvContactos2.Columns["Codigopostal"].Visible = false;
                    this.dgvContactos2.Columns["Telefonoresidencial"].Visible = false;
                    this.dgvContactos2.Columns["Telefonocelular"].Visible = true;
                    this.dgvContactos2.Columns["Email"].Visible = true;
                    this.dgvContactos2.Columns["Sexo"].Visible = false;
                    this.dgvContactos2.Columns["Direcciondetrabajo"].Visible = false;
                    this.dgvContactos2.Columns["Fechadenacimiento"].Visible = false;
                    this.dgvContactos2.Columns["Estadocivil"].Visible = false;
        }
    }
}
