using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = Console.ReadLine();
        string[] data = File.ReadAllLines($@"{path}");

        int row = int.Parse(data[0]);
        int col = int.Parse(data[1]);

        decimal[,]matrix = new decimal[row, col];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] splited = data[i+2].Split("\t");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = decimal.Parse(splited[j]);
            }
        }

        Console.WriteLine($"Is matrix single: {CheckIdentity(matrix)}");
        decimal sum = SumNegativeOnAntiDiagonal(matrix);
        Console.WriteLine($"Reverse main diagonal negative sum: {sum}");
        NormalizeRows(matrix);
        SortMatrix(matrix);
    }

    public static void PrintMatrix(decimal[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(string.Format($"{matrix[i, j]} "));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }

    public static bool CheckIdentity(decimal[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    if (matrix[i,j] != 1)
                    {
                        return false;
                        
                    }
                }
                else
                {
                    if (matrix[i,j] != 0)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    public static decimal SumNegativeOnAntiDiagonal(decimal[,] matrix)
    {
        decimal negativeSum = 0;

        for (int i = 0; i < matrix.GetLength(1);)
        {
            for (int j = matrix.GetLength(0) - 1; j > 0; j--)
            {
                 if (matrix[i, j] < 0)
                {
                    negativeSum += matrix[i, j];
                    i++;
                }
            }
        }

        return negativeSum;
    }

    public static void NormalizeRows(decimal[,] matrix)
    {
        decimal sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j] * matrix[i,j];
            }

            double sqrt = Math.Sqrt((double)sum);

            if (sqrt != 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[i, col] /= (decimal)sqrt;
                }
            }
            sum = 0;
        }
    }

    public static void SortMatrix(decimal[,] matrix)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                SortCol(matrix, col, (decimal a, decimal b) => { return a > b; });
            }
            else
            {
                SortCol(matrix, col, (decimal a, decimal b) => { return a < b; });

            }
        }
        PrintMatrix(matrix);
    }
    public static void SortCol(decimal[,]matrix,int col, Func<decimal,decimal,bool>predicate)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i+1; j < matrix.GetLength(0); j++)
            {
                
                if (predicate(matrix[i, col],matrix[j, col]))
                {
                    decimal temp = matrix[i, col];
                    matrix[i, col] = matrix[j, col];
                    matrix[j, col] = temp;
                }
            }
        }
    }
}
