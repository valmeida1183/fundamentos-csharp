using System;

namespace MeuApp // namespaces é a divisão lógica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo Switch 

            int valor = 1;
            switch (valor)
            {
                case 1:
                    Console.WriteLine("É UM");
                    break;
                case 2:
                    Console.WriteLine("É DOIS");
                    break;
                case 3:
                    Console.WriteLine("É TRÊS");
                    break;
                case 4:
                    Console.WriteLine("É QUATRO");
                    break;
                default:
                    Console.WriteLine("É CINCO");
                    break;
            }

            // Exemplo For
            for (var i = 0; i <= 5; i++)
                Console.WriteLine(i);

            // Exemplo While
            Int16 contador = 0;
            while (contador <= 5)
            {
                Console.WriteLine(contador);
                contador++;
            }

            // Exemplo Do While
            Int16 contador2 = 0;
            do
            {
                Console.WriteLine(contador2);
                contador2++;
            } while (contador2 <= 5);

            MeuMetodo();
            string nomeCompleto = RetornaNome("Vinicius", "Lopes de Almeida", 38);
            Console.WriteLine(nomeCompleto);

            ValueTypes();
            ReferenceTypes();

            var mouse = new Product(1, "Mouse Gamer", 199.50, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 320.50, EProductType.Service);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal");
        }

        static string RetornaNome(string nome, string sobreNome, int idade = 20) // parâmetros opcionais vem por último
        {
            return nome + " " + sobreNome + " tem " + idade.ToString();
        }

        static void ValueTypes()
        {
            int x = 25;
            int y = x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            x = 32;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        static void ReferenceTypes()
        {
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
