using Domain.Validator;
using System;

namespace Domain.Entities
{
    public class TipoReporte : Entity
    {
        public string Tipo { get; set; }

        public TipoReporte(Guid id, string tipo)
        {
            this.Id = id;
            this.Tipo = tipo;

            Validate(this, new TipoReporteValidator());
        }
    }
}
