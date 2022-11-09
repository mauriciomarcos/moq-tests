using Calculos.Entities;

namespace Calculos.Tests.Entities
{
    public class ISSTests
    {
        [Fact]
        public async void Carcular_ISS_Success()
        {
            //Arrange
            var iss = new ISS();

            //Act
            var resultado = await iss.Calcular(100m);

            //Assert
            Assert.Equal(115m, resultado);
        }
    }
}