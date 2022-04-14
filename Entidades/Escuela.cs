using System;
using System.Collections.Generic;
using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId { get; private set ; } = Guid.NewGuid().ToString();
        string nombre;
        public string Nombre 
        { 
            get{return nombre;} 
            set{nombre = value;} 
        }

        public int Creacion {get;set;}
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TipoEscuela TipoEscuela{get;set;}
        public List<Curso> Cursos {get;set;}

        /*public Escuela(string nombre, int Creacion){
            this.nombre = nombre;
            this.Creacion = Creacion;
        }*/

        public Escuela(string nombre, int Creacion) => (Nombre,this.Creacion) = (nombre,Creacion);

        public Escuela(string nombre, int creacion,TipoEscuela tipo,string pais = "",string ciudad = ""){
            (Nombre,Creacion) = (nombre,creacion);
            Pais = pais;
            this.Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre},\nTipo: {TipoEscuela},\nPais: {Pais},\nCiudad: {Ciudad}";
        }

        public int StdCursos(){
            int total = 0;

            for (int i = 0; i < Cursos.Count-1; i++) //Recorre todos los cursos
            {
                total += Cursos[i].Alumnos.Count;
            }

            return total;
        }

        public void ImprimirNotas(int index){
            foreach (Evaluacion e in Cursos[index].evaluaciones)
            {
                Console.WriteLine($"Nombre: {e.Alumno.Nombre} \nAsignatura: {e.Asignatura.Nombre} \nNota: {e.Nota} \n");
            }
        }
    }
}