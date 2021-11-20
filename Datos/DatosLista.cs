using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Windows.Forms;

namespace Datos
{
    public class DatosLista : DatosConexionBD
    {
        public DataSet ListaTodos(string todos)
        {
            string orden = string.Empty;
            if (todos == "todos")
            {
                orden = "select CONCAT(C.DNI,', ', c.Apellido,' ',c.Nombre) as DatosCliente,CONCAT(a.Marca, ' ', a.Modelo, ' ', a.Año, ', ', a.Patente) as Vehiculo,l.Dia,l.hora,CONCAT(e.DNI, ', ', e.Apellido, ' ', e.Nombre) as DatosEmpleado from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI";

            }
            if (todos=="HA")
            {
                orden = "select CONCAT(C.DNI,', ', c.Apellido,' ',c.Nombre) as DatosCliente,CONCAT(a.Marca, ' ', a.Modelo, ' ', a.Año, ', ', a.Patente) as Vehiculo,l.Dia,l.hora,CONCAT(e.DNI, ', ', e.Apellido, ' ', e.Nombre) as DatosEmpleado from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by l.hora asc";

            }
            if (todos == "HD")
            {
                orden = "select CONCAT(C.DNI,', ', c.Apellido,' ',c.Nombre) as DatosCliente,CONCAT(a.Marca, ' ', a.Modelo, ' ', a.Año, ', ', a.Patente) as Vehiculo,l.Dia,l.hora,CONCAT(e.DNI, ', ', e.Apellido, ' ', e.Nombre) as DatosEmpleado from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by l.hora desc";

            }
            if (todos == "FA")
            {
                orden = "select CONCAT(C.DNI,', ', c.Apellido,' ',c.Nombre) as DatosCliente,CONCAT(a.Marca, ' ', a.Modelo, ' ', a.Año, ', ', a.Patente) as Vehiculo,l.Dia,l.hora,CONCAT(e.DNI, ', ', e.Apellido, ' ', e.Nombre) as DatosEmpleado from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by l.Dia asc";

            }
            if (todos == "FD")
            {
                orden = "select CONCAT(C.DNI,', ', c.Apellido,' ',c.Nombre) as DatosCliente,CONCAT(a.Marca, ' ', a.Modelo, ' ', a.Año, ', ', a.Patente) as Vehiculo,l.Dia,l.hora,CONCAT(e.DNI, ', ', e.Apellido, ' ', e.Nombre) as DatosEmpleado from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by l.Dia desc";

            }
            if (todos == "DP")
            {
                orden = "select CONCAT(C.DNI,', ', c.Apellido,' ',c.Nombre) as DatosCliente,CONCAT(a.Marca, ' ', a.Modelo, ' ', a.Año, ', ', a.Patente) as Vehiculo,l.Dia,l.hora,CONCAT(e.DNI, ', ', e.Apellido, ' ', e.Nombre) as DatosEmpleado from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by C.DNI asc";

            }
            if (todos == "AA")
            {
                orden = "select CONCAT(C.DNI,', ', c.Apellido,' ',c.Nombre) as DatosCliente,CONCAT(a.Marca, ' ', a.Modelo, ' ', a.Año, ', ', a.Patente) as Vehiculo,l.Dia,l.hora,CONCAT(e.DNI, ', ', e.Apellido, ' ', e.Nombre) as DatosEmpleado from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by c.Apellido asc";

            }
            if (todos == "AD")
            {
                orden = "select CONCAT(C.DNI,', ', c.Apellido,' ',c.Nombre) as DatosCliente,CONCAT(a.Marca, ' ', a.Modelo, ' ', a.Año, ', ', a.Patente) as Vehiculo,l.Dia,l.hora,CONCAT(e.DNI, ', ', e.Apellido, ' ', e.Nombre) as DatosEmpleado from Cliente C, Autos A, Lava L, Empleado E where c.DNI = a.DNI and a.Patente = l.Patente and l.DNI = e.DNI order by c.Apellido desc";

            }
            if (todos == "ClAu")
            {
                orden = "select c.DNI,c.Apellido,c.Nombre,a.Marca,a.Modelo,a.Año,a.Patente from Cliente c, Autos a where c.DNI = a.DNI";
            }
            if (todos == "Empleado")
            {
                orden = "select Dni, Apellido, Nombre from Empleado ";
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

        public DataTable Combo(string lista)
        {
            string orden = string.Empty;
            if (lista == "empleado")
            {
                orden = "select DNI, concat(DNI,', ',Apellido,' ', Nombre) as NombreCompleto from Empleado";
            }
            if (lista == "auto")
            {
                orden = "select Patente, concat(Patente,', ', Marca,' ',Modelo,' ', Año ) as Vehiculo from Autos";
            }
            if (lista == "cliente")
            {
                orden = "select * from Cliente order by DNI asc";
            }
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
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
            return dt;
        }
       
    }
}
