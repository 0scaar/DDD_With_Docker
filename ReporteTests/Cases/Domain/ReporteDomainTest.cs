using FluentAssertions;
using ReporteTests.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReporteTests.Cases.Domain
{
    public class ReporteDomainTest
    {
        [Fact]
        public void ShouldCreateReporte()
        {
            var reporte = BuilderReporte.New().Build();
            reporte.IsValid.Should().BeTrue();
        }

        [Fact]
        public void IdShouldBeNotEmpty()
        {
            var reporte = BuilderReporte.New().WithId(Guid.Empty).Build();
            reporte.IsValid.Should().BeFalse();
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ReportNameShouldRequered(string reportName)
        {
            var reporte = BuilderReporte.New().WithReportName(reportName).Build();
            reporte.IsValid.Should().BeFalse();
        }

        [Fact]
        public void TipoReporteShouldRequered()
        {
            var reporte = BuilderReporte.New().WithTipoReporte(new Guid()).Build();
            reporte.IsValid.Should().BeFalse();
        }
    }
}
