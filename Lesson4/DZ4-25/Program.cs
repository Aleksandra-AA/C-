int exponent (int B, int A)
{
    int exp = 1;
    for(int i = 0; i < B; i++)
    {
        exp = exp * A ;
    }
    return exp;
}    

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine());   

Console.WriteLine(exponent(B, A));