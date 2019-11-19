using System;
using System.Collections.Generic;

namespace TestNet.Entidades {
    public class Persona {

        public Persona()
        {
            PersonaContactos = new List<PersonaContacto>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }

        public string Direccion { get; set; }
        public int EmpleoId { get; set; }
        public Empleo Empleo { get; set; }
        public List<PersonaContacto> PersonaContactos { get; set; }
    }
}