using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.ResetColor();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void ShowSaveMenu(string text)
        {
            var readKey = Console.ReadKey();
            if (readKey.Key != ConsoleKey.Y)
            {
                Show();
                return;
            }

            FileHandler.Salvar(text);
        }

        private static void DrawScreen(short width = 30, short height = 10)
        {
            DrawTopBottomLine(width);
            DrawColumn("|", width, height);
            DrawTopBottomLine(width);
        }

        private static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        private static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: FileHandler.Abrir(); break;
                case 0:
                default:
                    {
                        Console.Clear();
                        Environment.Exit(0); break; // multiplas opções no case
                    }
            }
        }

        private static void DrawTopBottomLine(short width)
        {
            Console.Write("+");
            DrawLine("-", width);
            Console.Write("+");
            Console.Write("\n");
        }

        private static void DrawLine(string character, short width)
        {
            for (int i = 0; i <= width; i++)
            {
                Console.Write(character);
            }
        }

        private static void DrawColumn(string character, short width, short height)
        {
            for (int lines = 0; lines <= height; lines++)
            {
                Console.Write(character);
                DrawLine(" ", width);
                Console.Write(character);
                Console.Write("\n");
            }
        }
    }
}