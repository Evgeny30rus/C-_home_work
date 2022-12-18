Console.Clear();
Console.WriteLine("Hello, Рустем!");
Console.WriteLine();

// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("из трехзначного числа на выходе покажет вторую цифру этого числа");
Console.WriteLine();
Console.Write("Введите трехзначное число, типа: ааa ");
Console.WriteLine();
int r = Convert.ToInt32(Console.ReadLine());

while (r < 100 || r > 1000)
{
	Console.WriteLine("Вы ошиблись!!!");
	r = Convert.ToInt32(Console.ReadLine());
}

int n3 = r / 10; // берем только целую часть до запятой
int n4 = n3 % 10; // берем только остаток после запятой

Console.WriteLine($"{n4}"); //вывод другой

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите числом выходной день недели от 1 до 7 : ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 || a > 7){
	Console.WriteLine("Вы ошиблись!! Введите число: ");
	a = Convert.ToInt32(Console.ReadLine());
}

if (a==1) Console.WriteLine("Нет. Понедельник - рабочий день");
else if (a==2) Console.WriteLine("Нет. Вторник - рабочий день");
else if (a==3) Console.WriteLine("Нет. Среда - рабочий день");
else if (a==4) Console.WriteLine("Нет. Четверг - рабочий день");
else if (a==5) Console.WriteLine("Нет. Пятница - практически рабочий день");
else if (a==6) Console.WriteLine("Да. Суббота - УРА! выходной день");
else if (a==7) Console.WriteLine("Да. Воскресенье - УРА! выходной день");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.(можно использовать индексацию строк)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("из числа на выходе покажет третью цифру, при отсуствии выдаст сообщение");

Console.Write("Введите число: ");
Console.WriteLine();
//int r1 = Convert.ToInt32(Console.ReadLine());

// int n1 = r1 / 10; // берем только целую часть до запятой
// int n2 = n1 % 10; // берем только остаток после запятой

// Console.WriteLine($"{n2}"); //вывод другой

int r1 = Convert.ToInt32(Console.ReadLine());


while (r1 < 100 )
{
	Console.WriteLine("третьей цифры в таком чсиле не будет, повторите ввод: ");
	r1 = Convert.ToInt32(Console.ReadLine());
    }

string t = string.Format("{0:###}", r1);

// Console.WriteLine(t.ToString("#####"));

// var x = t.Substring(t.Length-3);
// Console.WriteLine(x);


Console.WriteLine(t);




Console.WriteLine();
Console.WriteLine("Спасибо, за потраченное время :-) ");