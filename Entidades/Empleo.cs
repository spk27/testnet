using System;
using System.Collections.Generic;

namespace TestNet.Entidades {
    public class Empleo {

        public Empleo()
        {
            Personas = new List<Persona>();
        }
        public int Id { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }

        public int NumeroTrabajadores { get; set; }
    
        public List<Persona> Personas { get; private set; }
    }
}