using Calculos.Entities;
using Calculos.Interfaces;
using Microsoft.Extensions.Logging;

namespace Calculos.Services
{
    public class ContabilidadeService : IContabilidadeService
    {
        private readonly IImposto _imposto;
        private readonly ILogger<ContabilidadeService> _logger;

        public ContabilidadeService(IImposto imposto, ILogger<ContabilidadeService> logger)
        {
            _imposto = imposto;
            _logger = logger;
        }

        public async Task<NotaFiscal> EmitirNotaFiscal(decimal valorBase)
        {
            _logger.LogInformation("Iniciado fluxo emissão da nota fiscal");

            var valorSemImpostos = valorBase;
            var valorComImpostos = await _imposto.Calcular(valorBase);
            var impostoCalculado = _imposto.Name;

            return new NotaFiscal(valorSemImpostos, valorComImpostos, impostoCalculado);
        }
    }
}