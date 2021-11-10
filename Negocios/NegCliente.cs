using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    
    public class NegCliente
    {
        DatosClientes objDcli = new DatosClientes();
        public int abmCliente(string accion, Cliente objCliente)
        {
            return objDcli.abmCliente(accion, objCliente);
        }
    }
}
