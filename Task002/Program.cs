// Задача № 36.
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример: [3, 7, 23, 12] -> 19
//         [-4, -6, 89, 6] -> 0

int[] FillArrayRnd()
{
    Random rndGenVal = new Random();
    int[] retVal = new int[rndGenVal.Next(2, 11)];
    for (int i = 0; i < retVal.Length; i++)
        retVal[i] = (int)rndGenVal.Next(1, 1000);
    return retVal;
}

void PrintArray(int[] array)
{
    // Console.WriteLine(string.Join("\t", array));
    Console.WriteLine("[" + string.Join(", ", array) + "]"); 
    // Вариант вывода с квадратными скобками и разделением запятой.
}

int FindSumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] myArray = FillArrayRnd();
Console.WriteLine("Массив:");
PrintArray(myArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {FindSumOddElements(myArray)}.");