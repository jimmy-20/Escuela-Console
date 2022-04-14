using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;
namespace CoreEscuela
{
    class Program
    {
        public static void Main()
        {
            EscuelaEngine ee = new EscuelaEngine();

            Printer.EscribirTitulo(ee.Escuela.Nombre);

            Printer.Linea();
            ImprimirCursos(ee.Escuela);

            WriteLine("Total de Estudiantes: "+ ee.Escuela.StdCursos());
            ee.Escuela.ImprimirNotas(1);

            //escuela.Cursos.RemoveAll(delegate(Curso cur){
            //    return cur.Nombre == "301";
            // });

            //escuela.Cursos.RemoveAll( (cur) => cur.Nombre == "501" );
            
        }

        ///<SUMMARY>
        /// Imprime los cursos
        ///
        private static void ImprimirCursos(Escuela e)
        {
            WriteLine("\t-----Cursos------");

            if (e == null)
            return;
            
            foreach (Curso c in e.Cursos)
            {
                WriteLine($"Nombre: {c.Nombre}, Id: {c.UniqueId}");
            }
        }
    }
}
