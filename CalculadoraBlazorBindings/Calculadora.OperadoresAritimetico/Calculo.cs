using System;

namespace CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico
{
    public abstract class Calculo : ICalculo
    {
        private decimal resultado;

        public decimal Dividir(decimal valor1, decimal valor2) => resultado = valor1 / valor2;
        public decimal Multiplicar(decimal valor1, decimal valor2) => resultado = valor1 * valor2;
        public decimal Somar(decimal valor1, decimal valor2) => resultado = valor1 + valor2;
        public decimal Subitrair(decimal valor1, decimal valor2) => resultado = valor1 - valor2;
        public decimal Porcentagem(decimal valor1, decimal valor2) => resultado = (valor2 / 100) * valor1;
        public decimal RaizQuadrada(decimal valor1) => resultado = Convert.ToDecimal(Math.Sqrt((double)(valor1)));
        public decimal MaisMenos(decimal valor1) => resultado = valor1 * -1;
    }

}
