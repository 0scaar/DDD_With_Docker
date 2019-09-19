using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReporteTests.Builders
{
    public class BuilderTipoReporte
    {
        public Guid Id { get; set; }
        public string Tipo { get; set; }

        public static BuilderTipoReporte New()
        {
            return new BuilderTipoReporte()
            {
                Id = Guid.NewGuid(),
                Tipo = "AAA"
            };
        }

        public BuilderTipoReporte WithId(Guid id)
        {
            this.Id = id;
            return this;
        }

        public BuilderTipoReporte WithTipo(string tipo)
        {
            this.Tipo = tipo;
            return this;
        }

        public TipoReporte Build() => new TipoReporte(Id, Tipo);
    }
}
