using System;
using System.IO;

namespace EditorHtml
{
    public static class FileHandler
    {
        public static string FileFolder { get => @$"{Directory.GetCurrentDirectory()}\Arquivos"; }

        public static void Salvar(string text)
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Qual o nome do arquivo que deseja salvar?");
            var fileName = Console.ReadLine();
            fileName = HandleFileName(fileName);

            if (!Directory.Exists(FileFolder))
            {
                Directory.CreateDirectory(FileFolder);
            }

            var filePath = @$"{FileFolder}\{fileName}.txt";
            using (var file = new StreamWriter(filePath))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {filePath} salvo com sucesso!");
            Console.ReadLine();

        }

        public static void Abrir()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Qual o nome do arquivo que deseja abrir?");
            var text = "";

            var fileName = Console.ReadLine();
            fileName = HandleFileName(fileName);
            var filePath = @$"{FileFolder}\{fileName}.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("O arquivo não existe!");
                Console.ReadLine();
                Menu.Show();
            }
            else
            {
                using (var file = new StreamReader(filePath))
                {
                    text = file.ReadToEnd();
                    Viewer.Show(text);
                }
            }
        }

        private static string HandleFileName(string fileName)
        {
            if (fileName.Contains("."))
            {
                fileName = fileName.Remove(fileName.LastIndexOf("."), (fileName.Length - fileName.LastIndexOf(".")));
            }

            return fileName;
        }
    }
}