using System;
using System.ComponentModel.DataAnnotations;

namespace Infra.PostgresDataAccess.Entities
{
    public class TipoReporte
    {
        [Key]
        public Guid Id { get; set; }
        public string Tipo { get; set; }
    }
}
