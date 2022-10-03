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

int SearchEvenNumbers(int[] array)
{
    int pos = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            pos ++;
        }
    }
    return pos;
}


int[] arr = Create(5);
Fill(arr, 100, 1000);
Console.WriteLine("Массив: " + Print(arr));
Console.WriteLine("Количество чётных чисел в массиве: " + SearchEvenNumbers(arr));