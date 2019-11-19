
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNet.Entidades;
using TestNet.Excepciones;
using TestNet.Interfaces;

namespace TestNet.Commands.CreatePersona {
    public static class CreatePersonaHandler {

        public static async Task<int> Handle(CreatePersonaCommand request, ITestNetDbContext _context, CancellationToken cancellationToken) {

            if (request.Cedula != "" && _context.Personas.Where(p => p.Cedula == request.Cedula).Any()) {
                throw new PersonaExistsException(request.Nombre, request.Cedula);
            }
            if (request.EmpleoId > 0 && !_context.Empleos.Where(e => e.Id == request.EmpleoId).Any()) {
                throw new NotFoundException("Empleo", request.EmpleoId);
            }

            var entity = new Persona {
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Cedula = request.Cedula,
                Direccion = request.Direccion,
                EmpleoId = request.EmpleoId
            };

            await _context.Personas.AddAsync(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        } 
    }
}