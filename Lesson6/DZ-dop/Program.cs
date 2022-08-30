
Console.WriteLine("Введите количество строк матрицы:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int M = int.Parse(Console.ReadLine());

int[,] matr = new int[N, M];
Random r = new Random();

int spur = 0;
for (int i=0; i<N; i++)
{
    for(int j=0;j<M; j++)
    {
        matr[i,j] = r.Next(0,10);
        Console.Write(matr[i,j] + " ");
        if (i==j) spur+=matr[i,j];
    }
    Console.WriteLine();
}
Console.WriteLine("Сумма элементов главной диагонали матрицы равна:" + spur);