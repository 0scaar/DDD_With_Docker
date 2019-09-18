using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Reporte : Entity
    {
        public string ReportName { get; set; }
        public bool Status { get; set; }
        public Guid TipoReporte { get; set; }
    }
}
