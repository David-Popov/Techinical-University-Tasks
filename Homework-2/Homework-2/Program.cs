using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        //int oddSum = 0;
        //int evenSum = 0;
        //var text = File.ReadAllText(@"C:\Programming\TU-Zadachi\Homework-2\Homework-2\matrix.txt").Split("\r\n");
        //int matrixLenght = text.Length;
        //int[,] matrix = new int[matrixLenght, matrixLenght];

        //for (int i = 0; i < text.Length; i++)
        //{
        //    var digit = text[i].Split(' ');

        //    for (int j = 0; j < matrix.GetLength(0); j++)
        //    {
        //        matrix[i, j] = int.Parse(digit[j]);
        //    }
        //}

        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            if (matrix[i, j] % 2 == 0)
        //            {
        //                evenSum += matrix[i, j];
        //            }
        //        }
        //        if (j % 2 != 0)
        //        {
        //            if (matrix[i, j] % 2 != 0)
        //            {
        //                oddSum += matrix[i, j];
        //            }
        //        }
        //    }
        //}

        //Console.WriteLine($"The sum of odd numbers is: {oddSum}");
        //Console.WriteLine($"The sum of even numbers is: {evenSum}");


        //Zadacha-2


        //Console.WriteLine("Please enter file path:");
        //string path = Console.ReadLine();
        //string text = File.ReadAllText($@"{path}");
        //int comma_dot_Count = 0;
        //int numsCount = 0;

        //var split1 = text.Split(' ');

        //for (int i = 0; i < split1.Length; i++)
        //{
        //    int n;
        //    bool isNumeric = int.TryParse(split1[i], out n);

        //    if (isNumeric)
        //    {
        //        numsCount++;
        //    }
        //    else if (split1[i] == "," || split1[i] == ".")
        //    {
        //        comma_dot_Count++;
        //    }

        //}
        //Console.WriteLine($"There are {numsCount} numbers in that file!");
        //Console.WriteLine($"There are {comma_dot_Count} dots and commas in that file!");


        //zadacha 3
        //string[] text = File.ReadAllLines(@"C:\Programming\TU-Zadachi\Homework-2\Homework-2\text.txt");
        //int n = int.Parse(Console.ReadLine());

        //int[,] matrix = new int[n, n];

        //FillMatrix(text, matrix);
        //PrintMatrix(matrix);

        //zadacha 4
        string path = Console.ReadLine();
        string[] words = File.ReadAllLines($@"{path}");

        int[] mainLetters = new int[26];
        int[] currLetters;
        foreach (string word in words)
        {
            currLetters = new int[26];

            for (int i = 0; i < word.Length; i++)
            {
                int letterIndex = word[i] - 'a';
                currLetters[letterIndex]++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (currLetters[i] > mainLetters[i])
                {
                    mainLetters[i] = currLetters[i];
                }
            }
        }

        for (int i = 0; i < mainLetters.Length; i++)
        {
            for (int j = 0; j < mainLetters[i]; j++)
            {
                Console.Write($"{(char)(i + 'a')},");
            }
        }

    }

    public static void FillMatrix(string[] text,int[,]matrix)
    {
        string[] t;

        for (int i = 0; i < text.Length; i++)
        {
            t = text[i].Split('\t');
            int row = int.Parse(t[0]);
            int col = int.Parse(t[1]);
            int value = int.Parse(t[2]);
            matrix[row, col] = value;
        }
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write(string.Format($"{matrix[i, j]} "));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }
}