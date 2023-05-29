using ConsoleApp2;
using System;
namespace Program;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Задания с условием");
        Console.WriteLine();
        Conditious conditious = new Conditious();
        conditious.Task1();
        conditious.Task2();
        conditious.Task3();
        conditious.Task4();
        conditious.Task5();

        Console.WriteLine();
        Console.WriteLine("Задания с циклом");
        Console.WriteLine();
        Cycle cycle = new Cycle();
        cycle.Task1();
        cycle.Task2();
        cycle.Task3();
        cycle.Task4();
    }

    
}