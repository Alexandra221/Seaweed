using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result; // искомое число, которое вычисляется как максимум из произведений М26*MAX и М13*М2
            int m13 = 0; // самое большое число, кратное 13, но не кратное 2
            int m2 = 0; // самое большое число, кратное 2, но не кратное 13
            int m26 = 0; // самое большое число, кратное 26
            int MAX = 0;// самое большое число среди всех элементов последовательности 
            Console.Write("Введите количество элементов: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int dat = int.Parse(Console.ReadLine()); // ввод данных
                if (dat % 13 == 0 && dat > m13) // самое большое число, кратное 13
                    m13 = dat;
                else 
                {
                    if (dat % 2 == 0 && dat > m2) // самое большое число, кратное 2
                    {
                        m2 = dat;
                    }
                }
                if (dat % 26 == 0 && dat > m26) // число, кратное 26
                {
                    if (m26 > MAX) // нахождение самого большого числа среди всех элементов
                    {
                        MAX = m26;

                    }
                    m26 = dat;
                }
                else 
                {
                    if (dat > MAX) // нахождение самого большого числа среди всех элементов
                    {
                        MAX = dat;
                    }
                }
            }
            if (m2 * m13 < m26 * MAX) // нахождение результата
            {
                result = m26 * MAX;
            }
            else
            {
                result = m2 * m13;
            }
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}

