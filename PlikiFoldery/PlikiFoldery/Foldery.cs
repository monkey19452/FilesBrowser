using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlikiFoldery
{
    public class Foldery
    {
        public static void PytajFolder()
        {
            string folderpath = "";
            Console.WriteLine("Podaj ścieżkę folderu:   ");
            folderpath = Console.ReadLine();

            if (folderpath == "")
            {
                folderpath = ".";
            }

            ReadAttributes(folderpath);
        }

        public static void PytajFolderRek()
        {
            string folderpath = "";
            Console.WriteLine("Podaj ścieżkę folderu:   ");
            folderpath = Console.ReadLine();

            if (folderpath == "")
            {
                folderpath = ".";
            }

            FolderRekurencja(folderpath,0);
        }



        public static void ReadAttributes(string folderpath)
        {
            FileAttributes fileAttributes1 = File.GetAttributes(folderpath);

            if (fileAttributes1.HasFlag(FileAttributes.Directory))
            {
                string[] itemsArray = Directory.GetFileSystemEntries(folderpath, "*", SearchOption.AllDirectories);
                for (int i = 0; i < itemsArray.Length; i++) Console.WriteLine(itemsArray[i]);

            }
        }

        public static void FolderRekurencja(string folderpath, int level)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderpath);

            if (!directoryInfo.Exists)
            {
                Console.WriteLine("Nie ma takiego folderu");
                return;
            }

            DirectoryInfo[] ddirectoriesInfo = directoryInfo.GetDirectories();
            FileInfo[] filesInfo = directoryInfo.GetFiles();

           

            foreach (FileInfo fil1 in filesInfo)
            {
                Console.WriteLine(new String('|', level) + fil1.FullName);
            }
            foreach (DirectoryInfo dire1 in ddirectoriesInfo)
            {
                Console.WriteLine(new String('|', level) + dire1.FullName);
                FolderRekurencja(dire1.FullName, level + 1);
            }
        }




    }      
}
