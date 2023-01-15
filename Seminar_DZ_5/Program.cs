Console.Clear();
Console.WriteLine("Hello, Рустем!");
Console.WriteLine();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.");
// Console.WriteLine();

// void input_array(int [] array)          // создание и заполнение массива рандомом
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 999); // [100;999]
// }
// int f = 2;
// int release(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % f == 0)
//                 count ++;
//     return count;
// }
// // Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// input_array(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// Console.WriteLine(release(array));

// Console.WriteLine();
// Console.WriteLine("конец алгоритма 34");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine();

Console.Write("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine();

// void input_array1(int [] array1)          // создание и заполнение массива рандомом
// {
//     for (int i = 0; i < array1.Length; i++)
//         array1[i] = new Random().Next(0,999); // [0;999]
// }

// int f1 = 1;
// int s1 = 0;
// void release1(int[] array1)
// {
//     int count1 = 0;
//     for (int i = 0; i < array1.Length; i++)
//         if (array1[i] % f1 > 0)
//             //s1 =  array1[i] + s1; 
//             count1 ++;
//             //Console.WriteLine(count1);
       
// }

// // Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// int[] array1 = new int[n1];
// input_array1(array1);
// Console.WriteLine($"[{string.Join(", ", array1)}]");

// Console.WriteLine(release1(array1));
// Console.WriteLine(s1);
// Console.WriteLine();
// Console.WriteLine("конец алгоритма 36");

Console.Write("ошибка");

// Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine();

Console.Write("Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива");
Console.WriteLine();

void input_array(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100); // [0;100]
}

int result=0;
int max=0; 
int min=0;
void release(int[] array)
{
    int max = array[0], min = array[0];
        for (int i = 0; i < array.Length; i++)
            if (array[i] >= max) 
            max = array[i] ;
        else
            if (array[i] <= min)
            min = array[i];
    Console.WriteLine($"max{max}  min{min}");

    result = max - min;
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
release(array);
Console.WriteLine(result);

Console.WriteLine();
Console.WriteLine("конец алгоритма 38");