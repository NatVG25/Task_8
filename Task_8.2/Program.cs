using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\ИТМО\С#\TASK\Task_8\NumberSum.txt"; //создаем текстовый файл по указанному пути
            if (!File.Exists(path))
            {
                File.Create(path);
            }
                
            int[] array = new int[10]; //создаем массив рандомных чисел
            Random random = new Random();
            
            using (StreamWriter sw = new StreamWriter(path)) //записываем массив рандомных чивел в текстовый файл
            { 
               for (int i = 0; i < 10; i++)
               {
                    array[i] = random.Next(0, 10);
                    sw.WriteLine("{0} ", array[i]);
               }
             }
            
            string[] lines = File.ReadAllLines(path); //считываем все строки текстового файла в массив и выводим массив на консоль
            
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }


            int Sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                
                Sum += Convert.ToInt32(i); //находим сумму чисел, конвертируя строковые значения в числовые
            }

            Console.WriteLine("Сумма 10 произвольных чисел равна {0}", Sum);//выводим результат сложения
            Console.ReadKey();
         }
    }
}
