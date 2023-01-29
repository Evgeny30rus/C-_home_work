// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Рустем!");

// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine();

Console.Write("Задача 47. Задайте двумерный массив размером m и n,заполненный случайными вещественными числами.");
Console.WriteLine(); 


void PrintArray (int[,] matr)  //метод для распечатки матрицы чисел matrix
{
    for (int i = 0; i < matr.GetLength(0); i++)  // по строкам  дает тоже самое что указано строка 42  
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // по столбцам    
        {
        Console.Write($"|{matr[i, j]}| ");
        }
    Console.WriteLine(); // чтобы получить прямоугольник
    }
}

void FillArray (int[,] matr)  //метод для заполнения матрицы matrix числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  // по строкам  дает тоже самое что указано выще в размерности  
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // по столбцам    
        {
             matr[i, j] = new Random().Next(1,10); // заполлнение матрицы рандомно от 1 до 10 
        }
    Console.WriteLine(); // чтобы получить прямоугольник
    }
}

int[,] matrix = new int [4,4];
Console.Write("Пустой массив"); Console.WriteLine();
PrintArray(matrix); 

FillArray(matrix);
Console.Write("Итоговый массив"); Console.WriteLine();
PrintArray(matrix); 

Console.WriteLine();
Console.WriteLine("конец алгоритма 47");

// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет.
Console.WriteLine();

Console.Write("Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine(); 

string Find(int[,] matr, int el)                         // проверка нахождения цифры внутри матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] == el)
                return "Элемент найден";
        }
    }
    return "Элемент не найден";
}

Console.Write("Введите размер матрицы Строка*Столбец через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] matrix1 = new int[size[0], size[1]]; // size 0; size 1 = size 0 для простоты можо сделать (квадратная матрица)
Console.WriteLine("Начальный массив:");
PrintArray(matrix1);
    FillArray(matrix1);
Console.WriteLine("Заполненный массив:"); //Console.WriteLine();
PrintArray(matrix1);

Console.WriteLine("Введите элемент для поиска:");
int el = Convert.ToInt32(Console.ReadLine());
string find = Find(matrix1, el);
Console.WriteLine(find);

Console.WriteLine();
Console.WriteLine("конец алгоритма 50");

// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
Console.WriteLine();

Console.Write("Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine(); 

double[] Averedge(int[,] matr)                 // Нахождение средне арифмитического в каждом столбце массива
{
    double[] res = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            sum += matr[i,j];
        }
        res[j] = Math.Round(sum/matr.GetLength(0), 2);
    }
    return res;
}

Console.Write("Введите размер матрицы одной цифрой: ");
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] matrix2 = new int[size1[0], size1[0]];
Console.WriteLine("Начальный массив:");
PrintArray(matrix2);
    FillArray(matrix2);
Console.WriteLine("Заполненный массив:"); //Console.WriteLine();
PrintArray(matrix2);

double[] res = Averedge(matrix2);
Console.WriteLine();
Console.WriteLine(String.Join(' ', res));

Console.WriteLine();
Console.WriteLine("конец алгоритма 52");