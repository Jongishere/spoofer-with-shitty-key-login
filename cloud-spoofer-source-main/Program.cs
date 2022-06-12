/// cloudy

using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using JONGERS;

namespace JONGERS
{
   
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nLogin :\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Input your key: ");
                username = Console.ReadLine();


                if (username != "2##azdacscasdawgsdfsdf3124@6869")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "2##azdacscasdawgsdfsdf3124@6869") && (ctr != 9999999999999));

            Console.WriteLine("Successfully Logged In");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("#####   ##      #####  ##   ## ######");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("##   ## ##     ##   ## ##   ## ##   ##");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("##      ##     ##   ## ##   ## ##   ##");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("##      ##     ##   ## ##   ## ##   ##");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("##      ##     ##   ## ##   ## ##   ##");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("##   ## ##     ##   ## ##   ## ##   ##");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" #####  ####### #####   #####  ###### ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press [Enter] to start");
            Console.WriteLine();
            Console.ReadKey();

            ShowSimplePercentage();

            Console.ReadKey();
        }

        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($" \rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\r Done!          ");
            Console.Clear();
        Menu:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.Title = "[Cloud Spoofer] https://discord.gg/jong "; /// 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                          ========================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                                Cloud Spoofer");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                          ========================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                           [!hwid] Spoof HWID");  /// start spoof
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" [+] Select your option :  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string option = Console.ReadLine();

            if (option == "!hwid")
            {
                MessageBox.Show(" Spoofing");
                Spoofer.Spoof();
                MessageBox.Show(" Done! Restart your pc bozo");
                Environment.Exit(0);
                goto Menu;
            }
            else if (option == "902")
            {
                MessageBox.Show(" Cleaning"); 
                Spoofer.Clean();
                MessageBox.Show(" Done!");
                goto Menu;

            }
            else
            {
                Console.Clear();
                Console.WriteLine(" Wrong button try again!");
                Thread.Sleep(2000);
                Console.Clear();
                goto Menu;
            }
        }
    }
}
