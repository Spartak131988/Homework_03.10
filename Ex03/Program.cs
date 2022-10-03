void Fill(double[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * new Random(). Next (min, max), 2);
    }
}

string Print(double[] array)
{
    return "[" + String.Join("; ", array) + "]";
}

double MaxElement(double[] array)
{
    double max = array[0];
    int size = array.Length;
    for (int i = 1; i < size; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    int size = array.Length;
    for (int i = 1; i < size; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


double[] numbers = new double[5];
Fill(numbers, 1, 100);
Console.WriteLine("Массив: " + Print(numbers));
Console.WriteLine("Максимальный элемент: " + MaxElement(numbers));
Console.WriteLine("Минимальный элемент: " + MinElement(numbers));
double diff = Math.Round(MaxElement(numbers) - MinElement(numbers), 2);
Console.WriteLine("Разница между макс. и мин.: " + diff);