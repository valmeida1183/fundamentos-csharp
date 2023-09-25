using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guids
            Console.WriteLine("------------Guids--------------");
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("ff58dcb4-e1a5-42fe-9f53-03729bd97b1b");
            Console.WriteLine(id.ToString().Substring(0, 8));

            Console.WriteLine("------------Interpolação--------------");
            // Interpolação de Strings
            var price = 10.2;
            var texto = "O preço do produto é: " + price + "\n apenas na promoção deste final de ano de 2021";
            Console.WriteLine(texto);

            var texto2 = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);
            Console.WriteLine(texto2);

            // com o $ faço a interpolação e com o @ posso quebrar em várias linhas e também vai ignorar expressões e caracteres especiais (ex: o '\n').
            var texto3 = $@"O preço do produto é {price} 
            apenas na promoção desta semana de natal!";
            Console.WriteLine(texto3);

            Console.WriteLine("------------Comparação de strings--------------");
            //Comparação de strings com CompareTo
            var comp = "Testando";
            Console.WriteLine(comp.CompareTo("Testando")); // CompartoTo retorna um inteiro onde 0 = true e 1 = false... é estranho mesmo
            Console.WriteLine(comp.CompareTo("testando"));
            Console.WriteLine(comp.CompareTo("taxtando"));

            //Comparação de strings com Contains
            var comp2 = "Este texto é um Teste";
            Console.WriteLine(comp2.Contains("Este texto é um Teste")); // Já Contains retorna um booleano se contiver uma parte do texto que é mais amigável em várias situações.
            Console.WriteLine(comp2.Contains("teste", StringComparison.OrdinalIgnoreCase)); // vai ignorar o Case sensitive.

            //Comparação de strings com StartsWith
            var comp3 = "Este texto também é um teste";
            Console.WriteLine(comp3.StartsWith("Este"));
            Console.WriteLine(comp3.StartsWith("este"));
            Console.WriteLine(comp3.StartsWith("texto"));

            //Comparação de strings com EndsWith
            Console.WriteLine(comp3.EndsWith("teste"));
            Console.WriteLine(comp3.EndsWith("Teste"));
            Console.WriteLine(comp3.EndsWith("batata"));

            //Comparação de strings com Equals
            var comp4 = "Este é um novo teste";
            Console.WriteLine(comp4.Equals("Este é um novo teste"));
            Console.WriteLine(comp4.Equals("este é um novo teste"));
            Console.WriteLine(comp4.Equals("este é um novo teste", StringComparison.OrdinalIgnoreCase));

            //Índices
            Console.WriteLine("------------Índices--------------");
            var texto4 = "Este texto é um outro teste";
            Console.WriteLine(texto4.IndexOf("é"));
            Console.WriteLine(texto4.IndexOf("texto"));
            Console.WriteLine(texto4.LastIndexOf("e"));

            //Métodos Adicionais
            Console.WriteLine("------------Métodos Adicionais--------------");
            var texto5 = "Este texto é um dos últimos testes";
            Console.WriteLine(texto5.ToLower());
            Console.WriteLine(texto5.ToUpper());
            var textModificado = texto5.Insert(5, "AQUI ");
            Console.WriteLine(textModificado);
            textModificado = textModificado.Remove(5, 5); // começo na posição 5 e removo os próximos 5 caracteres.
            Console.WriteLine(textModificado);
            Console.WriteLine(textModificado.Length);

            textModificado = textModificado.Replace("Este", "Isto");
            Console.WriteLine(textModificado);
            textModificado = texto5.Replace("e", "X");
            Console.WriteLine(textModificado);
            var textoSplit = texto5.Split(" ");
            Console.WriteLine(textoSplit[0]);
            Console.WriteLine(textoSplit[1]);
            Console.WriteLine(textoSplit[2]);
            Console.WriteLine(textoSplit[3]);
            Console.WriteLine(textoSplit[4]);
            Console.WriteLine(textoSplit[5]);
            Console.WriteLine(textoSplit[6]);

            //Substring
            var resultado = texto5.Substring(0, 4);
            Console.WriteLine(resultado);

            //Trim
            var texto6 = " Este é um texto para utilizar o trim ";
            Console.WriteLine(texto6.Trim());
            Console.WriteLine(texto6.TrimStart());
            Console.WriteLine(texto6.TrimEnd());
            var textoBuilder = new StringBuilder();
            textoBuilder.Append("Esta é a primeira sentença ");
            textoBuilder.Append("de um texto longo ");
            textoBuilder.Append("com muitas palavras ");
            textoBuilder.AppendLine("Aqui será uma nova linha!");

            Console.WriteLine(textoBuilder.ToString());
        }
    }
}
