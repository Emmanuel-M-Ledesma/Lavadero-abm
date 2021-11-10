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
            if (todos == "todos")
            {
                orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI";

            }
            if (todos=="HA")
            {
                orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by l.hora asc";

            }
            if (todos == "HD")
            {
                orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by l.hora desc";

            }
            if (todos == "FA")
            {
                orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by l.Dia asc";

            }
            if (todos == "FD")
            {
                orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by l.Dia desc";

            }
            if (todos == "DP")
            {
                orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by C.DNI asc";

            }
            if (todos == "AA")
            {
                orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by c.Apellido asc";

            }
            if (todos == "AD")
            {
                orden = "select C.DNI, c.Apellido,c.Nombre, a.Marca,a.Modelo,a.Año,a.Patente,l.Dia,l.hora, e.DNI from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by c.Apellido desc";

            }
            if (todos == "ClAu")
            {
                orden = "select c.DNI,c.Apellido,c.Nombre,a.Marca,a.Modelo,a.Año,a.Patente from Cliente c, Autos a where c.DNI = a.DNI";
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
