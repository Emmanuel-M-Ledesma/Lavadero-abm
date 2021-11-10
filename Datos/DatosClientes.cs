using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Datos
{
    public class DatosClientes :DatosConexionBD
    {
        public int abmCliente(string accion, Cliente objCliente)
        {
            int res = -1;
            string orden = string.Empty;
            if (accion=="alta")
            {
                orden = "Insert into Cliente values (@DNI, @Nombre, @Apellido)";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@DNI", objCliente.dni);
                    cmd.Parameters.AddWithValue("@Nombre", objCliente.nombre);
                    cmd.Parameters.AddWithValue("@Apellido", objCliente.apellido);
                    res = cmd.ExecuteNonQuery();
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("El Dni ingresado ya existe");
                }
                finally
                {
                    CerrarConexion();
                    cmd.Dispose();
                }
            }
            return res;
        }

    }
}
