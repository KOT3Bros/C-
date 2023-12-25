// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int result = firstDigit * 10 + thirdDigit;
    Console.WriteLine($"Результат от числа {number} = {result}.");
}
else
{
    Console.WriteLine("Число НЕ трёхзначное");
}