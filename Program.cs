using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;




//              This tool Made with Loove <3 :)
//              By BLVCK PANTHER | Website : https//khaledalsubaie.com 
//              Twitter : _1president
//              instagram : h0w1
//              GitHub : BLVCK1PANTHER

//              Thank You



namespace SubHunter
{
    class Program
    {
        public static string targetdomain;
        public static List<string> words , activedomains = new List<string>();
        public static int trying = 0, alive = 0;
        public static bool StopTool = false;
        public static Random random = new Random();
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 25);
            Console.Title = "SubHunter V1.0 by BLVCK PANTHER";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
              _____       _     _    _             _            
             / ____|     | |   | |  | |           | |           
            | (___  _   _| |__ | |__| |_   _ _ __ | |_ ___ _ __ 
             \___ \| | | | '_ \|  __  | | | | '_ \| __/ _ \ '__|
             ____) | |_| | |_) | |  | | |_| | | | | ||  __/ |   
            |_____/ \__,_|_.__/|_|  |_|\__,_|_| |_|\__\___|_|   
                                                                
                                                     
             By BLVCK PANTHER -> GitHub : BLVCK1PANTHER | Twitter : _1president 

__________________________________________________________________________________________

");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            IL_FIRST:
            Console.WriteLine("  BruteForce From WordList = [ 1 ] | BruteForce From Letter Genrator = [ 2 ]\n");
            Console.Write("  Your Choice => ");
            var choice = Console.ReadKey();
            Console.WriteLine();
            if(choice.Key == ConsoleKey.D1)
            {
                IL_SECOND:
                Console.WriteLine("\n  Local WordList = [ 1 ] | Import Your Own WordList = [ 2 ]\n");
                Console.Write("  Your Choice => ");
                var choice2 = Console.ReadKey();
                if (choice2.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\n\n  Loading For Load The Wordlist ...");
                    if (File.Exists("wordlist\\WordList.txt"))
                    {
                        words = File.ReadAllLines("wordlist\\WordList.txt").ToList();
                        if (words.Count <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("  Local WordList is Empty !!!");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                        }
                        Console.Write("\n  Your Target Domain => ");
                        targetdomain = Console.ReadLine();
                    IL_THIRD:
                        Console.Write("\n  Do You Want Use Deep Hunting? [Y/N] => ");
                        var choice3 = Console.ReadKey();
                        if (choice3.Key == ConsoleKey.Y)
                        {
                        IL_3:
                            Console.Write("\n\n  Choose The Depth LEVEL > [ 2 ] [ 3 ] [ 4 ]");
                            var choice4 = Console.ReadKey();
                            if (choice4.Key == ConsoleKey.D2)
                            {
                                Console.Clear();
                                foreach (string word in words)
                                {
                                    DoGetHostEntry(Randomizer(RandomNumber(1)) + "." + word + "." + targetdomain);

                                }
                            }
                            else if (choice4.Key == ConsoleKey.D3)
                            {
                                Console.Clear();
                                foreach (string word in words)
                                {
                                    DoGetHostEntry(Randomizer(RandomNumber(1)) + "." + Randomizer(RandomNumber(1)) + "." + word + "." + targetdomain);
                                }
                            }
                            else if (choice4.Key == ConsoleKey.D4)
                            {
                                Console.Clear();
                                foreach (string word in words)
                                {
                                    DoGetHostEntry(Randomizer(RandomNumber(1)) + "." + Randomizer(RandomNumber(1)) + ". " + Randomizer(RandomNumber(1)) + "." + word + "." + targetdomain);
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n  Wrong Choice ...");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                goto IL_3;
                            }
                        }
                        else if (choice3.Key == ConsoleKey.N)
                        {
                            Console.Clear();
                            foreach (string word in words)
                            {
                                DoGetHostEntry(word + "." + targetdomain);
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n  Wrong Choice ...");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            goto IL_THIRD;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  Local WordList not Found !!!");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        goto IL_FIRST;
                    }
                }
                else if (choice2.Key == ConsoleKey.D2)
                {
                    IL_2:
                    Console.Write("\n\n  Enter WordList Path => ");
                    string path = Console.ReadLine();
                    if (File.Exists(path))
                    {
                        WebClient webClient = new WebClient();
                        words = File.ReadAllLines(path).ToList();
                        if (words.Count <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("  WordList is Empty !!!");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            goto IL_2;
                        }
                        Console.Write("\n  Your Target Domain => ");
                        targetdomain = Console.ReadLine();
                    IL_THIRD2:
                        Console.Write("\n  Do You Want Use Deep Hunting? [Y/N] => ");
                        var choice3 = Console.ReadKey();
                        if (choice3.Key == ConsoleKey.Y)
                        {
                        IL_32:
                            Console.Write("\n\n  Choose The Depth LEVEL > [ 2 ] [ 3 ] [ 4 ]");
                            var choice4 = Console.ReadKey();
                            if (choice4.Key == ConsoleKey.D2)
                            {
                                Console.Clear();
                                foreach (string word in words)
                                {
                                    DoGetHostEntry(Randomizer(RandomNumber(1)) + "." + word + "." + targetdomain);
                                }
                            }
                            else if (choice4.Key == ConsoleKey.D3)
                            {
                                Console.Clear();
                                foreach (string word in words)
                                {
                                    DoGetHostEntry(Randomizer(RandomNumber(1)) + "." + Randomizer(RandomNumber(1)) + "." + word + "." + targetdomain);
                                }
                            }
                            else if (choice4.Key == ConsoleKey.D4)
                            {
                                Console.Clear();
                                foreach (string word in words)
                                {
                                    DoGetHostEntry(Randomizer(RandomNumber(1)) + "." + Randomizer(RandomNumber(1)) + ". " + Randomizer(RandomNumber(1)) + "." + word + "." + targetdomain);
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n  Wrong Choice ...");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                goto IL_32;
                            }
                        }
                        else if (choice3.Key == ConsoleKey.N)
                        {
                            Console.Clear();
                            foreach (string word in words)
                            {
                                DoGetHostEntry(word + "." + targetdomain);
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n  Wrong Choice ...");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            goto IL_THIRD2;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  WordList not Found !!!");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        goto IL_2;
                    }
                }
                else
                {
                    goto IL_SECOND;
                }
            }
            else if(choice.Key == ConsoleKey.D2)
            {
                Console.Write("\n  Your Target Domain => ");
                targetdomain = Console.ReadLine();
                Console.Clear();
                while (!Program.StopTool)
                {
                    try
                    {
                        DoGetHostEntry(Randomizer(RandomNumber(1)) + "." + targetdomain);
                    }
                    catch (Exception)
                    {
                    }
                    Thread.Sleep(random.Next(10, 25));
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n  Wrong Choice ...");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                goto IL_FIRST;
            }
        }



        //Functions



        public static void DoGetHostEntry(string hostname)
        {
            IPHostEntry host;
            try
            {
                host = Dns.GetHostEntry(hostname);
                if (host != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if(!activedomains.Contains(hostname))
                    {
                        alive++;
                        Console.WriteLine("  " + hostname + " is Alive");
                        File.AppendAllText("ActiveDomains.txt", hostname + "\n");
                        activedomains.Add(hostname);
                    }
                    Console.Title = $"SubHunter V1.0 by BLVCK PANTHER ...   |    Trying = {trying.ToString("###,###")}    |    Alive = {alive.ToString("###,###")}    |";
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
            }
            catch(Exception)
            {
                trying++;
                Console.Title = $"SubHunter V1.0 by BLVCK PANTHER ...   |    Trying = {trying.ToString("###,###")}    |    Alive = {alive.ToString("###,###")}    |";
                Console.WriteLine("  " + hostname + " is Dead");
                File.AppendAllText("DeadDomains.txt", hostname + "\n");
                return;
            }

        }

        public static string Randomizer(int Length)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string RealyRandom = "abcdefghijklmnopqrstuvwxyz1234567890";
            Random random = new Random();
            checked
            {
                int num = Length - 1;
                for (int i = 0; i <= num; i++)
                {
                    stringBuilder.Append(RealyRandom[random.Next(RealyRandom.Length)]);
                }
                return stringBuilder.ToString();
            }
        }

        public static int RandomNumber(int Number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string RealyRandom = "1234567";
            Random random = new Random();
            checked
            {
                int num = Number - 1;
                for (int i = 0; i <= num; i++)
                {
                    stringBuilder.Append(RealyRandom[random.Next(RealyRandom.Length)]);
                }
                return Convert.ToInt32(stringBuilder.ToString());
            }
        }
    }
}
