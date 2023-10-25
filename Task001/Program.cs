// Задача 34.
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример: [345, 897, 568, 234] -> 2

int[] FillArrayRnd()
{
    Random rndGenVal = new Random();
    int[] retVal = new int[rndGenVal.Next(2, 11)];
    for (int i = 0; i < retVal.Length; i++)
        retVal[i] = (int)rndGenVal.Next(100, 1000);
    return retVal;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join("\t", array));
    // Console.Write("[" + string.Join(", ", array) + "]"); Вариант вывода с квадратными скобками и разделением запятой.
}

int FindCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] myArray = FillArrayRnd();
Console.WriteLine("Массив:");
PrintArray(myArray);
Console.WriteLine($"Количество четных элементов: {FindCount(myArray)}.");