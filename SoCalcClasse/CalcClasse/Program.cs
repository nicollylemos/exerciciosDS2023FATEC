using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalcClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora"; //valor (titulo)
            Console.BackgroundColor = ConsoleColor.White; //mudar fundo
            Console.ForegroundColor = ConsoleColor.DarkMagenta; //mudar letra

            int opt = -1;
            //double num1 = 0;
            // double num2 = 0;

            try   //tratar seção
            {
                do
                {
                    Contas contas = new Contas();
                    Console.Clear(); //limpar tela (para colocar cor na tela inteira)
                    Console.WriteLine(Console.Title); //puxando o valor (para MOSTRAR o titulo)
                    Console.WriteLine("Operações" +
                        "\n[1] Adição" +
                        "\n[2] Subtração" +
                        "\n[3] Multiplicação" +
                        "\n[4] Divisão" +
                        "\n[0] Sair" +
                        "\nEscolha uma opção:");
                    opt = Convert.ToInt32(Console.ReadLine()); /* ReadLine(); = para receber a escolha do usuario
                Convert.ToInt32(Console.ReadLine()); = converter para int */
                    string vResp;
                    do{ 
                    if (opt >= 1 && opt <= 4) // maior ou igual 1 e menor igual a 4
                    {

                        Console.Clear();
                        Console.WriteLine("Informe o primeiro número:");
                        contas.Num1 = double.Parse(Console.ReadLine()); // pegar os números reais e guardar na memória(variável)
                        Console.WriteLine("Informe o segundo número:");
                        contas.Num2 = double.Parse(Console.ReadLine());

                    }
                    switch (opt)// trabalhar com a variável opt
                    {
                        case 1:
                            Console.WriteLine(contas.Somar());      // para priorizar e fazer uma conta utilizar ( ) na conta !!
                            break; // cancelar repetição                     
                        case 2:
                            Console.WriteLine(contas.Subtrair());
                            break;
                        case 3:
                            Console.WriteLine(contas.Multiplicacao());
                            break;
                        case 4:
                            Console.WriteLine(contas.Divisao());
                            break;
                        case 0:
                            Console.WriteLine(contas.Sair());
                            Thread.Sleep(4000);
                            break;
                        default:
                            Console.WriteLine("Opção Inválida!");
                            Thread.Sleep(4000);
                            opt = 5;
                            break;
                        }
                        if(opt == 0)
                        {
                            break;
                        }
                        else if(opt== 5)
                        {
                            break;
                        }
                        Console.WriteLine("\nDeseja repetir o procedimento?");
                        vResp = Console.ReadLine();
                    } while (vResp == "sim");
                } while (opt != 0);
              


            }
            catch (Exception ex)
            {
                Console.WriteLine("Aconteceu um erro: " + ex.Message);
            }
        }
    }
}
