using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Datos
{
    public class DatosLavado: DatosConexionBD
    {
        

        public int abmLavado(string accion, Lavado objLavado, Auto objAuto)
        {
            int res = -1;
            string orden = string.Empty;
            if (accion == "alta")
            {
                orden = "insert into Lava values (@DNI, @Patente,@Dia,@Hora)";
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion();
                    cmd.Parameters.AddWithValue("@DNI", objLavado.dni);
                    cmd.Parameters.AddWithValue("@Patente", objAuto.patente);
                    cmd.Parameters.AddWithValue("@Dia", objLavado.dia);
                    cmd.Parameters.AddWithValue("@Hora", objLavado.hora);
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
            return res;
        }


        public DataSet listaTrabajo(string accion)
        {
            string orden = string.Empty;
            if (accion== "listar")
            {
                orden = "Select * from Lava";
               
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
