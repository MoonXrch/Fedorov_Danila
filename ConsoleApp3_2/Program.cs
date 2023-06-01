using ConsoleApp3;
using System;
using System.Data;
using System.Globalization;

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
            new(fio:"Маркин Сергей Владимирович", salary:27000, department:1)
        };

        List<string> commands = new List<string>()
        {
            new("Вывести список сотрудников"),
            new("Расчитать сумму затрат на зарплаты в месяц"),
            new("Вывести минимальную зарплату сотрудников"),
            new("Вывести максимальную зарплату сотрудников"),
            new("Средняя зарплата сотрудников"),
            new("Вывести ФИО сотрудников"),
            new("Индексация зарплаты"),
            new("Вывести сотрудника с максимальной зп"),
            new("Вывести сотрудника с минимальной зп"),
            new("Средняя зарпата по отделу"),
            new("Индексация зарплаты сотрудников отдела"),
            new("Вывести сотрудников отдела"),
            new("Вывести сотрудников по зарплате")
        };


        CommandsList();
        Commands();

        void CommandsList()
        {
            foreach (var command in commands)
            {
                Console.Write(employee.Id() + ". ");
                Console.WriteLine(command);
            }
            employee.IdReset();
        }
        

        void Commands()
        {
            Console.Write("Введите номер команды: ");
            string commandNumber = Console.ReadLine();

            switch (commandNumber)
            {
                case "exit":
                    Exit();
                    break;
                case "commands":
                    CommandsList();
                    break;
                case "1":
                    EmployeePrint();
                    break;
                case "2":
                    Console.WriteLine($"Сумма затрат на зарплаты в месяц = {SalarySum()} руб.");
                    break;
                case "3":
                    Console.WriteLine($"Минимальная зарплата сотрудника = {MinSalary()} руб.");
                    break;
                case "4":
                    Console.WriteLine($"Максимальная зарплата сотрудника = {MaxSalary()} руб.");
                    break;
                case "5":
                    AverageSalary();
                    break;
                case "6":
                    WorkersFIO();
                    break;
                case "7":
                    IndexSalary();
                    break;
                case "8":
                    MaxSalaryWorker();
                    break;
                case "9":
                    MinSalaryWorker();
                    break;
                case "10":
                    AverageDepartmentSalary();
                    break;
                case "11":
                    IndexDepartmentSalary();
                    break;
                case "12":
                    DepartmentWorkers();
                    break;
                case "13":
                    SalaryArgument();
                    break;
            }
            Commands();
        }

        void Exit()
        {
            Environment.Exit(0);
        }

        void EmployeePrint()
        {
            foreach (var emp in employees)
            {
                Console.Write(employee.Id() + ". ");
                Console.WriteLine($"{emp.Fio} \t  {emp.Salary} \t {emp.Department}");
            }
            employee.IdReset();
        }

        double SalarySum()
        {
            double sum = 0;
            foreach (var emp in employees)
            {
                sum += emp.Salary;
            }
            return sum;
        }

        double MinSalary()
        {
            double min = 100000;
            foreach (var emp in employees)
            {
                if (emp.Salary < min)
                {
                    min = emp.Salary;
                }
            }
            return min;
        }

        double MaxSalary()
        {
            double max = 0;
            foreach (var emp in employees)
            {
                if (emp.Salary > max)
                {
                    max = emp.Salary;
                }
            }
            return max;
        }

        void AverageSalary()
        {
            Console.WriteLine(SalarySum() / employees.Count);
        }

        void WorkersFIO()
        {
            foreach (var emp in employees)
            {
                Console.Write(employee.Id() + ". ");
                Console.WriteLine(emp.Fio);
            }
            employee.IdReset();
        }

        void IndexSalary()
        {
            Console.Write("Введите процент изменения зп: ");
            double cf = Convert.ToDouble(Console.ReadLine()) * 0.01;
            foreach (var emp in employees)
            {
                emp.Salary *= cf;
                Console.WriteLine(emp.Salary);
            }
        }

        int DepartmentIndex()
        {
            Console.Write("Введите номер отдела: ");
            int departmentIndex = Convert.ToInt16(Console.ReadLine());
            return departmentIndex;
        }

        void MaxSalaryWorker()
        {
            foreach (var emp in employees)
            {
                employee.Id();
                if (emp.Salary == MaxSalary())
                {
                    Console.Write(employee.Id() + ". ");
                    Console.WriteLine($"{emp.Fio}  {emp.Salary} {emp.Department}");
                }
            }
            employee.IdReset();
        }

        void MinSalaryWorker()
        {
            foreach (var emp in employees)
            {
                employee.Id();
                if (emp.Salary == MinSalary())
                {
                    Console.Write(employee.Id() + ". ");
                    Console.WriteLine($"{emp.Fio}  {emp.Salary} {emp.Department}");
                }
            }
            employee.IdReset();
        }

        void AverageDepartmentSalary()
        {
            double sumDepartmentSalary = 0;
            int departmentWorkers = 0;
            int departmentIndex = DepartmentIndex();
            foreach (var emp in employees)
            {
                if (emp.Department == departmentIndex)
                {
                    sumDepartmentSalary += emp.Salary;
                    departmentWorkers++;
                }
            }
            Console.WriteLine($"Средняя зарплата по {departmentIndex} отделу = {sumDepartmentSalary / departmentWorkers}");
        }

        void IndexDepartmentSalary()
        {
            int departmentIndex = DepartmentIndex();
            Console.Write("Введите процент изменения зп: ");
            double cf = Convert.ToDouble(Console.ReadLine()) * 0.01;
            foreach (var emp in employees)
            {
                employee.Id();
                if (emp.Department == departmentIndex)
                {
                    Console.Write(employee.Id() + ". ");
                    emp.Salary *= cf;
                    Console.WriteLine($"{emp.Fio} \t {emp.Salary}");
                }
            }
            employee.IdReset();
        }

        void DepartmentWorkers()
        {
            int departmentIndex = DepartmentIndex();
            foreach (var emp in employees)
            {
                employee.Id();
                if (emp.Department == departmentIndex)
                {
                    Console.Write(employee.Id() + ". ");
                    Console.WriteLine($"{emp.Fio} \t  {emp.Salary}");
                }
            }
            employee.IdReset();
        }

        void SalaryArgument()
        {
            Console.Write("Введите зарплату: ");
            int salaryArgument = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Вывести сотрудников с зарплатой меньше");
            Console.WriteLine("2. Вывести сотрудников с зарплатой больше");
            Console.Write("Выберите номер действия: ");
            byte motion = Convert.ToByte(Console.ReadLine());
            switch (motion)
            {
                case 1:
                    foreach (var emp in employees)
                    {
                        employee.Id();
                        if (emp.Salary < salaryArgument)
                        {
                            Console.Write(employee.Id() + ". ");
                            Console.WriteLine($"{emp.Fio} \t {emp.Salary} \t {emp.Department}");
                        }
                    }
                    employee.IdReset();
                    break;
                case 2:
                    foreach (var emp in employees)
                    {
                        employee.Id();
                        if (emp.Salary >= salaryArgument)
                        {
                            Console.Write(employee.Id() + ". ");
                            Console.WriteLine($"{emp.Fio} \t {emp.Salary} \t {emp.Department}");
                        }
                    }
                    employee.IdReset();
                    break;
            }

        }
    }
}