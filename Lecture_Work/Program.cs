// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");

// Двумерные массивы и рекурсия

// string[,] table = new string [2, 5];  //  таблица строк или слов

// table[0, 0] = "слово";
// table[1, 4] = "слово";


// for ( int rows=0; rows<2; rows++)
// {
//     for ( int columns=0; columns<5; columns++)
//     {
//         Console.Write($"!{table[rows, columns]}! "); // без перевода строки для того чтобы получить прямоугольник
//         //Console.WriteLine($"[{string.Join(", ", table[rows, columns])}]");
//     }
// Console.WriteLine(); // чтобы получить прямоугольник
// }

// //Console.Clear();
// Console.WriteLine();

// int[,] matrix = new int [3,4];

// for ( int i = 0; i < 3; i++)  // по строкам     matrix.GetLength(0)
// {
//     for ( int j = 0; j < 4; j++)  // по столбцам    matrix.GetLength(1)
//     {
//         Console.Write($"!{matrix [i, j]}! ");
//         //Console.Write($"[{string.Join(", ", matrix [i, j])}]");
//     }
// Console.WriteLine(); // чтобы получить прямоугольник
// }

// Console.WriteLine();

// int[,] matrix1 = new int [3,4];

// for ( int i = 0; i < matrix1.GetLength(0); i++)  // по строкам  дает тоже самое что указано выще в размерности  
// {
//     for ( int j = 0; j < matrix1.GetLength(1); j++)  // по столбцам    
//     {
//         Console.Write($"/{matrix1 [i, j]}/ ");
//         //Console.Write($"[{string.Join(", ", matrix [i, j])}]");
//     }
// Console.WriteLine(); // чтобы получить прямоугольник
// }

void PrintArray (int[,] matr)  //метод для распечатки матрицы чисел matrix
{
    for (int i = 0; i < matr.GetLength(0); i++)  // по строкам  дает тоже самое что указано выще в размерности  
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
             matr[i, j] = new Random().Next(1,10); // зеполлнение матрицы рандомно из 1-10 сектора
        }
    Console.WriteLine(); // чтобы получить прямоугольник
    }
}

int[,] matrix = new int [3,4];
PrintArray(matrix); 
Console.WriteLine();

FillArray(matrix);
PrintArray(matrix); 

