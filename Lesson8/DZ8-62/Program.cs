int[,] initArrayByUserSize() {
    Console.WriteLine("Введите количество строк матрицы:");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов матрицы:");
    int M = int.Parse(Console.ReadLine());
   
   int[,] matr = new int[N, M];
   for (int i=0; i<N; i++)
    {
        for(int j=0;j<M; j++)
        {
            matr[i,j] = 0;
        }
    }

    int u=0;
    int p=1;
    int x=0;
    int y=0;
    int dir = 0;
    matr[0,0]=p;


    while (p!=u) 
    {
        u=p;
        if (dir == 0) 
        {
            if (y==M-1 || matr[x,y+1]!=0) 
                dir = 1;
            else 
            {
                y++;
                p++;
                matr[x, y] = p;
            }
        }
        if (dir == 1) 
        {
            if (x==N-1 || matr[x+1,y]!=0) 
                dir = 2;
            else 
            {
                x++;
                p++;
                matr[x, y] = p;
            }
        }
        if (dir == 2) 
        {
            if (y==0 || matr[x,y-1]!=0) 
                dir = 3;
            else 
            {
                y--;
                p++;
                matr[x, y] = p;
            }
        }
        if (dir == 3) 
        {
            if (x==0 || matr[x-1,y]!=0) 
                dir = 0;
            else 
            {
                x--;
                p++;
                matr[x, y] = p;
            }
        }
        if (dir == 0) 
        {
            if (y==M-1 || matr[x,y+1]!=0) 
                dir = 1;
            else 
            {
                y++;
                p++;
                matr[x, y] = p;
            }
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
            if (matrix[i,j]<10) Console.Write("0");
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] matr = initArrayByUserSize();
printMatrix(matr);