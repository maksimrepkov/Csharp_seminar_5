// Задача № 38.
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrayRnd()
{
    Random rndGenVal = new Random();
    double[] retVal = new double[rndGenVal.Next(2, 5)];
    for (int i = 0; i < retVal.Length; i++)
        retVal[i] = rndGenVal.Next(-100, 100) + rndGenVal.NextDouble();
    return retVal;
}

void PrintArray(double[] array)
{
    // Console.WriteLine(string.Join("\t", array));
    Console.WriteLine("[" + string.Join(", ", array) + "]"); 
}


double FindMaxElement(double[] array)
{
    double max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
        max = array[i];
    }
    return max;
}
double FindMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min)
        min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double difference = FindMaxElement(array) - FindMinElement(array);
    return difference;
}

double[] myArray = FillArrayRnd();
Console.WriteLine("Массив:");
PrintArray(myArray);
Console.WriteLine($"Максимальный элемент массива: {FindMaxElement(myArray)}.");
Console.WriteLine($"Минимальный элемент массива: {FindMinElement(myArray)}.");
Console.WriteLine($"Разность между максимальным и минимальным элементом = {CalcDifferenceBetweenMaxMin(myArray)}.");