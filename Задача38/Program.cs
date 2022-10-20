// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Внутренние функции использовать нельзя(Max и Min)
// [3 7 22 2 78] -> 76 

double[] CreateArrayRndInt(int size, int min, int max)   
{
    double[] array = new double[size];
    var rnd = new Random();   

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * 100), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]};   ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxNumArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinNumArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
double[] arr = CreateArrayRndInt(10, 0, 100);
PrintArray(arr);
double resalt = Math.Round((MaxNumArray(arr) - MinNumArray(arr)), 2);
Console.WriteLine(resalt);