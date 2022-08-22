int[] massiv(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        int number = int.Parse(Console.ReadLine());
        array[i]=number;
    }
    return array;
}
 
 void printmassiv (int[] massiv)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write(massiv[i] + " ");
    }
    Console.WriteLine();
}

int N = 8;

Console.Clear();

Console.WriteLine("Введите массив из 8 элементов: ");

int[] arr = massiv(N);
printmassiv(arr);
