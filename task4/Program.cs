/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Enter 1st number");
string numberStr1 = Console.ReadLine() ?? "";
Console.WriteLine("Enter 2nd number");
string numberStr2 = Console.ReadLine() ?? "";
Console.WriteLine("Enter 3rd number");
string numberStr3 = Console.ReadLine() ?? "";
int number1 = Convert.ToInt32(numberStr1);
int number2 = Convert.ToInt32(numberStr2);
int number3 = Convert.ToInt32(numberStr3);

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.Write(max);