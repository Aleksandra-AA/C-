
// int[] fillArray(int[] arr)
// {
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.WriteLine(array[i]);
    }
//     return arr;
// }

// Console.WriteLine(fillArray[]);


// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i]);
// }

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());

bool isNumberInArray = false;    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == A)
        {
            Console.WriteLine("Заданное число присутствует в массиве");
            isNumberInArray = true;
            break;
        }
        // else
        // {
        //     Console.WriteLine("Заданное число отсутсвует в массиве");
        //     break;
        // }
    }
    if (!isNumberInArray) 
    {
        Console.WriteLine("Заданное число отсутсвует в массиве");
    }
// if array[i] = 8;
// Console.WriteLine(array[i]);

