using System;
namespace Program;
internal class Program
{
    static void Main()
    {
        Ex1();
        Ex2();
        Ex3();
        Ex4();
    }

    static void Ex1()
    {
        string word_1 = "hello";
        string word_2 = "world";
        Console.WriteLine(word_1 + " " + word_2);
    }
    
    static void Ex2()
    {
        int num1 = 10;
        int num2 = 5;
        Console.WriteLine($"Сумма чисел равна: {num1 + num2}");
        Console.WriteLine($"Разница чисел равна: {num1 - num2}");
        Console.WriteLine($"Произведение чисел равно: {num1 * num2}");
        Console.WriteLine($"Частное чисел равно: {num1 / num2}");
    }

    static void Ex3()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine();
        Console.Write("Введите отчество: ");
        string middleName = Console.ReadLine();
        Console.WriteLine($"ФИО: {surname} {name} {middleName}");
    }

    static void Ex4()
    {
        int playerHP = 50;
        int playerDm = 20;
        int playerPr = 4;
        int monsterHP = 100;
        int monsterDm = 12;
        int monsterPr = 5;

        Console.WriteLine($"Осталось хп у игрока: {playerHP - monsterDm/playerPr}");
        Console.WriteLine($"Осталось хп у монстра: {monsterHP - playerDm/monsterPr}");
        Console.WriteLine($"Урона нанес игрок: {playerDm / monsterPr}");
        Console.WriteLine($"Урона нанес монстр: {monsterDm / playerPr}");
    }
}