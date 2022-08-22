using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlikiFoldery
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKeyInfo1;
            Console.WriteLine("__________________PLIKI I FOLDERY__________________");
            for (; ; )
            {
                Console.WriteLine("...<F1> Info o pliki | <F2> Info o folderach | <F3> Info o folderach rekurencyjnie | ... | <ESC> Wyjście ");
                Console.WriteLine(new string('*', 50));
                consoleKeyInfo1 = Console.ReadKey();

                switch (consoleKeyInfo1.Key)
                {
                    case ConsoleKey.F1: Pliki.PytajPlik(); break;
                    case ConsoleKey.F2: Foldery.PytajFolder(); break;
                    case ConsoleKey.F3: Foldery.PytajFolderRek(); break;
                    case ConsoleKey.F4:Pliki.PytajPlikKopiuj(); break;
                        //...

                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}
