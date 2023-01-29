// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Рустем!");
Console.WriteLine();

// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Задача 47. Задайте двумерный массив размером m и n,заполненный случайными вещественными числами.");
Console.WriteLine(); 


void PrintArray (int[,] matr)  //метод для распечатки матрицы чисел matrix
{
    for (int i = 0; i < matr.GetLength(0); i++)  // по строкам  дает тоже самое что указано строка 42  
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // по столбцам    
        {
        Console.Write($"/{matr[i, j]}/ ");
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
Console.WriteLine();

FillArray(matrix);
Console.Write("Итоговый массив"); Console.WriteLine();
PrintArray(matrix); 

Console.WriteLine();
Console.WriteLine("конец алгоритма 47");