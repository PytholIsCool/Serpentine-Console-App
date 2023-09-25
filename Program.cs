using System;
using System.Diagnostics;
using System.Threading;

namespace Serpentine_Console_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            string titleText = @"
██████████████████████████████████████████████████████████████████████████████╗
╚════════════════════════════════════════════════════════════════════════════█║
░██████╗███████╗██████╗░██████╗░███████╗███╗░░██╗████████╗██╗███╗░░██╗████████║
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝████╗░██║╚══██╔══╝██║████╗░██║██╔═════╝
╚█████╗░█████╗░░██████╔╝██████╔╝█████╗░░██╔██╗██║░░░██║░░░██║██╔██╗██║█████╗░░
░╚═══██╗██╔══╝░░██╔══██╗██╔═══╝░██╔══╝░░██║╚████║░░░██║░░░██║██║╚████║██╔══╝░░
██████╔╝███████╗██║░░██║██║░░░░░███████╗██║░╚███║░░░██║░░░██║██║░╚███║███████╗
█═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚══════╝
██████████████████████████████████████████████████████████████████████████████╗
╚═════════════════════════════════════════════════════════════════════════════╝
                  a l w a y s     w a t c h i n g . . .

Welcome to Serpentine. Please select an option.
1. Serpentine Public Discord
2. Serpentine VRChat Group
3. ERP (real)
4. Exit";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(titleText);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Opened link to the public Serpentine discord server in your default browser.");
                    OpenLinkAndExit("https://discord.gg/WNUvehhdvk");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Opened link to the Serpentine VRChat Group in your default browser.");
                    OpenLinkAndExit("https://vrchat.com/home/group/grp_26d8740c-0f44-49b8-bea7-e77695794b85");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine(@"YOU FOOL.
MUAHAHAHHAHAHAHAHA
");
                    OpenLinkAndExit("https://e621.net/posts/3301315");
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    DisplayErrorAndRestart();
                    break;
            }
        }

        private static void OpenLinkAndExit(string url)
        {
            Process.Start(url);
            Console.WriteLine("Press any key to close this program");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static void DisplayErrorAndRestart()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Serpentine] [Error] ~~> Invalid input value. Press enter to try again.");

            Console.ReadKey();
            Console.Clear();
            Main(new string[0]);
        }
    }
}