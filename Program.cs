// Промежуточная аттестация
// Задание 1

class Program
{
    static void Main(string[] args)
    {
        int m = 1;
        int n = 10;
        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write($"{m} ");
            PrintNumbers(m + 1, n);
        }
    }
}

// Задание 2

// class Program
// {
//     static int Ackerman(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return Ackerman(m - 1, 1);
//         }
//         else
//         {
//             return Ackerman(m - 1, Ackerman(m, n - 1));
//         }
//     }

//     static void Main(string[] args)
//     {
//         int m = 2;
//         int n = 3;
//         int result = Ackerman(m, n);
//         Console.WriteLine($"A({m}, {n}) = {result}");
//     }
// }


// Задание 3

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = { 1, 2, 3, 4, 5 };
//         PrintArray(array, array.Length - 1);
//     }

//     static void PrintArray(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write($"{array[index]} ");
//             PrintArray(array, index - 1);
//         }
//     }
// }