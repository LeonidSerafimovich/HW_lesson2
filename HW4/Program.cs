﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

 Console.WriteLine("Введите первое число");
        int n = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите второе число");
        int m = int.Parse(Console.ReadLine());

        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }