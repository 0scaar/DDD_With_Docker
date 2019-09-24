using Domain.Entities;
using System;

namespace ReporteTests.Builders
{
    public class BuilderReporte
    {
        public Guid Id;
        public string ReportName;
        public bool Status;
        public Guid TipoReporte;

        public static BuilderReporte New()
        {
            return new BuilderReporte
            {
                Id = Guid.NewGuid(),
                ReportName = "XXX",
                Status = true,
                TipoReporte = Guid.NewGuid()
            };
        }

        public BuilderReporte WithId(Guid id)
        {
            this.Id = id;
            return this;
        }

        public BuilderReporte WithReportName(string reportName)
        {
            this.ReportName = reportName;
            return this;
        }

        public BuilderReporte WithStatus(bool status)
        {
            this.Status = status;
            return this;
        }

        public BuilderReporte WithTipoReporte(Guid tipoReporte)
        {
            this.TipoReporte = tipoReporte;
            return this;
        }

        public Reporte Build() => new Reporte(Id, ReportName, Status, TipoReporte);
    }
}
