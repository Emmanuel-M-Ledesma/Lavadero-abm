using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegEmpleado
    {
        DatosEmpleados objDEmpleado = new DatosEmpleados();

        public int abmEmpleado(string accion, Empleado objEmpleado)
        {
            return objDEmpleado.abmEmpleado(accion, objEmpleado);
        }

        public DataSet listaEmpleado(string orden)
        {
            return objDEmpleado.listaEmpleados(orden);
        }
    }

}
