using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosConexionBD
    {
        #region Atributos

        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source=DESKTOP-06KE21D\SQLSERVEREXPRESS;Initial Catalog= Lavadero;Integrated Security=True;";


        #endregion

        #region Constructor

        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        #endregion

        #region Metodos

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }

        #endregion

    }
}
