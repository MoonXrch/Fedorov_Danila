using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cycle
    {
        public void Task1()
        {
            Console.WriteLine("Task 1");
            for (int i = 200; i>0; i++)
            {
                if (i%17 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        public void Task2()
        {
            Console.WriteLine("Task 2");
            double s = 10;
            double sum = s;
            for (int i = 2; i > -1; i++)
            {
                s *= 1.05;
                sum += s;
                if (sum > 100)
                {
                    Console.WriteLine($"На {i} день сумма бега достигла 100 км");
                    break;
                }
            }
            s = 10;
            sum = s;
            for (int i = 2; i>-1; i++)
            {
                s *=1.05;
                sum += s;
                if (s > 20) 
                { 
                    Console.WriteLine($"{i} день - {s} км"); 
                    break; 
                }
            }
            
        }

        public void Task3()
        {
            Console.WriteLine("Task 3");
            Console.Write("Введите число факториала: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int result = f;
            while(f > 1)
            {
                f--;
                result *= f;
            }
            Console.WriteLine($"Результат {result}");
        }

        public void Task4()
        {
            Console.WriteLine("Task 4");
            Console.Write("Введите натуральное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i<=num; i++)
            {
                if (num%i == 0)
                {
                    Console.WriteLine($"Наименьший делитель числа {num} - {i}");
                    break;
                }
            }
        }
    }
}
