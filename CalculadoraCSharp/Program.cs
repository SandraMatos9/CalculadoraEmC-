using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp
{
    internal class Program
    {

        enum Menu { Soma=1, Subtracao=2, Divisao=3,Multiplicacao=4, Potencia=5, Raiz=6 , Sair=7}
        static void Main(string[] args)

        {
            bool opcaoSair=false;
            while(!opcaoSair)
            {
                Console.WriteLine("Seja bem vindo(a) a calculadora, selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        opcaoSair = true;
                        break;

                }

                Console.Clear();    
            }
           


        }
        static void Soma() 
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}" );
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado =(float)a/(float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de um número: ");
            Console.WriteLine("Digite o valor da base: ");
            int base_numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente : ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado =(int)Math.Pow( base_numero,expoente);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um números: ");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
