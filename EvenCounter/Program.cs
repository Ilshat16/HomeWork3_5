// Задайте массив заполненный случайными положительными трехфазными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.

//Методы
int[] CreateArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int SearchEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count;
}
//Инициализация переменных
int length = 20;
int min = 100;
int max = 999;
//Инициализация и заполнение массива
int[] array = CreateArray(length, min, max);
//Поиск и подчет количества четных чисел
int result = SearchEven(array);
//Вывод результата
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"В массиве {result} четных чисел");