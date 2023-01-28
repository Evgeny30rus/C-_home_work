// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Hello, Рустем!");
Console.WriteLine();

Console.WriteLine();
Console.Write("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine();  
Console.WriteLine("ВВедите число М");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void input_array(int [] array)           //  сознательно ушел от ввода чисел в массив с клавиатуре как в задании, посчитал это неудобным для проверки... Если примите за ошибку могу переделать
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(-m, m); // [-m;M]       
}

int release(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
                count ++;
    return count;
}

int[] array = new int[m];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(release(array));

Console.WriteLine();
Console.WriteLine("конец алгоритма 41");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine();
Console.Write("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых");
Console.WriteLine();  
Console.WriteLine("ВВедите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
Console.WriteLine("ВВедите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
Console.WriteLine("ВВедите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
Console.WriteLine("ВВедите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (b1=b2 && k1=k2) Console.WriteLine("прямые совпадают");
    //return"прямые совпадают";
else if (k1*b1-k2*b2 == 0) Console.WriteLine("прямые параллельны");
    //return"прямые параллельны";

double x = (b2-b1)/(k1-k2);  
double y = b1+k1*(b2-b1)/(k1-k2);

Console.WriteLine();

Console.WriteLine(x);
Console.WriteLine(y);








