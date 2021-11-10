using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavado : Empleado
    {
        private DateTime Dia;
        private TimeSpan Hora;


        public DateTime dia
        {
            get { return Dia; }
            set { Dia = value; }
        }

        public TimeSpan hora
        {
            get { return Hora; }
            set { Hora = value; }
        }

       

        public Lavado()
        {

        }
        public Lavado(string Dni, DateTime Dia, TimeSpan Hora) : base(Dni)
        {
            dia = Dia;
            hora = Hora;
        }
    }
}
