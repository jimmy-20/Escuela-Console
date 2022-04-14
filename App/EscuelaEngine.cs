using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;
using Etapa1.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            Inicializar();
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi", 2012, TipoEscuela.Primaria);
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            foreach (Curso c in Escuela.Cursos) // Recorro todos los cursos
            {
                foreach (Alumno a in c.Alumnos) //Recorro todos los alumno por curso
                {
                    foreach (Asignatura clase in c.Asignaturas) //Recorro todas las asignaturas por curso
                    {
                        c.evaluaciones.Add(new Evaluacion(a,clase));
                    }
                }
            }
        }
        
        private void CargarAsignaturas()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                new Asignatura(){Nombre = "Matematicas"},
                new Asignatura(){Nombre = "Educacion Fisica"},
                new Asignatura(){Nombre = "Ingles"},
                new Asignatura(){Nombre = "Ciencias Naturales"}
            };

            foreach (Curso c in Escuela.Cursos)
            {
                c.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private List<Alumno> GenerandoAlumnos(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            var listaAlumnos = from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{Nombre=$"{n1} {n2} {a1}"};

            return listaAlumnos.OrderBy( (al) => al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"},
                new Curso(){Nombre = "401",TipoJornada=TipoJornada.Mañana},
                new Curso(){Nombre = "501",TipoJornada = TipoJornada.Mañana},
                new Curso(){Nombre = "502",TipoJornada = TipoJornada.Tarde}
            };

            Random rd = new Random();
            foreach (Curso c in Escuela.Cursos)
            {
                int canRandom = rd.Next(5,20);
                c.Alumnos = GenerandoAlumnos(canRandom);
            }
        }
    }
}