﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Negocios
{
    public class NegAll
    {
        DatosLista objDatosAll = new DatosLista();
        public DataSet lista(string todos)
        {
            return objDatosAll.ListaTodos(todos);
        }

    }
}