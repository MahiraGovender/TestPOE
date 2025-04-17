using System.Media;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();

            bool running = true;
            while (running)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine("What is your name?");
                Console.WriteLine("-----------------------------------------------------------------------------------------\n");
                string name = Console.ReadLine();
                if (name.Any(char.IsDigit) || name.Any(char.IsPunctuation))
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                    Console.WriteLine("Please do not use special symbols or numbers in your name");
                    Console.WriteLine("-----------------------------------------------------------------------------------------\n");
                }
                else if (name.Equals(""))
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                    Console.WriteLine("I require a name to know how to address you.");
                    Console.WriteLine("-----------------------------------------------------------------------------------------\n");
                }

                else
                {
                    Console.WriteLine("\n-----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Nice to meet you {name}");
                    Console.WriteLine("-----------------------------------------------------------------------------------------");
                }
            }
        }

        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\r\n  _____     __                                _ __         ___                                         ___       __ \r\n / ___/_ __/ /  ___ _______ ___ ______ ______(_) /___ __  / _ |_    _____ ________ ___  ___ ___ ___   / _ )___  / /_\r\n/ /__/ // / _ \\/ -_) __(_-</ -_) __/ // / __/ / __/ // / / __ | |/|/ / _ `/ __/ -_) _ \\/ -_|_-<(_-<  / _  / _ \\/ __/\r\n\\___/\\_, /_.__/\\__/_/ /___/\\__/\\__/\\_,_/_/ /_/\\__/\\_, / /_/ |_|__,__/\\_,_/_/  \\__/_//_/\\__/___/___/ /____/\\___/\\__/ \r\n    /___/                                        /___/                                                              \r\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            SoundPlayer player = new SoundPlayer("Greetings.wav");
            player.Play();
            Console.WriteLine("\r\n                                          \r\n (  (           (                         \r\n )\\))(   '   (  )\\             )      (   \r\n((_)()\\ )   ))\\((_) (   (     (      ))\\  \r\n_(())\\_)() /((_)_   )\\  )\\    )\\  ' /((_) \r\n\\ \\((_)/ /(_)) | | ((_)((_) _((_)) (_))   \r\n \\ \\/\\/ / / -_)| |/ _|/ _ \\| '  \\()/ -_)  \r\n  \\_/\\_/  \\___||_|\\__|\\___/|_|_|_| \\___|  \r\n                                          \r\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Press any key to continue");
            Console.WriteLine("-----------------------------------------------------------------------------------------\n");
            Console.ReadKey();
            player.Stop();
        }
    }
}
