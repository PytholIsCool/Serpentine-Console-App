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
            Console.WriteLine($" [{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [Serpentine] ~~> " + "Invalid user input. Press any key to try again.");
            
            Console.ReadKey();
            Console.Clear();
            Main(new string[0]);
        }
    }
}

/*
This C# code is a simple console application called "Serpentine_Console_App." It displays a welcome message with some ASCII art, provides a menu for the user to choose from, and opens URLs in the default web browser based on the user's selection. Let's break down the code step by step:

1. Importing Necessary Libraries:
   - The code imports three namespaces: `System`, `System.Diagnostics`, and `System.Threading`, which provide various classes and functionalities for console applications.

2. Main Method:
   - The `Main` method is the entry point of the program. It takes command-line arguments as an array of strings (`args`).

3. Displaying ASCII Art:
   - The program starts by defining an array of `ConsoleColor` enums named `consoleColors`.
   - It then defines a multiline string `titleText`, which contains a large ASCII art design and some additional text.

4. Changing Console Text Color:
   - It sets the console text color to magenta using `Console.ForegroundColor` and then displays the `titleText`.

5. Reading User Input:
   - The program reads a line of user input from the console and stores it in the `input` variable.

6. Menu Selection:
   - It uses a `switch` statement to perform different actions based on the user's input:
     - If the input is "1," it opens a URL in the default browser and exits.
     - If the input is "2," it does the same for a different URL.
     - If the input is "3," it displays an amusing message and opens another URL.
     - If the input is "4," it exits the program.
     - If the input is anything else, it displays an error message and restarts the program.

7. Opening URLs:
   - The `OpenLinkAndExit` method takes a URL as an argument, opens it in the default web browser using `Process.Start(url)`, displays a message to close the program, waits for any key press, and then exits the program.

8. Handling Errors:
   - The `DisplayErrorAndRestart` method displays an error message in red, logs the timestamp, waits for a key press, clears the console, and then calls the `Main` method again to restart the program.

Overall, this code provides a simple interactive menu for the user to open specific URLs in a web browser or exit the program. If the user enters an invalid option, it displays an error message and allows them to try again.
*/
