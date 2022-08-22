using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlikiFoldery
{
    public class Pliki
    {
        public static void PytajPlik()
        {
            string filepath="";
            Console.WriteLine("Podaj nazwe pliku:   ");
            filepath = Console.ReadLine();
            
            if (filepath == "")
                { 
                    filepath = "."; 
                }

            Console.WriteLine(InfoPlik(filepath));
        }
        public static string InfoPlik(string filename)
        {
        
        FileInfo fileInfo = new FileInfo(filename);
            string fileMetrics="";
            if (fileInfo.Exists)
            {
                 fileMetrics = "------- File metrics " + filename + "-------"
                                + "\nExtension: " + fileInfo.Extension
                                + "\nSize:  " + fileInfo.Length.ToString()
                                + "\nAtributes:  " + fileInfo.Attributes.ToString()
                                + "\nDate create:" + fileInfo.CreationTime.ToString();

               
            }
            
            else
            {
                Console.WriteLine("Nie ma takiego pliku");
            }
            return fileMetrics;

        }


        public static void PytajPlikKopiuj()
        {
            string filepath = "";
            
            Console.WriteLine("Podaj nazwe pliku:   ");
            filepath = Console.ReadLine();

            if (filepath == "")
            {
                filepath = ".";
            }

            CopyFile(filepath);
        }


        public static void CopyFile(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            string pathSource = fileInfo.FullName;
            string destiny = "";
            if (destiny == "")
            {
                for (; ; )
                {
                    Console.Write("Wprowadz sciezke do ktorej plik ma zostac skopiowany ");
                    destiny = Console.ReadLine() + '\\';
                    if (destiny.Trim(' ') == "") destiny = ".";
                    if (Directory.Exists(destiny)) break;
                    else Console.WriteLine("sciezka nie istnieje");
                }
            }
            if (fileInfo.Extension != ".txt") File.Copy(pathSource, destiny, true); //make a copy file

            //if .txt file 
            StreamReader srFrom = new StreamReader(filename);
            StreamWriter swTo = new StreamWriter(destiny);
            while (srFrom.Peek() != -1)
            {
                string sBuffer = srFrom.ReadLine();
                swTo.WriteLine(sBuffer.ToUpper()); //ToUpper()=capital letters
            }
            srFrom.Close();
            swTo.Close();

        }




    }
}
