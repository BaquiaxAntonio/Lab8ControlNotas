﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8ControlNotas
{
    internal class NotasAlumno
    {
        string nombre;
        List< int > notas;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> Notas { get => notas; set => notas = value; }
    }
}
