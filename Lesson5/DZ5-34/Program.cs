
void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
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

int[] array = new int[8];
fillArray(array);
printmassiv(array);

int counter = 0;
for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        {
        counter++;
        }
    }
    Console.WriteLine("Четных чисел в массиве: " + counter);