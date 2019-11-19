using System.Collections.Generic;

namespace TestNet.Entidades {
    public class PersonaContacto {

        public int PersonaId { get; set; }
        public int ContactoId { get; set; }

        public Persona Persona { get; private set; }
        public Contacto Contacto { get; private set; }
    
    }
}