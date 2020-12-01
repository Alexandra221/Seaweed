using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result; // искомое число, которое вычисляется как максимум из произведений М26*MAX и М13*М2
                int m13 = 0; // самое большое число, кратное 13, но не кратное 2
                Log('\n' +"m13 = " + m13.ToString() +'\n');
                int m2 = 0; // самое большое число, кратное 2, но не кратное 13
                Log("m2 = " + m2.ToString() + '\n');
                int m26 = 0; // самое большое число, кратное 26
                Log("m26 = " + m26.ToString() + '\n');
                int MAX = 0;// самое большое число среди всех элементов последовательности 
                Log("MAX = " + MAX.ToString() + '\n');
                Console.Write("Введите количество элементов: ");
                int count = Convert.ToInt32(Console.ReadLine());
                Log("Переменная = " + count.ToString() + '\n');
                for (int i = 0; i < count; i++)
                {
                    int dat = int.Parse(Console.ReadLine()); // ввод данных
                    Log("Ввод данных = " + dat.ToString() + '\n');
                    if (dat % 13 == 0 && dat > m13)
                    {// самое большое число, кратное 13
                        m13 = dat;
                        Log("m13 = " + m13.ToString() + '\n');
                    }
                    else
                    {
                        if (dat % 2 == 0 && dat > m2) // самое большое число, кратное 2
                        {
                            m2 = dat;
                            Log("m2 = " + m2.ToString() + '\n');
                        }
                    }
                    if (dat % 26 == 0 && dat > m26) // число, кратное 26
                    {
                        if (m26 > MAX) // нахождение самого большого числа среди всех элементов
                        {
                            MAX = m26;
                            Log("MAX = " + MAX.ToString() + '\n');

                        }
                        m26 = dat;
                        Log("m26 = " + m26.ToString() + '\n');
                    }
                    else
                    {
                        if (dat > MAX) // нахождение самого большого числа среди всех элементов
                        {
                            MAX = dat;
                            Log("MAX = " + MAX.ToString() + '\n');
                        }
                    }
                }
                if (m2 * m13 < m26 * MAX) // нахождение результата
                {
                    result = m26 * MAX;
                    Log("Результат = " + result.ToString() + '\n');
                }
                else
                {
                    result = m2 * m13;
                    Log("Результат = " + result.ToString() + '\n');
                }
                Console.WriteLine("Результат: " + result);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("An error was occured!");
                Console.ReadKey();
                    
            }
        }
        public static void Log(string message)
        {
            try {
                File.AppendAllText("C:\\log.txt", message);
                }
            catch (FileNotFoundException)
            {
                Console.Write("File not found:(");
            }
            }
        
    }
}

