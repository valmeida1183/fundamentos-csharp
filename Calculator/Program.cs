using System;

namespace Calculator
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
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da soma: {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração: {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisão: {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação: {resultado}");
            Console.ReadKey();

            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("1 - Soma");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("2 - Subtração");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("3 - Divisão");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("4 - Multiplicação");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("5 - Sair");

            Console.ResetColor();
            Console.WriteLine("--------------------------");

            Console.WriteLine("Selecione uma opção:");
            short result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: RecarregarMenu(); break;
            }
        }

        static void RecarregarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida!!");
            Console.WriteLine("Pressione qualquer tecla para continuar!");
            Console.ResetColor();
            Console.ReadKey();

            Menu();
        }

        static void Sair()
        {
            Console.WriteLine("Obrigado por usar o sistema!");
            System.Threading.Thread.Sleep(2000);
            System.Environment.Exit(0);
        }
    }
}
