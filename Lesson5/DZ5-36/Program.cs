void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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

int summa = 0;
for (int i = 1; i < array.Length; i=i+2)
    {
        summa = summa + array[i];
    }
    Console.WriteLine("Сумма: " + summa);