
using System;
using System.Linq.Expressions;
using TestNet.Entidades;

namespace TestNet.DTOs {
    public class PersonaDTO {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }

        public EmpleoDTO Empleo { get; set; }

        public static Expression<Func<Persona, PersonaDTO>> Projection {
            get {
                return p => new PersonaDTO {
                    Id = p.Id,
                    NombreCompleto = p.Nombre + " " + p.Apellido,
                    Empleo = p.Empleo != null ? EmpleoDTO.Create(p.Empleo) : null
                };
            }
        }

        public static PersonaDTO Create(Persona persona) {
            return Projection.Compile().Invoke(persona);
        }
    }
}