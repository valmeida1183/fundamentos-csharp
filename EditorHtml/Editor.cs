using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("(Digite ESC para sair do modo de edição)");
            Console.WriteLine("------------------------------------------------------------");
            Start();
        }

        public static void Start()
        {
            var text = new StringBuilder();
            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(@"Deseja salvar o arquivo? (y/n)");
            Menu.ShowSaveMenu(text.ToString());
            Menu.Show();
        }
    }
}