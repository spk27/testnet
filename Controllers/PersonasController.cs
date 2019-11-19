using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestNet.Commands.CreatePersona;
using TestNet.DTOs;
using TestNet.Interfaces;
using TestNet.Queries.GetPersona;

namespace TestNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : Controller
    {
        protected readonly ITestNetDbContext _context;
        public PersonasController(ITestNetDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonaDTO>>> GetAll() {
            return Ok(await GetAllPersonaHandler.Handle(_context));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonaDTO>> Get(int id) {
            return Ok(await GetPersonaQueryHandler.Handle(new GetPersonaQuery() {PersonaId = id}, _context));
        } 

        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreatePersonaCommand command, CancellationToken cancellationToken) 
        {
            var personaId = await CreatePersonaHandler.Handle(command, _context, cancellationToken);

            return Ok(personaId);
        }
        
    }
}
