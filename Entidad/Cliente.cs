using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {

        public Cliente()
        {

        }

        public Cliente(String Dni, string Nom, string Apel) : base(Dni, Nom, Apel)
        {

        }

        public Cliente(String Dni) : base (Dni)
        {

        }
    }
}
