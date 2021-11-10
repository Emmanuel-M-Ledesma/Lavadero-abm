using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string DNI;
        private string Nombre;
        private string Apellido;




        public string dni
        {
            get { return DNI; }
            set { DNI = value; }
        }

        public  string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }

        }
        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public Persona()
        {

        }

        public Persona(string Dni, string Nom, string Apel)
        {
            dni = Dni;
            nombre = Nom;
            apellido = Apel;
        }

        public Persona(string Dni)
        {

        }
    }
}
