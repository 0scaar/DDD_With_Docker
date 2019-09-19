using FluentAssertions;
using ReporteTests.Builders;
using Xunit;

namespace ReporteTests.Cases.Domain
{
    public class TipoReporteDomainTest
    {
        [Fact]
        public void ShouldCreateTipoReporte()
        {
            var tipoReporte = BuilderTipoReporte.New().Build();
            tipoReporte.IsValid.Should().BeTrue();
        }
    }
}
