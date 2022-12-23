using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program

    {
        enum Opcao {Somar, Subtrair, Multiplicar, Dividir};

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
                    Console.WriteLine("Somar:");
                    int somaN1 = int.Parse(Console.ReadLine());
                    Console.Write($"Somar {somaN1} + ");
                    int somaN2 = int.Parse(Console.ReadLine());
                    int resultadoSoma = Soma(somaN1, somaN2);
                    Console.WriteLine($"O resultado da soma é {resultadoSoma}");
                    break;
            }


            Console.ReadLine();

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
