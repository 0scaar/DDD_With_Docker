using Domain.Validator;
using System;

namespace Domain.Entities
{
    public class Reporte : Entity
    {
        public string ReportName { get; set; }
        public bool Status { get; set; }
        public Guid TipoReporte { get; set; }

        public Reporte(Guid id, string reportName, bool status, Guid tipoReporte)
        {
            this.Id = id;
            this.ReportName = reportName;
            this.Status = status;
            this.TipoReporte = tipoReporte;

            Validate(this, new ReporteValidator());
        }
    }
}
