using System;

namespace Etapa1.Entidades
{
    public class Evaluacion
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }
        public Alumno Alumno { get; set; }  
        public Asignatura Asignatura {get;set;}
        public float Nota { get; private set; }
        public Evaluacion(Alumno a, Asignatura clase) {
            UniqueId = Guid.NewGuid().ToString();
            Random rd = new Random();
            Nota = (float) (rd.NextDouble() * (5)); // 0 - 5 

            Alumno = a;
            Asignatura = clase;
        }
    }
}