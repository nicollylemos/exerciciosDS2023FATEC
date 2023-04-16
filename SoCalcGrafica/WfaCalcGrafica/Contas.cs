using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaCalcGrafica
{  
    /// <summary>
    /// Classe para calcular valores
    /// </summary>
    public  class Contas
    {
        private double num1;
        /// <summary>
        /// 1º número do calculo 
        /// </summary>


        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        private double num2;
        /// <summary>
        /// 2º número do calculo
        /// </summary>


        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }


        public Contas()  //construtor padrão (alt + enter)
        {
        }

        /// <summary>
        /// Construtor alternativo passando valores 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public Contas(double num1, double num2)   //gerar construtor
        {
            Num1 = num1;
            Num2 = num2;
        }

        /// <summary>
        /// Calcula a soma dos valores informados 
        /// </summary>
        /// <returns> Retorna uma frase com o resultado </returns>

        public string Somar(){

            return "A soma é " + (Num1+Num2);
        }

        public  string Somar(double num1, double num2) {

            return "A soma é " + (num1 + num2);
        }



        public string Subtrair()
        {

            return "A subtração é " + (Num1 - Num2);
        }

        public string Subtrair(double num1, double num2)
        {

            return "A subtração é " + (num1 - num2);
        }


        public string Multiplicacao()
        {

            return "A multiplicação é " + (Num1 * Num2);
        }

        public string Multiplicacao(double num1, double num2)
        {

            return "A multiplicação é " + (num1 * num2);
        }

        public string Divisao()
        {

            if (Num2 ==0)
            {
                return "Não é possível dividir esse número por 0 ";
            }

            return "A divisão de " + (Num1 / Num2);
        }

        public string Divisao(double num1, double num2)
        {

            return "A divisão é " + (num1 / num2);
        }


        public string Sair()
        {
            return "\nVolte sempre!";
        }
        
        // TODO terminar a classe
    }
}
