using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosLavado: DatosConexionBD
    {
        //public int abmLavado(string accion, Lavado objLavado)
        //{
        //    int res = -1;
        //    string orden = string.Empty;
        //    if (accion== "alta")
        //    {
        //        orden = "insert into Lava values (@DNI, @Patente,@Dia,@Hora);";
        //        SqlCommand cmd = new SqlCommand(orden, conexion);
        //        try
        //        {
        //            AbrirConexion();
        //            cmd.Parameters.AddWithValue("@DNI", objLavado.dni);
        //            cmd.Parameters.AddWithValue("@Patente", objLavado.p);
        //            cmd.Parameters.AddWithValue("@DNI", objLavado.dni);
        //            cmd.Parameters.AddWithValue("@DNI", objLavado.dni);
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }

        //    }
        //}

    }
}
