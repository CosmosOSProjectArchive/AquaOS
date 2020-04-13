using System;
using System.IO;
using Sys = Cosmos.System;
namespace CosmosKernelTest
{
    public class Kernel : Sys.Kernel
    {
        private int num1;
        private int num2;
        private object sum;

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Aqua OS Version 0.31 by Kai Howard     .d8b.   .d88b.  db    db  .d8b.");
            Console.WriteLine("Powered by Cosmos                     d8' `8b .8P  Y8. 88    88 d8' `8b");
            Console.WriteLine("Options:                              88ooo88 88    88 88    88 88ooo88");
            Console.WriteLine("1: Boot Aqua OS normally              88~~~88 88    88 88    88 88~~~88");
            Console.WriteLine("2: Boot without FileSystem            88   88 `8P  d8' 88b  d88 88   88");
            Console.WriteLine("3: Boot in DEV mode                   YP   YP  `Y88d\\  ~Y8888P' YP   YP");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Chosen Option: "); var option = Console.ReadLine();
            if (option.Contains("1"))
            {
                var fs = new Sys.FileSystem.CosmosVFS();
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            }
            if (option.Contains("3"))
            {
                var fs = new Sys.FileSystem.CosmosVFS();
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (option.Contains("1"))
            {
                Console.WriteLine("_______                     _______________");
                Console.WriteLine("___    |_____ ____  _______ __  __ \\_  ___/");
                Console.WriteLine("__  /| |  __ `/  / / /  __ `/  / / /____ \\ ");
                Console.WriteLine("_  ___ / /_/ // /_/ // /_/ // /_/ /____/ / ");
                Console.WriteLine("/_/  |_\\__, / \\__,_/ \\__,_/ \\____/ /____/  ");
                Console.WriteLine("         /_/                               ");
            }
            if (option.Contains("2"))
            {
                Console.WriteLine("_______                     _______________");
                Console.WriteLine("___    |_____ ____  _______ __  __ \\_  ___/");
                Console.WriteLine("__  /| |  __ `/  / / /  __ `/  / / /____ \\ ");
                Console.WriteLine("_  ___ / /_/ // /_/ // /_/ // /_/ /____/ / ");
                Console.WriteLine("/_/  |_\\__, / \\__,_/ \\__,_/ \\____/ /____/  ");
                Console.WriteLine("         /_/                               ");
            }
            if (option.Contains("3"))
            {
                Console.WriteLine("_______                     _______________  ____________________    __");
                Console.WriteLine("___    |_____ ____  _______ __  __ \\_  ___/  ___  __ \\__  ____/_ |  / /");
                Console.WriteLine("__  /| |  __ `/  / / /  __ `/  / / /____ \\   __  / / /_  __/  __ | / / ");
                Console.WriteLine("_  ___ / /_/ // /_/ // /_/ // /_/ /____/ /   _  /_/ /_  /___  __ |/ /  ");
                Console.WriteLine("/_/  |_\\__, / \\__,_/ \\__,_/ \\____/ /____/    /_____/ /_____/  _____/   ");
                Console.WriteLine("         /_/                                        ");
            }
            if (option.Contains("2"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Aqua OS version 0.31 by Kai Howard.");
                Console.WriteLine("For help, run command: help.");
                Console.WriteLine("Thanks to the CosmosOS team, it is the base for this project.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WARNING: You have booted without a filesytem. DO NOT try to use it!");
            }
            else if (option.Contains("1"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Aqua OS version 0.31 by Kai Howard.");
                Console.WriteLine("For help, run command: help.");
                Console.WriteLine("FileSystem is not completed yet so it will be buggy.");
                Console.WriteLine("Thanks to the CosmosOS team, it is the base for this project.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Aqua OS version 0.31 by Kai Howard.");
                Console.WriteLine("For help, run command: help.");
                Console.WriteLine("FileSystem is not completed yet so it will be buggy.");
                Console.WriteLine("Thanks to the CosmosOS team, it is the base for this project.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("WARNING: Using dev mode will give access to untested/unfinished functions.");
                Console.WriteLine("BE CAREFUL");
            }
        }
        string dir = @"0:\";
        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("AquaOS @ " + dir + ": ");
            Console.ForegroundColor = ConsoleColor.White;
            var input = Console.ReadLine();
            if (input == "shutdown")
            {
                Sys.Power.Shutdown();
            }
            else
            if (input.Contains("mkfile"))
            {
                var file = (input.Remove(0, 7));
                File.Create(dir + "\\" + file);

            }
            else
            if (input.Contains("mkdir"))
            {
                Directory.CreateDirectory(input.Remove(0, 6));
                Console.WriteLine("OK");
            }
            else
            if (input.Contains("deldir"))
            {
                Directory.Delete(@"0:\" + input.Remove(0, 7));
            }
            else
            if (input.Contains("delfile"))
            {
                File.Delete(input.Remove(0, 8));
                Console.WriteLine("OK");
            }
            else
            if (input.Contains("cd"))
            {
                Directory.SetCurrentDirectory(@"0:\" + input.Remove(0, 3));
                dir = (@"0:\" + input.Remove(0, 3));
            }
            else
            if (input == "ls")
            {
                foreach (var directory in Directory.GetDirectories(dir))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(directory);
                }
                foreach (var file in Directory.GetFiles(dir))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(file);
                }

            }
            else
            if (input == ("creator"))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("          _____                    _____                    _____  ");
                Console.WriteLine("         /\\    \\                  /\\    \\                  /\\    \\ ");
                Console.WriteLine("        /::\\____\\                /::\\    \\                /::\\    \\     ");
                Console.WriteLine("       /:::/    /               /::::\\    \\               \\:::\\    \\     ");
                Console.WriteLine("      /:::/    /               /::::::\\    \\       .        \\:::\\    \\    ");
                Console.WriteLine("     /:::/    /               /:::/\\:::\\    \\               \\:::\\    \\   ");
                Console.WriteLine("    /:::/____/               /:::/__\\:::\\    \\               \\:::\\    \\    ");
                Console.WriteLine("   /::::\\    \\              /::::\\   \\:::\\    \\              /::::\\    \\ ");
                Console.WriteLine("  /::::::\\____\\________    /::::::\\   \\:::\\    \\    ____    /::::::\\    \\");
                Console.WriteLine(" /:::/\\:::::::::::\\    \\  /:::/\\:::\\   \\:::\\    \\  /\\   \\  /:::/\\:::\\    \\");
                Console.WriteLine("/:::/  |:::::::::::\\____\\/:::/  \\:::\\   \\:::\\____\\/::\\   \\/:::/  \\:::\\____\\");
                Console.WriteLine("\\::/   |::|~~~|~~~~~     \\::/    \\:::\\  /:::/    /\\:::\\  /:::/    \\::/    / ");
                Console.WriteLine(" \\/____|::|   |           \\/____/ \\:::\\/:::/    /  \\:::\\/:::/    / \\/____/ ");
                Console.WriteLine("       |::|   |                    \\::::::/    /    \\::::::/    /");
                Console.WriteLine("       |::|   |                     \\::::/    /      \\::::/____/");
                Console.WriteLine("       |::|   |                     /:::/    /        \\:::\\    \\ ");
                Console.WriteLine("       |::|   |                    /:::/    /          \\:::\\    \\");
                Console.WriteLine("       |::|   |                   /:::/    /            \\:::\\    \\");
                Console.WriteLine("       \\::|   |                  /:::/    /              \\:::\\____\\");
                Console.WriteLine("        \\:|   |                  \\::/    /                \\::/    / ");
                Console.WriteLine("         \\|___|                   \\/____/                  \\/____/ ");
            }
            else
            if (input == ("gettime"))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(DateTime.Now);
            }
            else
            if (input == ("echo"))
            {
            }
            else
            if (input.Contains("scribble"))
            {
                //Scribbler: a text editor written in 5 lines of code!
                Console.WriteLine("1st line: txt file. 2nd line: text to add.");
                var txtfile = Console.ReadLine();
                var ttw = Console.ReadLine();
                var oldtxt = File.ReadAllText(@"0:\" + txtfile);
                File.WriteAllText(@"0:\" + txtfile, oldtxt + ttw);

            }
            else
            if (input.Contains("readfile"))
            {
                var filetoread = (input.Remove(0, 9));
                Console.WriteLine(File.ReadAllText(dir + filetoread));
            }
            else
            if (input.Contains("echo"))
            {
                Console.WriteLine(input.Remove(0, 5));
            }
            else
            if (input == "help")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("about = os information");
                Console.WriteLine("help = list of commands");
                Console.WriteLine("shutdown = shuts down system");
                Console.WriteLine("mkfile (filename) = creates a file");
                Console.WriteLine("mkdir (dirname) = makes a directory");
                Console.WriteLine("deldir (dirname) = deletes a directory (not finished yet)");
                Console.WriteLine("delfile (filename) = deletes a file");
                Console.WriteLine("readfile (filename) = reads from file");
                Console.WriteLine("ls = lists files and directories");
                Console.WriteLine("cd (dirname) = changes directory");
                Console.WriteLine("cd\\ = returns to 0:\\ directory");
                Console.WriteLine("clear = clears the screen");
                Console.WriteLine("echo (text) = echoes user input");
                Console.WriteLine("gettime = displays date and time");
                Console.WriteLine("");
                Console.WriteLine("Included applications: ");
                Console.WriteLine("Scribbler: A text file editor written in 5 lines of code!");
                Console.WriteLine("To use, run the command: scribble");
            }
            else
            if (input == "clear")
            {
                Console.Clear();
            }
            else
            if (input == "about")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("AquaOS version 0.2 by Kai Howard");
            }
            else
            {
                if (input == "")
                {
                }
                else
                    Console.WriteLine("Unknown command: " + input);
            }
        }

        private static int Add(int n1, int n2, int n3)
        {
            int total = (n1 + n2 + n3);
            return total;
        }
    }
}