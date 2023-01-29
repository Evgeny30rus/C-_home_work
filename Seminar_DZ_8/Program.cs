// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Рустем!");

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//            каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine();

Console.Write("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine();

void PrintArray(int[,] matr)  //метод для распечатки матрицы чисел matrix
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

void FillArray(int[,] matr)  //метод для заполнения матрицы matrix числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  // по строкам  дает тоже самое что указано выще в размерности  
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // по столбцам    
        {
            matr[i, j] = new Random().Next(1, 10); // заполлнение матрицы рандомно от 1 до 10 
        }
        Console.WriteLine(); // чтобы получить прямоугольник
    }
}

int [,] Min_Max_ROW(int[,] matr)   // метод упорядочит значения в массиве от max -> min построчно
{
    int max = matr[0, 0]; int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (k = 0; k < matr.GetLength(1) - 1; k++) ;
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    max = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = max;
                }
            }

        }
    }
    return matr;
}


Console.Write("Введите размер матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] != size[1])                         // проверка размерности матрицы (нужен квадрат)
{
    Console.Write("Ошибка!! Введите размер матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
// size[0] - row
// size[1] - column
int[,] matrix = new int[size[0], size[1]];
Console.Write("Пустой массив"); Console.WriteLine();
PrintArray(matrix); 

FillArray(matrix);
Console.Write("Итоговый массив"); Console.WriteLine();
PrintArray(matrix); 

Console.WriteLine();
Console.WriteLine("конец алгоритма 47");


Console.WriteLine("Конечная матрица:");
PrintArray(Min_Max_ROW(matrix));