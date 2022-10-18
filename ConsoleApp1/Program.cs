using System.Net;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Введите адрес сайта [example.net]");
            //string websiteUrl = Console.ReadLine();

            //WebClient client = new WebClient();

            //using (Stream stream = client.OpenRead($"https://{websiteUrl}"))
            //{
            //    using (StreamReader reader = new StreamReader(stream))
            //    {
            //        string line = "";
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}

            //Console.WriteLine("Файл загружен");
            //Console.Read();

            DownloadFileAsync().GetAwaiter();

            Console.WriteLine("Файл загружен");
            Console.ReadLine();
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