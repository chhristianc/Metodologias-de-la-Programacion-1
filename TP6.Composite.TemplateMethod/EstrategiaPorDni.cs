﻿using System;

namespace TP6.Composite.TemplateMethod
{
    public class EstrategiaPorDni : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getDni() == ((IAlumno)c2).getDni();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getDni() < ((IAlumno)c2).getDni();
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getDni() > ((IAlumno)c2).getDni();
        }
    }
}