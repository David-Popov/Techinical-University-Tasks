internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        //primeren vhod
        //int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 20, 6, 7, 8 }, { 4, 10, 25, 0 }, { 5, 8, 10, 2 } };

        //int[] arr = GetColumnMatrix(matrix);
        //int min = arr[0];
        //int max = 0;

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i] > max)
        //    {
        //        max = arr[i];
        //    }
        //    else if (arr[i] < min)
        //    {
        //        min = arr[i];
        //    }
        //}

        ////zadacha 2
        //int[] arr2;

        //arr2 = new int[n];

        //for (int i = 1; i <= arr2.Length; i++)
        //{
        //    arr2[i - 1] = i;
        //}

        //RotateRight(arr2);
        ////InitPrimes(arr2, n);

        ReadTriangleMatrix(n);

    }

    static int[] GetColumnMatrix(int[,] matrix)
    {
        int max = 0;
        int[] listOfMax = new int[matrix.GetLength(0)];
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] > max)
                {
                    max = matrix[row, col];
                }
            }
            listOfMax[col] = max;
            max = 0;
        }
        return listOfMax;
    }

    static void InitPrimes(int[] arr, int n)
    {

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] / arr[i] != 1 && arr[i] / 1 != 1 && arr[i] > 1)
            {
                arr[i] = n;
            }
        }
    }

    static void RotateRight(int[] arr)
    {
        var t = arr[arr.Length - 1];
        for (var i = arr.Length - 1; i > 0; i--)
        {
            arr[i] = arr[i - 1];
        }
        arr[0] = t;
    }

    static void ReadTriangleMatrix(int n)
    {
        int[,]matrix = new int[n,n];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = int.Parse(Console.ReadLine());
            }
        }
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,]arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j]);
            }
        }
        Console.WriteLine();
    }
}