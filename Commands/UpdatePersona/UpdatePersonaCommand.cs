

namespace TestNet.Commands.UpdatePersona {
    public class UpdatePersonaCommand {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public int EmpleoId { get; set; }
    }
}