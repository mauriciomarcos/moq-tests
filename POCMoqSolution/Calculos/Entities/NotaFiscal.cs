namespace Calculos.Entities
{
    public class NotaFiscal
    {
        public NotaFiscal(decimal valorSemImpostos, decimal valorComImpostos, string tipoImpostoCalculado)
        {
            ValorSemImpostos = valorSemImpostos;
            ValorComImpostos = valorComImpostos;
            TipoImpostoCalculado = tipoImpostoCalculado;
        }

        public decimal ValorSemImpostos { get; private set; }
        public decimal ValorComImpostos { get; private set; }
        public string TipoImpostoCalculado { get; private set; }
    }
}