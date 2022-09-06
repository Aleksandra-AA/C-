int[,,] initArrayByUserSize() {
    Console.WriteLine("Введите количество строк:");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int M = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите глубину:");
    int K = int.Parse(Console.ReadLine());
   


   int[,,] matr = new int[K, N, M];
   int p = 10;
   for (int i=0; i<N; i++)
    {
        for(int j=0;j<M; j++)
        {
            for(int r=0;r<K; r++) 
            {
                matr[r,i,j] = p;
                p++;
            }
        }
    }
    return matr;
}


void printMatrix(int[,,] matrix) 
{
    for (int r=0; r<matrix.GetLength(0); r++)
    {
        for(int i=0;i<matrix.GetLength(1); i++)
        {
            for(int j=0;j<matrix.GetLength(2); j++)
                Console.Write($"{matrix[r,i,j]}({r}, {i}, {j}) ");
        }
        Console.WriteLine();
    }
}

int[,,] matr = initArrayByUserSize(); 
printMatrix(matr);

