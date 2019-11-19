
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNet.DTOs;
using TestNet.Excepciones;
using TestNet.Interfaces;

namespace TestNet.Queries.GetPersona {
    public static class GetAllPersonaHandler {

        public static async Task<List<PersonaDTO>> Handle(ITestNetDbContext _context) {
            
            var entities = await _context.Personas
                .Include(p => p.Empleo)
                .ToListAsync();

            var personasDto = entities.Select(p => PersonaDTO.Create(p)).ToList();
            
            /*
            List<PersonaDTO> personasDto = new List<PersonaDTO>();

            foreach (var p in entities)
            {
                personasDto.Add(PersonaDTO.Create(p));
            }
            */
            return personasDto;
        }
    }
}