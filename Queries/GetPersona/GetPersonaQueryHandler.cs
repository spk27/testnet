
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNet.DTOs;
using TestNet.Excepciones;
using TestNet.Interfaces;

namespace TestNet.Queries.GetPersona {
    public static class GetPersonaQueryHandler {

        public static async Task<PersonaDTO> Handle(GetPersonaQuery request, ITestNetDbContext _context) {
            
            var entity = await _context.Personas
                .Include(p => p.Empleo)
                .Where(p => p.Id == request.PersonaId)
                .SingleOrDefaultAsync();

            if (entity == null) {
                throw new NotFoundException("Persona", request.PersonaId);
            }

            return PersonaDTO.Create(entity);
        }
    }
}