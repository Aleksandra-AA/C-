void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void printmassiv(int[] fillArray)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < fillArray.Length; i++)
    {
        Console.Write(fillArray[i] + " ");
    }
    Console.WriteLine();
}

int[] array = new int[6];
fillArray(array);
printmassiv(array);

int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Разница: " + (max - min));

