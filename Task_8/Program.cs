using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\ИТМО\С#"; //указываем абсолютный путь к нужной папке
            string s = "*.*"; 
            DirectoryInfo directory = new DirectoryInfo(path); //создаем экземпляр класса конструктором - аргумент путь к каталогу
            DirectoryInfo[] directories = directory.GetDirectories(s, SearchOption.AllDirectories); //создаем список папок в главном каталоге (в аргументах указываем путь и что ищем в текущей папке и во вложенных)
            Console.WriteLine(@"{0}\", path); //выводим путь основной папки
            FileInfo[] files = directory.GetFiles(); //создаем список файлов в папках первого уровня
            foreach (FileInfo file in files) //перебираем файлы первого уровня
            {
                Console.WriteLine("-{0}", file.Name); //выводим названия файлов первого уровня
            }
            Console.WriteLine();

            foreach (DirectoryInfo direct in directories) //перебираем вложенные каталоги 
            {
                Console.WriteLine(@"{0}\", direct.FullName); //выводим пути вложенных каталогов
                string name = direct.FullName;
                DirectoryInfo nameSub = new DirectoryInfo(name);

                foreach (FileInfo file in nameSub.GetFiles()) //перебираем файлы во вложенных каталогах
                {
                    Console.WriteLine("-{0}", file.Name); //выводим названия файлов
                }
                Console.WriteLine();
            }
                Console.ReadKey();
            
        } 
    }
}
