Console.Clear();
Console.WriteLine("Hello, Рустем!");
Console.WriteLine();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве..");
Console.WriteLine();

void input_array(int [] array)          // создание и заполнение массива рандомом
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999); // [100;999]
}
int f = 0;
int release(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 10)
                count ++;
    return count;
}
// Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(release(array));

Console.WriteLine();
Console.WriteLine("конец алгоритма 25");

// if (array[i] >= 101 && array[i] <= 199 && array[i] % == 0)