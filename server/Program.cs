﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Лабораторная работа 4");
        Console.WriteLine("ФИО: Пономаренко Артём Юрьевич");
        Console.WriteLine("Группа: ИСП-231");
        Console.WriteLine(DateTime.Now);
        
        bool exit = false;
        
        while (!exit)
        {
            Console.WriteLine("\nМЕНЮ");
            Console.WriteLine("1 - ФИО");
            Console.WriteLine("2 - ГРУППА");
            Console.WriteLine("3 - ДАТА");
            Console.WriteLine("4 - ВЫХОД");
            Console.Write("\nВыберите опцию: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"\nФИО: Пономаренко Артём Юрьевич");
                    break;
                case "2":
                    Console.WriteLine($"\nГруппа: ИСП-231");
                    break;
                case "3":
                    Console.WriteLine($"\nТекущая дата и время: {DateTime.Now}");
                    break;
                case "4":
                    Console.WriteLine("\nВыход из программы...");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("\nНеверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}