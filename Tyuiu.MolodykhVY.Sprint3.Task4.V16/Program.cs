using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Sprint3.Task4.V16.Lib;

namespace Tyuiu.MolodykhVY.Sprint3.Task4.V16
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Молодых В. Ю. | ИИПб-23-3";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Молодых Владислав Юрьевич | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=((cos(x)+x)/x)+0.25. При х = 0 прервать цикл.                 *");
            Console.WriteLine("* Полученные значения и перемножать.                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
