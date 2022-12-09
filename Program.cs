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


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2; // индекс нужной цифры

if (number < 0)
{
    number = -number;
}

if (number > 100)
{
    int digit = number.ToString()[digitIndex] - '0';
    Console.WriteLine("Третья цифра " + digit + " //первым способом");
}
else
{
    Console.WriteLine($"Во введенном числе {number} нет третьей цифры");
}