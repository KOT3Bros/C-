// Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] array = { 1, -2, 3, 4, 5, -1, -7, -9, 10, -5 };
int[] result = new int[array.Length / 2];

for (int i = 0, j = array.Length - 1; i < result.Length; i++, j--)
{
    result[i] = array[i] * array[j];
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Результат: [ {string.Join("; ", result)} ]");