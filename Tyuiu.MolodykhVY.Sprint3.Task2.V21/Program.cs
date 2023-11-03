using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MolodykhVY.Sprint3.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Молодых В. Ю. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                            *");
            Console.WriteLine("* Тема:  алгоритмы циклической структуры                                               *");
            Console.WriteLine("* Задание #2                                                                           *");
            Console.WriteLine("* Вариант #21                                                                          *");
            Console.WriteLine("* Выполнил: Молодых Владислав Юрьевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу используя цикл do while, которая вычисляет сумму ряда по формуле, *");
            Console.WriteLine("* при x = 1,5                                                                          *");
            Console.WriteLine("*     10                                                                               *");
            Console.WriteLine("* S = ∑(1/(sin(k)+2*x^k))^k                                                            *");
            Console.WriteLine("*     k=1                                                                              *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            Console.WriteLine("x = 1,5");



            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine(ds.GetSumSeries(1.5));

            Console.ReadLine();
        }
    }
}
