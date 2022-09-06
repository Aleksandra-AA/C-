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

int[,] getMultMatrix(int[,] A, int[,] B) {
    int[,] mult = new int[A.GetLength(0), B.GetLength(1)];

    for (int i=0; i<A.GetLength(0); i++) 
    {
        for (int k=0; k<B.GetLength(1); k++)
        {
            int sum = 0;

            for (int j=0; j<A.GetLength(1); j++)
            {
                sum+=A[i, j]*B[j,k];
            }            
            mult[i, k] = sum;
        }
    }
    return mult;
}


int[,] matr1 = initArrayByUserSize();
int[,] matr2 = initArrayByUserSize();
Console.WriteLine("Матрица 1");
printMatrix(matr1);

Console.WriteLine("Матрица 2");
printMatrix(matr2);

if (matr1.GetLength(1)!=matr2.GetLength(0)) {
    Console.WriteLine("Матрицы нельзя перемножить");
} else {
    Console.WriteLine("Произведение матриц:");
    printMatrix(getMultMatrix(matr1, matr2));
}



