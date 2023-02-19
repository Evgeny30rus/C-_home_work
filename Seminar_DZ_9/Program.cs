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

int Sum_Recurs(int a, int b)
{
    if (b-a==0)
        return b; 
    return b + Sum_Recurs(a,b-1);
}
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m<0 || n<0) 
    Console.WriteLine("введите натуральное число"); 
Console.WriteLine(Sum_Recurs(m,n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine();

Console.Write("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n");
Console.WriteLine();

int Akk(int a1, int b1)
{


//         if (a1==0) return b1+1;     
//         if (b1==0 || a1>0) return Akk(a1-1,1);
//     else    
// return Akk(a1-1,Akk(a1,b1-1));

if (a1 == 0)
        return b1 + 1;
    else
      if ((a1 != 0) && (b1 == 0))
        return Akk(a1 - 1, 1);
    else
        return Akk(a1 - 1, Akk(a1, b1 - 1));

}
Console.Write("Введите первое число: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (m1<0 || n1<0) 
    Console.WriteLine("введите неотрицательное число"); 
Console.WriteLine(Akk(m1,n1));



