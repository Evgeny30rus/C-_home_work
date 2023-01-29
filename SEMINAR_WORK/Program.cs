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

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
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


// 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// bool Find(int[,] matrix, int el){
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i,j] == el)
//                 return true;
//         }
//     }
//     return false;
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);

// Console.WriteLine("Введите элемент:");
// int el = Convert.ToInt32(Console.ReadLine());
// bool find = Find(matrix, el);
// Console.WriteLine(find);

// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// double[] Release(int[,] matrix){
//     double[] res = new double[matrix.GetLength(1)];
//     for (int j = 0; j < matrix.GetLength(0); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             sum += matrix[i,j];
//         }
//         res[j] = Math.Round(sum/matrix.GetLength(0), 2);
//     }
//     return res;
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный массив:");
// InputMatrix(matrix);
// PrintMatrix(matrix);

// double[] res = Release(matrix);
// Console.WriteLine();
// Console.WriteLine(String.Join(' ', res));

//Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

// верха нет взять из семинара
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLongLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLongLength(1); j++)
//             Console.WriteLine($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }


// int[,] Release(int[,] matrix){
//     for (int j = 0; j < matrix.GetLength(0); j++)
//     {
//         int temp = matrix[0, j]; 
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;
//     }
//     return matrix;
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный матрица:");
// InputMatrix(matrix);
// PrintMatrix(matrix);

// Console.WriteLine("Конечная матрица:");
// PrintMatrix(Release(matrix));

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// вверх????

// Release(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temp = matrix[i,j];
//             matrix[i,j] = matrix[j,i];
//             matrix[j,i] = temp;
//         }
//     }
//     return matrix;
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// while (size[0] != size[1])
// {
//     Console.Write("Ошибка!! Введите размер матрицы: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный матрица:");
// InputMatrix(matrix);
// PrintMatrix(matrix);

// Console.WriteLine("Конечная матрица:");
// PrintMatrix(Release(matrix));

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


// bool check(int[] array, int n)
// {
//     for (int i = 0;i < array.Length; i++)
//     {
//         if (array[i] == n)
//             return false;
//     }
//     return true;
// }

// int InputMatrix(int[,] matrix, int[] array)
// {
//     int k = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 11); // [-10, 10]
//             Console.Write($"{matrix[i, j]} \t");
//             if (check(array, matrix[i,j])){
//                 array[k] = matrix[i,j];
//                 k++;
//             }
//         }
//         Console.WriteLine();
//     }
//     return k;
// }
// void Release(int[,] matrix, int [] array, int array_len)
// {
//     for (int k = 0; k < array_len; k++)
//     {
//         int count = 0; 
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (array[k] == matrix[i,j])
//                     count++;
//             }
//         }
//         Console.WriteLine($"Элемент {array[k]} - {count} раз");
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[] array = new int[size[0] * size[1]];
// // size[0] - row
// // size[1] - column
// int[,] matrix = new int[size[0], size[1]];
// Console.WriteLine("Начальный матрица:");
// int k = InputMatrix(matrix, array);
// Release(matrix, array, k);

// // Console.WriteLine("Конечная матрица:");
// // PrintMatrix(Release(matrix));

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
//  которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void Release(int[,] matrix)
// {
//     int min_v = matrix[0, 0], min_row = 0, min_col = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if( min_v > matrix[i,j])
//             {
//                 min_v = matrix[i,j];
//                 min_row = i;
//                 min_col = j;
//             }
//         }
//     }
//     Console.WriteLine($"{min_v}  ({min_row};{min_col})");

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i != min_row) {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if (j != min_col)
//                     Console.Write($"{matrix[i, j]} \t");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// Console.WriteLine("Начальный массив");
// InputMatrix(matrix);
// Console.WriteLine("Конечный массив");
// Release(matrix);

//  РЕКУРСИЯ

// Написать программу, которая складывает два числа

// int sum(int a, int b)
// {
//     if (b == 0)
//         return a;
//     return sum(a + 1, b - 1);
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(sum(n, m));

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// string rec(int n)
// {
//      if (n == 1)
//         return "1";
//     return rec(n - 1) + $" {n}";
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(rec(n));

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// string rec(int m, int n)
// {
//      if (n == m)
//         return $"{n}";
//     return rec(m,n - 1) + $" {n}";
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(rec(n, m));

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// int rec(int n)
// {
//     if (n < 10)
//         return n;
//     return rec(n / 10) + n % 10;
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(rec(n));

// // Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень 
//                            B с помощью рекурсии.
// // A = 3; B = 5 -> 243 (3⁵)
// // A = 2; B = 3 -> 8
// // 69
// int rec(int a, int b)
// {
//     if (b == 0)
//         return 1;
//     return rec(a, b - 1) * a;
// }

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(a, b));



























