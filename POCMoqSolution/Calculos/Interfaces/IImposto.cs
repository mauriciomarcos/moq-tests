namespace Calculos.Interfaces
{
    public interface IImposto
    {
        string Name { get; }
        Task<decimal> Calcular(decimal valorPeriodoApuracao);
    }
}