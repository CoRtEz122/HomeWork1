﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a>b)
// {
// Console.WriteLine(a);
// }
// else
// {
// Console.WriteLine(b);
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = (0);


// if(a>b)
// {
//     max = a;
// }
// if(b>a)
// {
//     max = b;
// }
// if(c>max)
// {
//     max = c;
// }
// Console.WriteLine(max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a % 2 == 0)
// {
//     Console.WriteLine("Чётное");
// }

// else
// {
//     Console.WriteLine("Не чётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0;

while(i<=a)
{
    
    Console.WriteLine(i);
    i=i+2;
}

