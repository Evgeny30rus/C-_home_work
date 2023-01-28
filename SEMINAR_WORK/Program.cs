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

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
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

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double test(double[] array)
// {
// double min = array[0];
// double max = array[0];

// foreach (double i in array){
// if (min > i)
// min = i;
// if (i > max)
// max = i;
// }
// return max - min;
// }


// Как внести в массив строку цифр введенную пользователем спародически?

// Console.Write("Введите элементы, разделяя их точкой(.): ");

// int [] size = Console.ReadLine().Split(".").Select(x=>int.Parse(x)).ToArray();  

// Console.Write("Итоговый массив");
// Console.WriteLine();

// foreach (int i in size)    //Для одномерных массивов оператор foreach обрабатывает элементы в порядке возрастания индекса, начиная с индекса 0 и заканчивая индексом Length - 1
// Console.WriteLine(i);

// SPLIT - функция разделяющая 5 6 7 8 на разные блоки и вносим в массив. разделитель чисел или блоков символы в кавычках, т.е. (.) - итог  ["5", "6", "7", "8"]
// SELECT - функция берет элемент х и преобразует в целое число (изменяет тип данных) 
// ToArray - функция преобразования в массив
// int.Parse - преобразует какой то тип данных в число


// **Задача 39:** Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// 
// void InputArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(1, 11); // [1, 10]
// }

// void release(int[] array)
// {
//    for (int i = 0; i < array.Length / 2; i++)
//     {
//      int temp = array[i];
//      array[i] = array[array.Length - 1 - i];
//      array[array.Length - 1 - i] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// release(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//          array[i] = new Random().Next(1, 11); // [1, 10]
// }

// string Triangle(int[] array)
// {
//     if(array[0] < array[1] + array[2] &&
//        array[1] < array[0] + array[2] &&
//        array[2] < array[0] + array[1])
//     return "yes";
// return "no";
// }
// Console.Clear();
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.WriteLine(Triangle(array));

// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());     //ввод числа для анализа (десятичное число преобразуется в двоичное путем получения остатка от деления на два)
// string res = "";                      // создание пустой строки
// while(n > 0)
// {
// res = Convert.ToString(n % 2) + res; // остаток от деления на 2 и цифра 13 = 1011 (перевернуто); + res - дает изменения порядка отображения, т.е. переворачивает результат 1011 => 1101 = 13 
// n /= 2;
// }
// Console.WriteLine(res);


// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// ❗ **Числа Фибоначчи** — числовая ****последовательность, каждый элемент которой равен сумме двух предыдущих.

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int a0 = 0, a1 = 1, x;        // создаем переменные 0 и 1 (начало ряда из условия) + рабочую переменную х

// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{a0} ");  // $"{a0} " - вывод а0 с пробелом на каждом шаге цикла
//     x = a0 + a1;              // 3 переменная из начала
//     a0 = a1;                  // сдвиг - перетаскиваем значения на следующимй шаг
//     a1 = x;                   // аналогично, освобождая х, чтобы цикл двигался дальше
// }


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// Console.Clear();
// int[] a = {1, 2, 3};                          // создаем массив а
// int[] b = new int[a.Length];                  // создаем новый массив b
// for (int i = 0; i < a.Length; i++)            // цикл заполнения массива  b цифрами из массива а
// b[i] = a[i];
// b[0] = 5;                                     // замена первого значения в массиве b0 цифрой 5   
// Console.WriteLine(string.Join(" ", a));       // вывод значений с пробелами в строку 
// Console.WriteLine(string.Join(" ", b));





