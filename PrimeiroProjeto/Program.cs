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
            int resultado = 0;
            char repetir;

            do
            { 
                Console.WriteLine("Qual operção deseja fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão \n");

                int calculo = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite o primeiro número da operação:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número da operação:");
                int num2 = int.Parse(Console.ReadLine());
                
                switch (calculo)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        resultado = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Operação indefinida! \n");
                        break;
                }
                Console.WriteLine("\nResultado de sua operação é: " + resultado);
                Console.WriteLine("\nDeseja efetuar uma outra operação (S/N)?");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');
            Console.WriteLine("Obrigado por utilizar minha calculadora com DoWhile e Switch Case!");
            Console.ReadLine();
        }
    }
}