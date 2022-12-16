//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементами массива.

//Методы
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int MaxMinDiff(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    return max - min;
}
//Начальные данные
int length = 10;
int max = 99;
int min = 1;
//Создание и заполнение массива
int[] array = CreateArray(length, min, max);
//Поиск максимального и минимального элементов массива и нахождение их разницы
int result = MaxMinDiff(array);
//Вывод результата
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {result}");