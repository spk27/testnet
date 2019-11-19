using System;

namespace TestNet.Excepciones {
    public class PersonaExistsException : Exception {
        public PersonaExistsException(string name, string cedula)
        : base($"La Persona \"{name}\" ({cedula}) ya existe.")
        { }
    }
}