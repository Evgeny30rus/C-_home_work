Console.Clear();
Console.WriteLine("Hello, Рустем!");
Console.WriteLine();

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//            возводит число A в натуральную степень B.
//            3, 5 -> 243 (3⁵)
//            2, 4 -> 16
Console.Write("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine();

Console.Write("ВВедите число А");
Console.WriteLine();
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("ВВедите число B");
Console.WriteLine();
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
int i = 2;

while (i<=b)
{
    result = result*a;
    i++;
}

Console.WriteLine();
Console.WriteLine("результат:");
Console.WriteLine(result);
Console.WriteLine();
Console.WriteLine("конец алгоритма 25");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine();
Console.Write("Задача 27: Напишите программу, которая принимает на вход число N и выдаёт сумму цифр в числе.");
Console.WriteLine();  // могут быть и отрицательные числа

Console.Write("ВВедите число N");
Console.WriteLine();

int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (Math.Abs(n) > 0)
{
    int n1 = Math.Abs(n) % 10; // Math.Abs(n) - берет модуль числа N
    n = n / 10; 
    sum = sum + n1; 
    i++;
    Console.WriteLine();
    Console.WriteLine(n1);
}

Console.Write("Результат действия");
Console.WriteLine();
Console.WriteLine(sum);

Console.WriteLine();
Console.WriteLine("конец алгоритма 27");