namespace CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico
{
    public interface ICalculo
    {
        decimal Somar(decimal valor1, decimal valor2);
        decimal Multiplicar(decimal valor1, decimal valor2);
        decimal Dividir(decimal valor1, decimal valor2);
        decimal Subitrair(decimal valor1, decimal valor2);
        decimal Porcentagem(decimal valor1, decimal valor2);
        decimal RaizQuadrada(decimal valor1);
        decimal MaisMenos(decimal valor1);
    }
}
