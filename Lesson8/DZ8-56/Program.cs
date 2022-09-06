int[,] initArrayByUserSize() {
    Console.WriteLine("Введите количество строк матрицы:");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов матрицы:");
    int M = int.Parse(Console.ReadLine());
   
   int[,] matr = new int[N, M];
   Random r = new Random();
   for (int i=0; i<N; i++)
    {
        for(int j=0;j<M; j++)
        {
            matr[i,j] = r.Next(1, 10);
        }
    }
    return matr;
}


void printMatrix(int[,] matrix) 
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0;j<matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int getCollumnSumm(int column, int[,] matrix) {
    int sum = 0;
    for (int i=0;i<matrix.GetLength(1);i++) {
        sum+=matrix[column, i];
    }
    return sum;
}

int getColumnByMinSumm(int[,] matrix) 
{
    int minColumnIndex = 0;
    int minSumm = getCollumnSumm(0, matrix);
    for(int i=1; i<matrix.GetLength(0); i++)
    {
        int sum = getCollumnSumm(i, matrix);
        if (minSumm>sum) {
            minSumm=sum;
            minColumnIndex = i;    
        }
    }
    return minColumnIndex;
}


int[,] matr = initArrayByUserSize();
Console.WriteLine("Матрица");
printMatrix(matr);
Console.WriteLine("Строка с минимальной суммой:" + getColumnByMinSumm(matr));
