// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 100 & number < 1000)
// {
//     int res = number / 10;
//     int res1 = res % 10;
//     Console.WriteLine($"Вторая цифра числа {number} - {res1}");
// }
// else
// {
//     Console.WriteLine("Введено некорректное число");
// }


// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int digitIndex = 2; // индекс нужной цифры

// if (number < 0)
// {
//     number = -number;
// }

// if (number > 100)
// {
//     int digit = number.ToString()[digitIndex] - '0';
//     Console.WriteLine("Третья цифра " + digit );
// }
// else
// {
//     Console.WriteLine($"Во введенном числе {number} нет третьей цифры");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите номер дня недели: ");
// int i = Convert.ToInt32(Console.ReadLine());

// if (i >= 1 & i <= 5) Console.WriteLine("Будний день");
// if (i == 6 | i == 7) Console.WriteLine("Выходной");
// if (i > 7 | i < 1) Console.WriteLine("Такого дня не существует");




// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());


// if (N >= 10000 && N < 100000)
// {
//     int first = N.ToString()[0] - '0';
//     int second = N.ToString()[1] - '0';
//     int third = N.ToString()[2] - '0';
//     int fourth = N.ToString()[3] - '0';
//     int fifth = N.ToString()[4] - '0';
//     if (first == fifth && second == fourth)
//     {
//         Console.WriteLine($"{N} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"{N} не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Введено некорректное число");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

// Console.WriteLine("Введите координаты точки A по x");
// double xA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки A по y");
// double yA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки A по z");
// double zA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B по x");
// double xB = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B по y");
// double yB = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B по z");
// double zB = Convert.ToDouble(Console.ReadLine());

// double res = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

// Console.WriteLine($"{res:f2}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
double N = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine(result);
}