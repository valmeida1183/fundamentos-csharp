using System;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Arrays
            var meuArray = new int[5]; // arrays no C# devem ter seu tamanho especificado na sua criação; no caso 5 posições do 0 ao 4.
            meuArray[0] = 10;
            meuArray[1] = 11;
            meuArray[2] = 12;
            meuArray[3] = 13;
            meuArray[4] = 14;

            // For
            var meuArrayInicializado = new int[5] { 1, 2, 3, 4, 5 };
            for (var index = 0; index < meuArrayInicializado.Length; index++)
            {
                Console.WriteLine(meuArrayInicializado[index]);
            }

            // Foreach
            var outroArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach (var item in outroArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
