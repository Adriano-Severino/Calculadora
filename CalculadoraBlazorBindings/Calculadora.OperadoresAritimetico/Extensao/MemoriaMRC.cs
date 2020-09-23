using System;

namespace CalculadoraBlazorBindings.Calculadora.OperadoresAritimetico.Extensao.MemoriaMRC
{
    public class MemoriaMRC
    {

        private string valor1 = "-1";
        private string valor2 = "-1";
        private string resultado = "";

        private string memoria = "";
        private decimal calculoDaMemoria = 0;

        public MemoriaMRC(string valor1, string valor2, string memoria, string resultado = "")
        {
            this.memoria = memoria;
            this.resultado = resultado;
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public string mrMais()
        {

            if (resultado != "" && memoria != "")
            {
                memoria = memoriaSomar();

                return memoria;
            }

            if (memoria != "" && valor1 != "-1")
            {
                memoria = memoriaSomar();

                return memoria;
            }

            if (memoria == "" && valor1 != "-1" && valor2 != "-1")
            {

                memoria = resultado;

                return memoria;

            }

            return "";
        }

        public string mrMenos()
        {



            if (resultado != "" && memoria != "")
            {
                memoria = memoriaSubtrair();

                return memoria;
            }

            if (memoria != "" && valor1 != "-1")
            {
                memoria = memoriaSubtrair();

                return memoria;
            }

            if (memoria == "" && valor1 != "-1" && valor2 != "-1")
            {

                memoria = resultado;

                return memoria;

            }

            return "";
        }

        public string mrApagar()
        {
            return "";
        }
        private string memoriaSomar()
        {
            calculoDaMemoria = Convert.ToDecimal(valor1) + Convert.ToDecimal(memoria);
            resultado = Convert.ToString(calculoDaMemoria);
            return resultado;
        }
        private string memoriaSubtrair()
        {
            calculoDaMemoria = Convert.ToDecimal(valor1) - Convert.ToDecimal(memoria);
            resultado = Convert.ToString(calculoDaMemoria);
            return resultado;
        }
    }
}
