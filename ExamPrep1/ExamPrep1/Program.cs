using System.ComponentModel;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        //string path = Console.ReadLine();

        //int x = 4;
        //int count = 0;
        //Iterative(x, count);
        int[] arr = new int[] { 1, 2, 3, 4, 1, 1, 5, 6 };
        CountTriples(arr);

    }



    static int[] ReadArrayFromFile(string path)
    {
        string readArr = File.ReadAllText(@$"{path}");
        string[] splitedArr = readArr.Split("\t");
        int[] arr = new int[splitedArr.Length];
        for (int i = 0; i < splitedArr.Length; i++)
        {
            arr[i] = int.Parse(splitedArr[i]);
        }
        return arr;
    }

    static bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        return false;
    }

    static int CountTriples(int[] arr)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length-2; i++)
        {
            for (int k = i + 1; k < arr.Length-1; k++)
            {
                for (int j = i + 2; j < arr.Length; j++)
                {
                    if ((arr[i] == arr[k]) && (arr[k] == arr[j]))
                    {
                        counter++;
                    }
                }
            }
        }
        return counter;
    }

    static string Recursive(int x, int count)
    {
        if (x == 1)
        {
            Console.WriteLine($"Function had to run {count} to set x = 1");
            return "";
        }
        if (x % 2 == 0)
        {
            return Recursive(x /= 2, ++count);
        }
        else
        {
            return Recursive(x = (x * 3) + 1, ++count);
        }
    }

    static void Iterative(int x, int count)
    {
        while (true)
        {
            if (x == 1)
            {
                break;
            }
            if (x % 2 == 0)
            {
                x /= 2;
            }
            else
            {
                x = (x * 3) + 1;
            }
            ++count;
        }
        Console.WriteLine($"Function had to run {count} to set x = 1");
    }





}