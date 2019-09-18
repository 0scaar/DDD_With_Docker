using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infra.PostgresDataAccess.Entities
{
    public class Reporte
    {
        [Key]
        public Guid Id { get; set; }
        public string ReportName { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Id")]
        public TipoReporte TipoReporte { get; set; }
    }
}
