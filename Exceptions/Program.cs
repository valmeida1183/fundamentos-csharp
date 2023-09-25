using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                // for (var index = 0; index < 10; index++)
                // {
                //     Console.WriteLine(arr[index]);
                // }

                Salvar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice");
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Falha ao cadastrar texto!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops.. Algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }

        static void Salvar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException("O texto não pode ser nullo");
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(string message)
            {
                this.QuandoAconteceu = DateTime.Now;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
