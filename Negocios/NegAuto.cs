using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegAuto
    {
        DatosAutos objDAuto = new DatosAutos();

        public int abmAutos(string accion, Auto objAuto, Cliente objCliente)
        {
            return objDAuto.abmAuto(accion, objAuto, objCliente);
        }
    }
}
