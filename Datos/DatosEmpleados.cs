using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Datos
{
    public class DatosEmpleados : DatosConexionBD
    {
        public int abmEmpleado(string accion, Empleado objEmpleado)
        {
            int res = -1;
            string orden = string.Empty;
            if (accion == "alta")
            {
                orden = "Insert into Empleado values (@DNI, @Nombre, @Apellido)";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@DNI", objEmpleado.dni);
                    cmd.Parameters.AddWithValue("@Nombre", objEmpleado.nombre);
                    cmd.Parameters.AddWithValue("@Apellido", objEmpleado.apellido);
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                }
                finally
                {
                    CerrarConexion();
                    cmd.Dispose();

                }
            }

            if (accion == "Modificar")
            {
                orden = "update Empleado set DNI=@DNI,Nombre=@Nombre,Apellido=@Apellido where DNI=@DNI";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@DNI", objEmpleado.dni);
                    cmd.Parameters.AddWithValue("@Nombre", objEmpleado.nombre);
                    cmd.Parameters.AddWithValue("@Apellido", objEmpleado.apellido);

                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "error");
                }
                finally
                {
                    CerrarConexion();
                    cmd.Dispose();
                }
                //return res;
            }
            if (accion == "Borrar")
            {
                orden = "delete from Empleado where DNI=@DNI ";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@DNI", objEmpleado.dni);

                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "error");
                }
                finally
                {
                    CerrarConexion();
                    cmd.Dispose();
                }
                //return res;

            }
            return res;
        }




        public DataSet listaEmpleados(string accion)
        {
            string orden = string.Empty;
            if (accion == "listar")
            {
                orden = "Select * from Empleado";

            }
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error");
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;

        }
    }
}
