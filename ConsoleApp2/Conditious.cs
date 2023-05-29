using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Conditious
    {
        public void Task1()
        {
            Console.WriteLine($"Task 1");
            Console.Write($"Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) Console.WriteLine(num + 5);
            else Console.WriteLine(num - 5);
        }

        public void Task2()
        {
            Console.WriteLine($"Task 2");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c) Console.WriteLine(a);
            else if (b > c && b > a) Console.WriteLine(b);
            else if (c > a && b > a) Console.WriteLine(c);
        }

        public void Task3()
        {
            Console.WriteLine($"Task 3");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a > 0)
            {
                sum += a;
                if (b > 0)
                {
                    sum += b;
                    if (c > 0)
                    {
                        sum += c;
                        Console.WriteLine(sum);
                    }
                    else Console.WriteLine(sum);
                }
                else if (c > 0)
                {
                    sum += c;
                    Console.WriteLine(sum);
                }
                else Console.WriteLine(sum);
            }
            else if (b > 0)
            {
                    sum += b;
                    if (c > 0)
                    {
                        sum += c;
                        Console.WriteLine(sum);
                    }
                    else Console.WriteLine(sum); 
            }
            else if (c > 0)
            {
                sum += c;
                Console.WriteLine(sum);
            }
            else Console.WriteLine(sum);
            
        }
        
        public void Task4()
        {
            Console.WriteLine($"Task 4");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 10) Console.WriteLine(2*num);
            else Console.WriteLine(num);
        }

        public void Task5()
        {
            Console.WriteLine($"Task 5");
            Console.Write("Введите число от 1 до 7: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("День недели - ");
            switch (num)
            {
                case 1: Console.WriteLine("Понедельник");
                    break;
                case 2: Console.WriteLine("Вторник");
                    break;
                case 3: Console.WriteLine("Среда");
                    break;
                case 4: Console.WriteLine("Четверг");
                    break;
                case 5: Console.WriteLine("Пятница");
                    break;
                case 6: Console.WriteLine("Суббота");
                    break;
                case 7: Console.WriteLine("Воскресенье");
                    break;
            }
        }
    }
}
