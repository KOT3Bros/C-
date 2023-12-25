// // Напишите программу, которая выводит третью слева
// // цифру заданного числа или сообщает, что третьей цифры
// // нет.
// // 456 => 6
// // 7812 => 1
// // 91 => Третьей цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100)
// {
//     Console.WriteLine("Третьей цифры нет.");
// }
// else
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     Console.WriteLine($"Третья цифра слева от числа {copyNumber} = {number % 10}");
// }

// // Напишите программу, которая выводит третью справа
// // цифру заданного числа или сообщает, что третьей цифры
// // нет.
// // 456 => 4
// // 7812 => 8
// // 91 => Третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    int i = 0;
    while (i < 2)
    {
        number /= 10;
        i++;
    }
    Console.WriteLine($"Третья цифра справа от числа {copyNumber} = {number % 10}");
}