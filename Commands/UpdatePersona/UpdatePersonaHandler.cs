
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNet.Entidades;
using TestNet.Excepciones;
using TestNet.Interfaces;

namespace TestNet.Commands.UpdatePersona {
    public static class UpdatePersonaHandler {

        public static async Task<int> Handle(UpdatePersonaCommand request, ITestNetDbContext _context, CancellationToken cancellationToken) {

            var entity = await _context.Personas.FindAsync(request.Id);

            if (entity == null) {
                throw new NotFoundException("Persona", request.Id);
            }
            if (request.EmpleoId > 0 && !_context.Empleos.Where(e => e.Id == request.EmpleoId).Any()) {
                throw new NotFoundException("Empleo", request.EmpleoId);
            }

            entity.Nombre = request.Nombre;
            entity.Apellido = request.Apellido;
            entity.Direccion = request.Direccion;
            entity.EmpleoId = request.EmpleoId;

            await _context.SaveChangesAsync(cancellationToken);

            return request.Id;
        } 
    }
}