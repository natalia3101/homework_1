﻿/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Enter a number");
string numberStr = Console.ReadLine() ?? "";
int n = Convert.ToInt32(numberStr);

if (n % 2 == 0)
{
    Console.WriteLine("Yes");
} else
{
    Console.WriteLine("No");
}