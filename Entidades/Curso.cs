using System;
using System.Collections.Generic;
using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string UniqueId {get;private set;}
        public TipoJornada TipoJornada { get; set; }
        public List<Asignatura> Asignaturas { get; set ; } = new List<Asignatura>();
        public List<Alumno> Alumnos { get; set; } 
        public List<Evaluacion> evaluaciones {get;set;} = new List<Evaluacion>();

        public Curso() => UniqueId = Guid.NewGuid().ToString();

        
        
    }
}