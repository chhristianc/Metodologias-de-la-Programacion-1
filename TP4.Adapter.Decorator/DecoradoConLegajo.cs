﻿using System;

namespace TP4.Adapter.Decorator
{
    public class DecoradoConLegajo : AlumnoDecorator
    {
        public DecoradoConLegajo(IAlumno alumno) : base(alumno)
        {

        }

        public override string mostrarCalificacion()
        {
            string resultado = base.mostrarCalificacion();

            int index = resultado.IndexOf(" ");

            resultado = resultado.Insert(index, " (" + getLegajo().ToString() + ")");

            return resultado;
        }
    }
}