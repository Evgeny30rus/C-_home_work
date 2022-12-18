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


