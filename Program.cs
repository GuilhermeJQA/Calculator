using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float number2 = float.Parse(Console.ReadLine());

            float result = number1 + number2;
            Console.WriteLine($"O resultado da soma é: {result}");
            //Console.WriteLine("O resultado da soma é: " + (number1 + number2));
            //Console.WriteLine($"O resultado da soma é: {number1 + number2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float number2 = float.Parse(Console.ReadLine());

            float result = number1 - number2;
            Console.WriteLine($"O resultado da subtração é: {result}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float number2 = float.Parse(Console.ReadLine());

            float result = number1 / number2;
            Console.WriteLine($"O resultado da divisão é: {result}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()

        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float number2 = float.Parse(Console.ReadLine());

            float result = number1 * number2;
            Console.WriteLine($"O resultado da multiplicacao é: {result}");
            Console.ReadKey();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Qual tipo de operação deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }


        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Até logo!");
            System.Environment.Exit(0);
        }
    }
}

