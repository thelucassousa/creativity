using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program

    {
        enum Opcao {Somar = 1, Subtrair, Multiplicar, Dividir};

        static void Main(string[] args)
        {
            Console.WriteLine("Olá, seja bem-vindo");
            Console.WriteLine("1 - Somar \n2 - Subtrair\n3 - Multiplicar\n4 - Dividir ");
            Console.Write("Escolha uma opção: ");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSel = (Opcao)index;

            switch (opcaoSel)
            {
                case Opcao.Somar:
                    Console.Write("Somar:");
                    int somaN1 = int.Parse(Console.ReadLine());
                    Console.Write($"Somar {somaN1} + ");
                    int somaN2 = int.Parse(Console.ReadLine());
                    int resultadoSoma = Soma(somaN1, somaN2);
                    Console.WriteLine($"O resultado da soma é {resultadoSoma}");
                    break;
                case Opcao.Subtrair:
                    Console.Write("Subtrair:");
                    int subtraiN1 = int.Parse(Console.ReadLine());
                    Console.Write($"Subtrair {subtraiN1} - ");
                    int subtraiN2 = int.Parse(Console.ReadLine());
                    int resultadoSub = Subtrair(subtraiN1, subtraiN2);
                    Console.WriteLine($"O resultado da subtração é {resultadoSub}");
                    break;
                case Opcao.Multiplicar:
                    Console.Write("Multiplicar:");
                    int multiplicaN1 = int.Parse(Console.ReadLine());
                    Console.Write($"Multiplicar {multiplicaN1} * ");
                    int multiplicaN2 = int.Parse(Console.ReadLine());
                    int resultadoMult = Multiplicar(multiplicaN1, multiplicaN2);
                    Console.WriteLine($"O resultado da multiplicação é {resultadoMult}");
                    break;
                case Opcao.Dividir:
                    Console.Write(Opcao.Dividir + " ");
                    int dividiN1 = int.Parse(Console.ReadLine());
                    Console.Write($"Dividir {dividiN1} / ");
                    int dividiN2 = int.Parse(Console.ReadLine());
                    int resultadoDivi = Divisao(dividiN1, dividiN2);
                    Console.WriteLine($"O resultado da divisão é {resultadoDivi}");
                    break;
                default:
                    Console.WriteLine("Erro, por gentileza, tente novamente.");
                    break;
            }


            Console.ReadLine();

        }

        static void Imprimi(string OpcaoSel)
        {
            string opcaoEsc = OpcaoSel;

            switch (OpcaoSel)
            {


            }
            

        }
        static int Soma(int n1, int n2)
        {
            int resultado = n1 + n2;
            return resultado;
        }
        static int Subtrair (int n1, int n2)
        {
            int resultado = n1 - n2;
            return resultado;
        }
        static int Multiplicar (int n1, int n2)
        {
            int resultado = n1 * n2;
            return resultado;
        }
        static int Divisao (int n1, int n2)
        {
            int resultado = n1 / n2;
            return resultado;
        }

    }
}
