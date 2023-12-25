// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10;
    int thirdDigit = number % 10;
    int result = (int)Math.Pow(secondDigit, thirdDigit);
    Console.WriteLine($"Результат от числа {number} = {result}.");
}
else
{
    Console.WriteLine("Число НЕ трёхзначное");
}