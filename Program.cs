using System;
using System.Diagnostics;

namespace Serpentine_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Serpentine Console App";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"
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
4. Exit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    OpenLinkAndExit("https://discord.gg/WNUvehhdvk");
                    break;
                case "2":
                    OpenLinkAndExit("https://vrchat.com/home/group/grp_26d8740c-0f44-49b8-bea7-e77695794b85");
                    break;
                case "3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU FOOL.\nMUAHAHAHHAHAHAHAHA\n");
                    OpenLinkAndExit("https://e621.net/posts/3301315");
                    break;
                case "4":
                    ExitConfirmation();
                    break;
                default:
                    DisplayErrorAndRestart();
                    break;
            }
        }

        private static void OpenLinkAndExit(string url)
        {
            Process.Start(url);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($" [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [Serpentine] ~~> " + "Opened link in your default browser.");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press enter to go back to the menu.");
            Console.ReadLine();
            Console.Clear();
            Main(Array.Empty<string>());
        }

        private static void DisplayErrorAndRestart()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [Error] [Serpentine] Invalid user input. Press any key to try again.");
            Console.ReadKey();
            Console.Clear();
            Main(Array.Empty<string>());
        }

        private static void ExitConfirmation()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Are you sure you want to exit the program? (Y/N)");
            string exitConfirm = Console.ReadLine().Trim().ToLower();

            if (exitConfirm == "y" || exitConfirm == "yes")
                Environment.Exit(0);
            else if (exitConfirm == "n" || exitConfirm == "no")
            {
                Console.Clear();
                Main(Array.Empty<string>());
            }
            else
            {
                Console.WriteLine($" [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [Error] [Serpentine] Invalid user input. Press any key to try again.");
                Console.ReadLine();
                Console.Clear();
                ExitConfirmation();
            }
        }
    }
}
