using FluentAssertions;
using ReporteTests.Builders;
using System;
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

        [Fact]
        public void IdShouldBeNotEmpty()
        {
            var tipoReporte = BuilderTipoReporte.New().WithId(Guid.Empty).Build();
            tipoReporte.IsValid.Should().BeFalse();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void TipoShouldRequered(string tipo)
        {
            var tipoReporte = BuilderTipoReporte.New().WithTipo(tipo).Build();
            tipoReporte.IsValid.Should().BeFalse();
        }
    }
}
