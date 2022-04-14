using System;

namespace Etapa1.Entidades
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public string UniqueId { get; private set; }
        
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();
    }
}