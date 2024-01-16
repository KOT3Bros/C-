// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
// 425 => [4 2 5]
// 8741 => [8 7 4 1]
// 4 => [4]

Console.Write("Введите натуральное число в диапозоне от 1 до 100 000: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 1 && N <= 100000)
{
    int count = 0;
    int copyN = N;
    while (N > 0)
    {
        N /= 10;
        count++;
    }
    int[] array = new int[count];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int last = copyN % 10;
        copyN /= 10;
        array[i] = last;
    }
    Console.WriteLine($"Массив: [ {string.Join(" ", array)} ]");
}
else
{
    Console.WriteLine($"Число {N} не входит в диапазон от 1 до 100 000.");
}