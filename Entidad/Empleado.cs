using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado :Persona
    {
        public Empleado()
        {

        }

        public Empleado(String Dni, string Nom, string Apel): base(Dni,Nom,Apel)
        {

        }

        public Empleado(string Dni) :base(Dni)
        {

        }
    }
}
