using Calculos.Entities;

namespace Calculos.Interfaces
{
    public interface IContabilidadeService
    {
        Task<NotaFiscal> EmitirNotaFiscal(decimal valorBase);
    }
}