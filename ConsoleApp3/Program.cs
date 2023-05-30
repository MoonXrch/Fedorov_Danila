using ConsoleApp3;
using System;
namespace Program;
internal class Program
{
    static void Main()
    {
        Employee employee = new Employee();
        List<Employee> employees = new List<Employee>()
        {
            new(fio:"Пастухов Иван Сергеевич", salary:23000, department:1),
            new(fio:"Алексеева Алина Иванова", salary:29300, department:1),
            new(fio:"Коробков Михаил Геннадьевич", salary:20300, department:4),
            new(fio:"Аршинов Артемий Романович", salary:22000, department:4),
            new(fio:"Варламов Вячеслав Сергеевич", salary:23200, department:3),
            new(fio:"Зайцев Сергей Андреевич", salary:15000, department:2),
            new(fio:"Новиков Владислав Дмитриевич", salary:22200, department:2),
            new(fio:"Макушкина Анастасия Алексеевна", salary:21200, department:3),
            new(fio:"Федорова Дарья Дмитриевна", salary:19000, department:3),
            new(fio:"Нурмагамедов Джабраиль Таджирович", salary:27000, department:1)
        };

        TaskA();
        Console.WriteLine($"Сумма затрат на зарплаты в месяц = {TaskB()} руб."); 
        TaskC();
        TaskD();
        TaskE();
        TaskF();


        void TaskA()
        {   
            //int i = 1;
            foreach (var emp in employees)
                {
                /*Console.Write(employees.Count + i + - employees.Count + ". ");
                i++;*/
                Console.Write(employee.Id() + ". "); 
                Console.WriteLine(emp.Fio, emp.Salary, emp.Department);
                }
        }

        double TaskB()
        {
            double sum = 0;
            foreach(var emp in employees)
            {
                sum += emp.Salary;
            }
            return sum;
        }
        
        void TaskC()
        {
            double min = 100000;
            foreach (var emp in employees)
            {
                if (emp.Salary < min)
                {
                    min = emp.Salary;
                }
            }
            Console.WriteLine(min);
        }

        void TaskD()
        {
            double max = 0;
            foreach (var emp in employees)
            {
                if (emp.Salary > max)
                {
                    max = emp.Salary;
                }
            }
            Console.WriteLine(max);
        }

        void TaskE()
        {
            Console.WriteLine(TaskB()/employees.Count);
        }

        void TaskF()
        {
            int i = 1;
            foreach (var emp in employees)
            {
                Console.Write(employees.Count + i + - employees.Count + ". ");
                i++;
                Console.WriteLine(emp.Fio);
            }
        }
    }
}