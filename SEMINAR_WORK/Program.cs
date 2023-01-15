// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


// void input_array(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9;9]
// }


// void release(int[] array)
// {
//     int sumP = 0, sumN = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0) 
//             sumP += array[i];
//         else
//             sumN += array[i];
//     Console.WriteLine($"+{sumP}  {sumN}");
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// input_array(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// release(array);

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void input_array(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9;9]
// }


// void release(int[] array)
// {
//     int sumP = 0, sumN = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0) 
//             array[i] =array[i]*-1;
//         else
//             array[i]= array[i]*-1;
//     Console.WriteLine($"[{string.Join(", ", array)}]");
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// input_array(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// release(array);

// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// void input_array(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 2); // [0;2]
// }


// string release(int[] array, int k)
// {
    
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] == k)
//             return "+";
//     return "-";
    
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int k = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// input_array(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// Console.WriteLine(release(array, k));

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void input_array(int [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101); // [-100;100]
// }

// int release(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] >= 10 && array[i] <= 99)
//             count ++;
//     return count;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// input_array(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");

// Console.WriteLine(release(array));


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//  Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 9
// [6 7 3 6] -> 36 21

// void input_array(int [] array)          // создание и заполнение массива рандомом
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-100;100]
// }


// void release(int[] array)
// {
//     for (int i = 0; i <= array.Length/2; i++)                            // идем до середины включительно
//         Console.Write($"{array[i] * array[array.Length - 1 - i]} ");     // первый и последний * друг на друга
        
//     //[1, 2 , 3, 4 , 5]
    
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// input_array(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// release(array);



