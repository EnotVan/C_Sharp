﻿// Задача 3: Напишите программу, которая на вход принимает число и
// выдаёт, является ли число чётным.
// 4 => да
// -3 => нет
// 7 => нет

Console.Write("Введите значение: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}