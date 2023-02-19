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

int[,] pic = new int[,] // необходимо ввести массив

void PrintImage (int[,] image)  // метод для распечатки картинки и замены чисел
{
    for (int i = 0; i < image.GetLength(0); i++)  // по строкам  дает тоже самое что указано выще в размерности  
    {
        for (int j = 0; j < image.GetLength(1); j++)  // по столбцам    
        {
        //Console.Write($"/{image[i, j]}/ ");
        if(image[i,j] == 0) Console.Write($" ");
        else Console.Write($"+");
        }
    Console.WriteLine(); // чтобы получить прямоугольник
    }
}
PrintImage(pic);


// Рекурсия - функция, которая определеяется через саму себя...

// Вычисление факториала 3! = 3*2*1 = 3*2!

int Factorial (int n1)
{
   //1! = 1
   //0! = 1
   if (n1==1) return 1;
   else return n1 * Factorial(n1-1);
}
Console.WriteLine(Factorial(3)); //1*2*3 = 6

// Числа Фибоначи - первые два числа равны 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел,
// f(0) = 0
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibo (int n)
{
   if(n==1 || n-2) return 1;
   else return Fibo(n-1) + Fibo(n-2);
}
for (int i=1; i<10; i++)
{
    Console.WriteLine(Fibo(i));
}

// Задача - вывести строку с числами от А до В, где А<=B
// Решение стандарт через цикл:

string Number_For(int a, int b)
{
   string result = String.Empty;
   for (int i = a; i <= b; i++)   // если условие А>=B =>  for (int i=a; i>=b; i--)
   {
    result += $"{i} ";
   }
   return result; 
} 

// Решение стандарт через рекурсию:
string Number_Recurs(int a, int b)
{
   if (a <= b) return $"{a} " + Number_Recurs(a+1, b);  // если условие А>=B =>  if (a <= b) return Number_Recurs(a+1, b) + $"{a} "; 
   else return String.Empty;
}

Console.WriteLine(Number_For(1,10));    // 1 2 3 ... 10
Console.WriteLine(Number_Recurs(1,10)); // 1 2 3 ... 10

// Задача - вывести сумму чисел от 1 до N,
// Решение стандарт через цикл:

int Sum_For(int n)
{
   int result = 0;
   for (int i = 1; i <= n; i++) 
    result += i;
   
   return result; 
} 
// Решение стандарт через рекурсию:

int Sum_Recurs(int n)
{
    if (n==0) return 0;
    else return n + Sum_Recurs(n-1);
}

Console.WriteLine(Sum_For(10));    // 55
Console.WriteLine(Sum_Recurs(10)); // 55

// Задача - вывести факториал числа N, N!
// Решение стандарт через цикл:

int Factorial_For(int n)
{
    int result = 1;
    for (int i=1; i<=n; i++) result *= i;
    return result;
}
// Решение стандарт через рекурсию:
int Factorial_Recurs (int n1)
{
   //1! = 1
   //0! = 1
   if (n1==1) return 1;
   else return n1 * Factorial_Recurs(n1-1);
}
Console.WriteLine(Factorial_Recurs(3)); //1*2*3 = 6
Console.WriteLine(Factorial_For(3));    //1*2*3 = 6



