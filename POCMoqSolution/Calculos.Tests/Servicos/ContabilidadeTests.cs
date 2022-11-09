using Calculos.Interfaces;
using Calculos.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace Calculos.Tests.Servicos
{
    public class ContabilidadeTests
    {
        [Fact]
        public async void Emitir_NotaFiscal_ISS()
        {
            //Arrange (dependência IImposto)
            var issMock = new Mock<IImposto>();
            issMock.Setup(iss => iss.Name).Returns("Imposto ISS");
            issMock.Setup(iss => iss.Calcular(100m)).ReturnsAsync(115m);
            IImposto iss = issMock.Object;

            //Arrange (dependência logger)
            var mock = new Mock<ILogger<ContabilidadeService>>();
            var logger = mock.Object;

            //Arrange (contabilide services)
            var contabilidade = new ContabilidadeService(iss, logger);

            //Act
            var notaFiscal = await contabilidade.EmitirNotaFiscal(100m);

            //Assert
            Assert.Equal(iss.Name, notaFiscal.TipoImpostoCalculado);
            Assert.Equal(100m, notaFiscal.ValorSemImpostos);
            Assert.Equal(115m, notaFiscal.ValorComImpostos);
        }
    }
}