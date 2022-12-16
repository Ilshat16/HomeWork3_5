//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечетных позициях

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

int SumOdds(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
//Начальные данные
int length = 10;
int min = 1;
int max = 99;
//Создать и заполнить случайными числами массив
int[] array = CreateArray(length, min, max);
//Сложить элементы массива с нечетным индексом
int result = SumOdds(array);
//Вывод результата
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {result}");