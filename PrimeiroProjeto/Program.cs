using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimeiroProjeto{
	class Program
	{
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Raiz");
                Console.WriteLine("6 - Potencia");
                Console.WriteLine("7 - Sair \n");

                int calculo = int.Parse(Console.ReadLine());

                switch (calculo)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Sub();
                        break;
                    case 3:
                        Mult();
                        break;
                    case 4:
                        Div();
                        break;
                    case 5:
                        Raiz();
                        break;
                    case 6:
                        Pot();
                        break;
                    case 7:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Operação indefinida! \n");
                        break;
                }
            }
        }

        static void Soma()
        {
            Console.WriteLine("\nCálculo de soma!\n");
            Console.WriteLine("Insira o primeiro número da soma: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número da soma: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine($"\nResultado da sua soma é: {resultado}\n");
            Console.WriteLine("Pressione enter para voltar ao menu!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Sub()
        {
            Console.WriteLine("\nCálculo de subtração!\n");
            Console.WriteLine("Insira o primeiro número da subtração: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número da subtração: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 - num2;
            Console.WriteLine($"\nResultado da sua subtração é: {resultado}\n");
            Console.WriteLine("Pressione enter para voltar ao menu!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Mult()
        {
            Console.WriteLine("\nCálculo de multiplicação!\n");
            Console.WriteLine("Insira o primeiro número da multiplicação: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número da multiplicação: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 * num2;
            Console.WriteLine($"\nResultado da sua multiplicação é: {resultado}\n");
            Console.WriteLine("Pressione enter para voltar ao menu!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Div()
        {
            Console.WriteLine("\nCálculo de divisão!\n");
            Console.WriteLine("Insira o primeiro número da divisão: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número da divisão: ");
            int num2 = int.Parse(Console.ReadLine());
            double resultado = (double)num1 / (double)num2;
            double numeroDouble = resultado;
            string numeroDecimal = numeroDouble.ToString("F1", CultureInfo.InvariantCulture);
            Console.WriteLine($"\nResultado da sua divisão é: {numeroDecimal}\n");
            Console.WriteLine("Pressione enter para voltar ao menu!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Raiz()
        {
            Console.WriteLine("\nCálculo de raiz!\n");
            Console.WriteLine("Insira o valor da sua raiz: ");
            int num1 = int.Parse(Console.ReadLine());
            double resultado = (double)Math.Sqrt((double)num1);
            double numeroDouble = (double)resultado;
            string numeroDecimal = numeroDouble.ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine($"\nResultado da sua raiz é: {numeroDecimal}\n");
            Console.WriteLine("Pressione enter para voltar ao menu!");
            Console.ReadLine();
            Console.Clear();
        }

        static void Pot()
        {
            Console.WriteLine("\nCálculo de potencia!\n");
            Console.WriteLine("Insira o valor da base: ");
            int baseNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do expoente: ");
            int expNum2 = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum1, expNum2);
            Console.WriteLine($"\nResultado da sua potenciação é: {resultado}\n");
            Console.WriteLine("Pressione enter para voltar ao menu!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}