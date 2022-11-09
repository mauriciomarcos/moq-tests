using Calculos.Interfaces;

namespace Calculos.Entities
{
    public class ISS : IImposto
    {
        public string Name => "Imposto ISS";

        public async Task<decimal> Calcular(decimal valorPeriodoApuracao) => 
            await Task.FromResult((valorPeriodoApuracao * 0.15m) + valorPeriodoApuracao);
    }
}