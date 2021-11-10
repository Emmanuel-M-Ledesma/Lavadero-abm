using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Cliente
    {
        private string Patente;
        private string Marca;
        private string Modelo;
        private int Año;


        public string patente
        {
            get { return Patente; }
            set { Patente = value; }
        }

        public string marca
        {
            get { return Marca; }
            set { Marca = value; }
        }

        public string modelo
        {
            get { return Modelo; }
            set { Modelo = value; }

        }

        public int años
        {
            get { return Año; }
            set { Año = value; }
        }



        public Auto()
        {

        }
        public Auto(string DNI, string Pat, string Mod, int año) : base(DNI)
        {
            patente = Pat;
            modelo = Mod;
            años = año;
        }
    }
}
