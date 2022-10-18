using System.Net;
using static System.Console;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Title = "XD";
            ConsoleSpiner spin = new ConsoleSpiner();
            Console.ForegroundColor = ConsoleColor.Green;

            DownloadFileAsync().GetAwaiter();

            Console.WriteLine("Файл загружен");

            Console.Write("ConsoleAnimation....");
            while (true)
            {
                spin.Turn();
            }
            Console.ReadLine();
        }
        public class ConsoleSpiner
        {
            int counter;
            public ConsoleSpiner()
            {
                counter = 0;
            }
            public void Turn()
            {
                Console.CursorVisible = false;
                counter++;
                Thread.Sleep(100);
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
        private static async Task DownloadFileAsync()
        {
            Console.WriteLine(@"
 ▄████▄   ▒█████   ███▄    █   ██████  ▒█████   ██▓    ▓█████     ▄▄▄       ██▓███   ██▓███      ██▓
▒██▀ ▀█  ▒██▒  ██▒ ██ ▀█   █ ▒██    ▒ ▒██▒  ██▒▓██▒    ▓█   ▀    ▒████▄    ▓██░  ██▒▓██░  ██▒   ▓██▒
▒▓█    ▄ ▒██░  ██▒▓██  ▀█ ██▒░ ▓██▄   ▒██░  ██▒▒██░    ▒███      ▒██  ▀█▄  ▓██░ ██▓▒▓██░ ██▓▒   ▒██▒
▒▓▓▄ ▄██▒▒██   ██░▓██▒  ▐▌██▒  ▒   ██▒▒██   ██░▒██░    ▒▓█  ▄    ░██▄▄▄▄██ ▒██▄█▓▒ ▒▒██▄█▓▒ ▒   ░██░
▒ ▓███▀ ░░ ████▓▒░▒██░   ▓██░▒██████▒▒░ ████▓▒░░██████▒░▒████▒    ▓█   ▓██▒▒██▒ ░  ░▒██▒ ░  ░   ░██░
░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ▒ ▒▓▒ ▒ ░░ ▒░▒░▒░ ░ ▒░▓  ░░░ ▒░ ░    ▒▒   ▓▒█░▒▓▒░ ░  ░▒▓▒░ ░  ░   ░▓  
  ░  ▒     ░ ▒ ▒░ ░ ░░   ░ ▒░░ ░▒  ░ ░  ░ ▒ ▒░ ░ ░ ▒  ░ ░ ░  ░     ▒   ▒▒ ░░▒ ░     ░▒ ░         ▒ ░
░        ░ ░ ░ ▒     ░   ░ ░ ░  ░  ░  ░ ░ ░ ▒    ░ ░      ░        ░   ▒   ░░       ░░           ▒ ░
░ ░          ░ ░           ░       ░      ░ ░      ░  ░   ░  ░         ░  ░                      ░  
░                                                                                                   
");

            Console.WriteLine("Введите адрес сайта [example.net]");

            string websiteUrl = Console.ReadLine();

            Console.WriteLine("Путь куда сохранить файл [с:\\examle\\fileName.txt]");
            string filePath = Console.ReadLine();

            WebClient client = new WebClient();
            await client.DownloadFileTaskAsync(new Uri($"https://{websiteUrl}"), filePath);
        }
    }
}