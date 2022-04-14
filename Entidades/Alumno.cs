using System;
using System.Collections.Generic;

namespace Etapa1.Entidades
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string UniqueId { get; set; }
        
        public Alumno() => UniqueId = Guid.NewGuid().ToString();
    }
}