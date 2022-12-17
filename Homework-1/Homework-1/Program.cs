internal class Program
{
    private static void Main(string[] args)
    {
        int[,] arr1 = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {5, 6, 7},
        };

        int[,] arr2 = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {5, 6, 7},
        };

        int[,] arr3 = new int[,]
        {
            {1, 2, 3, 4},
            {5,6,7,8},
            {9,10,11,12},
            {13,14,15,16},
        };

        int i = 1;
        int[] arr = new int[]
        {
            1, 2, 3, 4, 5, 6,
        };

        Console.WriteLine($"Array before reverse: {String.Join(" ", arr)}");
        arr = ReverseArray(arr);

        Console.WriteLine($"Array after Reverse{String.Join(" ", arr)}");
        Console.WriteLine();

        SumColAndRow(arr1);

        Console.WriteLine($"Are matrix equal by value: {CompareMatrix(arr1, arr2)}");

        NumsAboveMain(arr3);

    }

    public static void NumsAboveMain(int[,] arr3)
    {
        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                int pos = j + i+1;

                if (pos >= arr3.GetLength(1))
                {
                    continue;
                }
                else
                {
                    Console.Write($"{arr3[i, pos]} ");
                }
            }
            Console.WriteLine();
            Console.Write(" ");
        }
    }

    public static int[] ReverseArray(int[] arr)
    {
        int val = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int pos = arr.Length - (1 + i);
            if (pos < arr.Length / 2)
            {
                continue;
            }

            val = arr[i];

            arr[i] = arr[pos];
            arr[pos] = val;
        }

        return arr;

    }

    public static bool CompareMatrix(int[,] arr1, int[,] arr2)
    {
        bool areSimilar = true;

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                if (arr1[i, j] != arr2[i, j])
                {
                    areSimilar = false;
                }
            }
        }

        return areSimilar;
    }

    public static void SumColAndRow(int[,] arr1)
    {
        int[] resultRow = new int[arr1.GetLength(1)];
        int[] resultCol = new int[arr1.GetLength(0)];

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            int sumRow = 0;

            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                sumRow += arr1[i, j];

                if (j == arr1.GetLength(1) - 1)
                {
                    resultRow[i] = sumRow;
                }
            }
        }

        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            int sumCol = 0;

            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                sumCol += arr1[j, i];

                if (j == arr1.GetLength(1) - 1)
                {
                    resultCol[i] = sumCol;
                }
            }
        }
        Console.WriteLine("Row sum is:");
        Console.WriteLine(String.Join(" ", resultRow));
        Console.WriteLine();
        Console.WriteLine("Col sum is:");
        Console.WriteLine(String.Join(" ", resultCol));
        Console.WriteLine();
    }

    public static int Sum(int n)
    {
        if (n <= 0)
            return 0;

        return n + Sum(n - 1);
    }

    public static int SumInterval(int m, int n)
    {
        if (n < m)
            return 0;

        return n + SumInterval(m, n - 1);
    }
}