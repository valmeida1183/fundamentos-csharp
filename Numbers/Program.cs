using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m; // para trabalhar com moedas o melhor é utilizar o tipo decimal, pois ele tem a precisão maior uqe float e double.           
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

            decimal outroValor = 10345.8749m;
            Console.WriteLine(Math.Round(outroValor)); // arredonda para cima ou para baixo dependendo do valor.
            Console.WriteLine(Math.Ceiling(outroValor)); // arredonda para cima.
            Console.WriteLine(Math.Floor(outroValor)); // arredonda para baixo.
        }
    }
}
