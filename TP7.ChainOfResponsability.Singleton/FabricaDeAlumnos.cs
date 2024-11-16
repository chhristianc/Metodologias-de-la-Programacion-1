﻿using System;

namespace TP7.ChainOfResponsability.Singleton
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Alumno(responsable.stringAleatorio(6), responsable.numeroAleatorio(10000),
                responsable.numeroAleatorio(10000), responsable.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado()
        {
            return new Alumno(responsable.stringPorTeclado(),responsable.numeroPorTeclado(),
                responsable.numeroPorTeclado(),responsable.numeroPorTeclado());
        }

        public override Comparable crearDesdeArchivo()
        {
            return new Alumno(responsable.stringDesdeArchivo(9), (int)responsable.numeroDesdeArchivo(10000),
                (int)responsable.numeroDesdeArchivo(10000), (int)responsable.numeroDesdeArchivo(10));
        }
    }
}