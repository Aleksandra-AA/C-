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

void sortColumn(int column, int[,] matrix) 
{
    for(int i=0; i<matrix.GetLength(1); i++)
    {
        for(int j=i+1; j<matrix.GetLength(1); j++)
        {
            if (matrix[column, i]<matrix[column, j])
            {
                int tmp = matrix[column, i];
                matrix[column, i]= matrix[column, j];
                matrix[column, j]=tmp;
            }
        }
    }
}


int[,] matr = initArrayByUserSize();
Console.WriteLine("Начальная матрица");
printMatrix(matr);
for (int i=0; i<matr.GetLength(0); i++) {
     sortColumn(i, matr);  
}
Console.WriteLine("Отсортированная матрица");
printMatrix(matr);




