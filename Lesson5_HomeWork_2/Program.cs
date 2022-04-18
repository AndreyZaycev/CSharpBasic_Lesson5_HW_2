using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Lesson5_HomeWork_2
{
    internal class Program
    {
        //записать начальные данные в файл "startup.txt"
        private static void WriteDataToFile(string fileName)
        {
            File.WriteAllLines(fileName, new string[] { "Начальная строка № 1", "Начальная строка № 2", "Начальная строка № 3" });
        }

        //дозапись текущее время в файл startup.txt
        private static void AppendDataToFile(string fileName)
        {
            string sCurrentTime = DateTime.Now.ToLongTimeString();
            File.AppendAllText(fileName, sCurrentTime);
            Console.WriteLine($"\nТекущее время {sCurrentTime} дописано в файл {fileName}");
        }

        //считать данные файла и вывести на консоль
        private static void ReadAndPrintFileData(string fileName, string sStatus)
        {
            //считать данные
            string[] vData = File.ReadAllLines(fileName);

            //вывод данных на консоль
            Console.WriteLine($"\n -- Данные файла {fileName} {sStatus} -- ");
            foreach (string s in vData) Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            //
            Console.WriteLine("----- Урок № 5, задание № 2 -----");
            Console.WriteLine();

            //имя записываемого файла
            string fileName = "startup.txt";

            //записать начальные данные в файл "startup.txt"
            //вывод данных
            WriteDataToFile(fileName);
            ReadAndPrintFileData(fileName, "до добавления данных");

            //дозапись текущее время в файл startup.txt
            //вывод данных
            AppendDataToFile(fileName);
            ReadAndPrintFileData(fileName, "после добавления данных");

            //
            Console.ReadLine();
        }
    }
}
