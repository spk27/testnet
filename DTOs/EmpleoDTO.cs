
using System;
using System.Linq.Expressions;
using TestNet.Entidades;

namespace TestNet.DTOs {
    public class EmpleoDTO {
        public int Id { get; set; }
        public string Cargo { get; set; }

        public static Expression<Func<Empleo, EmpleoDTO>> Projection {
            get {
                return p => new EmpleoDTO {
                    Id = p.Id,
                    Cargo = p.Cargo
                };
            }
        }

        public static EmpleoDTO Create(Empleo empleo) {
            return Projection.Compile().Invoke(empleo);
        }
    }
}