﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int result = 2;
if(num > 1);
{
    while(result == num)
    {
        Console.Write(result + " ");
        result = result+2;
    }
}

