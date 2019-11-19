using System.Collections.Generic;

namespace TestNet.Entidades {
    public class Contacto {

        public Contacto()
        {
            PersonaContactos = new List<PersonaContacto>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public List<PersonaContacto> PersonaContactos { get; private set; }
    
    }
}