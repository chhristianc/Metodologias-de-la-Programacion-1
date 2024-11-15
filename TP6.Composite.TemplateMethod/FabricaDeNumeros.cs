﻿using System;

namespace TP6.Composite.TemplateMethod
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Numero(generador.numeroAleatorio(100));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(lector.numeroPorTeclado());
        }
    }
}