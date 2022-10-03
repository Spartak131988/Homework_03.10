int[] Create(int len)
{
    return new int[len];
}

void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

string Print(int[] array)
{
    return "[" + String.Join(',', array) + "]";
}

int SumOddIndex(int[] array)
{
    int sum = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] coll = Create(5);
Fill(coll, -100, 100);
Console.WriteLine("Массив: " + Print(coll));
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях: " + SumOddIndex(coll));