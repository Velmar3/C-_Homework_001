﻿/*

Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/
/*
int n, n1;

Console.Write("Введите число №1: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
n1 = Convert.ToInt32(Console.ReadLine());

if (n >= n1)
{
    Console.Write("max: " + n);
}
else 
{
    Console.Write("max: " + n1);
}

/*

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/
/*
int n, n1, n2;

Console.Write("Введите число №1: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №3: ");
n2 = Convert.ToInt32(Console.ReadLine());

if (n > n1 & n > n2)
{
    Console.Write("Максимальное число: " + n);
}
else if (n1 > n & n1 > n2)
{
    Console.Write("Максимальное число: " + n1);
}
else if (n2 > n & n2 > n1) 
{
    Console.Write("Максимальное число: " + n2);
}
*/
/*

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/

/*
int n;
Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
    Console.Write("Ответ: Да");
}
else
{
    Console.Write("Ответ: Нет");
}
*/

/*

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/
/*
int a = 1;
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (a == 1)
    {
    a++;
    } 

while (a <= N)
{
    if (a % 2 == 0)
    {
    Console.Write(a + " ");
    a += 2;;
    }
}
*/