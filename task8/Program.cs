/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Enter a number");
string numberStr = Console.ReadLine() ?? "";
int n = Convert.ToInt32(numberStr);

n = Math.Abs(n);
for (int i = 2; i <= n; i = i + 2)
{
    Console.Write(i + ", ");
}

/*
Из условия не очень понятно, что делать, если у нас отрицательное число. 
Т.к. в примерах только положительные числа даны, то я добавила модуль. 
*/
