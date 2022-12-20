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

// Console.WriteLine("Введите число N");
// double N = Convert.ToDouble(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//     double result = Math.Pow(i, 3);
//     Console.WriteLine(result);
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());
// int i;
// int sum = 1;

// for (i = 1; i <= B; i++)
// {
//     sum = A * sum;
// }
// Console.WriteLine($"Число {A} в степени {B} равно = {sum}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);
// int sum = 0;
// int res = 0;
// int num1;


// while (number > 10)
// {
//     num1 = number % 10;
//     sum = sum + num1;
//     number = number / 10;
// }
// if (number<10)
// {
//     res = sum + number;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] arr = new int[8];

// Console.WriteLine("Введите 8 (Восемь) целых чисел для создания массива");

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Вы создали массив:");
// Console.Write(string.Join(", ", arr));

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] array = new int[5];
// Random rand = new Random();
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(100, 1000);
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(count);
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// i = 1, i+=2

// int[] array = new int[6];
// Random rand = new Random();
// int res = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 10);
// }
// for (int i = 1; i < array.Length; i += 2)
// {
//     res = array[i] + res;
// }
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"Сумма элементов array[1], [3], [5] = {res}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] array = { 3, 7, 22, 2, 78 };

// double count = 0;
// double max = 0;
// double min = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
// count = max - min;
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"Минимальное число = {min}");
// Console.WriteLine($"Максимальное число = {max}");
// Console.WriteLine($"Разница между максимальным и минимальным элементом = {count}");