Console.Clear();
Console.WriteLine("Hello, Рустем!");
Console.WriteLine();

// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("вввести 2 числа и определить, какое число из них большее, а какое меньшее");
Console.WriteLine();

Console.Write("Введите первое число: a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: b ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
    Console.WriteLine($"a меньше b, b {b} - max");
else
    Console.WriteLine($"a больше b, а {a} - max");


// Задача 4: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

Console.Write("вввести 3 числа и вывести мах число из них");
Console.WriteLine();

Console.Write("Введите первое число: a1 ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: с1 ");
int c1 = Convert.ToInt32(Console.ReadLine());

int max;

if (a1 < b1 && b1 > c1)
   max = b1;
else 
    if (a1 < c1 && c1 > b1)
    max = c1;
    else max = a1;

Console.WriteLine($"Max число = {max}");


// Задача 6: Напишите программу, которая на вход принимает число и 
//выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("вввести число и проверить его чётность");
Console.WriteLine();

Console.Write("Введите число для проверки: a2 =");
int a2 = Convert.ToInt32(Console.ReadLine());
int b2 = 2;


if (a2 % b2 == 0)
    Console.WriteLine("a2 Кратное");
else
    Console.WriteLine($"а2 некратное т.к. не делиться без остатка на {b2}");