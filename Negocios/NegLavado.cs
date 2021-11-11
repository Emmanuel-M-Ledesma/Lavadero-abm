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
    public class NegLavado
    {
        DatosLavado objDLavado = new DatosLavado();

        public int abmLavado(string accion, Lavado objLavado, Auto objAuto)
        {
            return objDLavado.abmLavado(accion, objLavado, objAuto);
        } 

        public DataSet listaTrabajo(string accion)
        {
            return objDLavado.listaTrabajo(accion);
        }
    }
}
