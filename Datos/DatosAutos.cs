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
    public class DatosAutos : DatosConexionBD
    {
        public int abmAuto(string accion, Auto objAuto, Cliente objCliente)
        {
            int res = -1;
            string orden = string.Empty;

            if (accion == "alta")
            {
                orden = "Insert into Autos values (@DNI,@Patente,@Marca,@Modelo, @año); ";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@DNI", objCliente.dni);
                    cmd.Parameters.AddWithValue("@Patente", objAuto.patente);
                    cmd.Parameters.AddWithValue("@Marca", objAuto.marca);
                    cmd.Parameters.AddWithValue("@Modelo", objAuto.modelo);
                    cmd.Parameters.AddWithValue("@año", objAuto.años);
                    res = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    MessageBox.Show( e.Message, "Error");
                }
                finally
                {
                    CerrarConexion();
                    cmd.Dispose();
                }
            }
            if (accion == "Modificar")
            {
                orden = "update Autos set Marca=@Marca,Modelo=@Modelo,Año=@Año where Patente=@Patente";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@Marca", objAuto.marca);
                    cmd.Parameters.AddWithValue("@Modelo", objAuto.modelo);
                    cmd.Parameters.AddWithValue("@Año", objAuto.años);
                    cmd.Parameters.AddWithValue("@Patente", objAuto.patente);

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
                orden = "delete from Autos where Patente=@Patente";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@Patente", objAuto.patente);

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


        public DataSet listaAutos(string accion)
        {
            string orden = string.Empty;
            if (accion == "listar")
            {
                orden = "Select * from Autos";

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
