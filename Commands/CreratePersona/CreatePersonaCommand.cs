

namespace TestNet.Commands.CreatePersona {
    public class CreatePersonaCommand {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public int? EmpleoId { get; set; }
    }
}