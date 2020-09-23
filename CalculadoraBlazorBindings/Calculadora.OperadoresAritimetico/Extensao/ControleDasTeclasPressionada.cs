namespace CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Extensao
{
    public static class ControleDasTeclasPressionada
    {
        public static string TeclaPressionada(string valor1, string operacao, string tecla, string valor2 = "-1")
        {
            if (operacao != "")
            {
                if (valor2 == "-1")
                {

                    return valor2 = tecla;
                }

                return valor2 += tecla;

            }

            if (valor1 != "-1")
            {
                return valor1 += tecla;

            }

            if (valor1 == "-1")
            {
                return valor1 = tecla;

            }




            return "-1";
        }
    }
}
