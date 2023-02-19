// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Рустем!");


//      ЧЕРЕЗ РЕКУРСИЮ
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//            в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine();

Console.Write("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine();


// int rec(int m, int n)
// {
//     if (n == m)
//         return 0;
//     return rec(m,n - 1) + n + m;
// }

double Sum_Recurs(double m, double n)
{
    // if (n==0) return 0;
    // if (m==0) return 0;
    if (n==m) return 0;
        return n + Sum_Recurs(m,n-1);
}


//Console.Clear();
Console.Write("Введите первое число: ");
double m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
double n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(rec(m, n));
Console.WriteLine(Sum_Recurs(m,n)); // 55












// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


