using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;



namespace Datos
{
    public class DatosLista : DatosConexionBD
    {
        public DataSet ListaTodos(string todos)
        {
            string orden = string.Empty;
            orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI";
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

                throw new Exception("Error al listar", e);
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
