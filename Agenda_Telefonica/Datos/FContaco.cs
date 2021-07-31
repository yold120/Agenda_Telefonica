using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda_Telefonica.Entidades;
using Conexion.Datos;

namespace Agenda_Telefonica.Datos
{
    public class FContacto
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return FDBHelper.ExecuteDataSet("usp_Data_FContacto_GetAll", dbParams);

        }


        public static int Insertar(Contacto contacto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                   
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, contacto.Nombre),
                    FDBHelper.MakeParam("@Apellidos", SqlDbType.VarChar, 0, contacto.Apellidos),
                    FDBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, contacto.Direccion),
                    FDBHelper.MakeParam("@Codigopostal", SqlDbType.VarChar, 0, contacto.Codigopostal),
                    FDBHelper.MakeParam("@Telefonoresidencial", SqlDbType.VarChar, 0, contacto.Telefonoresidencial),
                    FDBHelper.MakeParam("@Telefonocelular", SqlDbType.VarChar, 0, contacto.Telefonocelular),
                    FDBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, contacto.Email),
                    FDBHelper.MakeParam("@Sexo", SqlDbType.VarChar, 0, contacto.Sexo),
                    FDBHelper.MakeParam("@Direcciondetrabajo", SqlDbType.VarChar, 0, contacto.Direcciondetrabajo),
                    FDBHelper.MakeParam("@Fechadenacimiento", SqlDbType.VarChar, 0, contacto.Fechadenacimiento),
                    FDBHelper.MakeParam("@Estadocivil", SqlDbType.VarChar, 0, contacto.Estadocivil)

                 

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FContacto_Insertar", dbParams));

        }

        public static int Actualizar(Contacto contacto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Codigo", SqlDbType.Int, 0, contacto.Codigo),
                    FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, contacto.Nombre),
                    FDBHelper.MakeParam("@Apellidos", SqlDbType.VarChar, 0, contacto.Apellidos),
                    FDBHelper.MakeParam("@Direccion", SqlDbType.VarChar, 0, contacto.Direccion),
                    FDBHelper.MakeParam("@Codigopostal", SqlDbType.VarChar, 0, contacto.Codigopostal),
                    FDBHelper.MakeParam("@Telefonoresidencial", SqlDbType.VarChar, 0, contacto.Telefonoresidencial),
                    FDBHelper.MakeParam("@Telefonocelular", SqlDbType.VarChar, 0, contacto.Telefonocelular),
                    FDBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, contacto.Email),
                    FDBHelper.MakeParam("@Sexo", SqlDbType.VarChar, 0, contacto.Sexo),
                    FDBHelper.MakeParam("@Direcciondetrabajo", SqlDbType.VarChar, 0, contacto.Direcciondetrabajo),
                    FDBHelper.MakeParam("@Fechadenacimiento", SqlDbType.VarChar, 0, contacto.Fechadenacimiento),
                    FDBHelper.MakeParam("@Estadocivil", SqlDbType.VarChar, 0, contacto.Estadocivil)
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FContacto_Actualizar", dbParams));

        }

        public static int Eliminar(Contacto contacto)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@Codigo", SqlDbType.Int, 0, contacto.Codigo),

                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Data_FContacto_Eliminar", dbParams));

        }

    }
}
