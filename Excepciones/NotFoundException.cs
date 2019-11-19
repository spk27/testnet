using System;

namespace TestNet.Excepciones {
    public class NotFoundException : Exception {
        public NotFoundException(string name, object key)
        : base($"La Entidad \"{name}\" ({key}) no fué encontrada.")
        { }
    }
}