using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //string fileName = Console.ReadLine();
        // int[]nums = ReadArrayFromFile(fileName);
        // int[] arr = new int[] { 1,2,2,3,4};

        //ReverseInPlace(arr);

        //Console.WriteLine(MostCommonCount(arr));

        // Задача 2!!!
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string text = Console.ReadLine();
            if (text == "")
            {
                break;
            }
            //CountWords(text);
            sb.AppendLine(text);
        }

    }


    static int[] ReadArrayFromFile(string fileName)
    {
        string[]arr = File.ReadAllText(fileName).Split(",");
        int[]nums= new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            nums[i] = int.Parse(arr[i]);
        }
        return nums;
    }

    static void ReverseInPlace(int[] arr)
    {
        for (int i = 1; i <= arr.Length/2; i++)
        {
            int temp = arr[arr.Length - i];
            arr[arr.Length - i] = arr[i-1];
            arr[i-1] = temp;
        }
    }

    static int MostCommonCount(int[]arr)
    {
        int mostCommonNum = 0;
        int counter = 0;
        int biggestNumCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                }
            }
            if (counter > biggestNumCount)
            {
                mostCommonNum = arr[i];
                biggestNumCount = counter;
            }
            counter = 0;
        }
        return mostCommonNum;
    }

    static int CountWords(string text)
    {
        string[] arr = text.Split(new[] { " ",", ",".",":",";","" }, StringSplitOptions.None);
        int counter = arr.Length;
        return counter;
    }

    static void CountDigits(string text) 
    {
        string[] words = SplitWord(text);
        int count = 0;
        foreach (var word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                int symbol = word[i];
                if (symbol >= 48 && symbol <= 57)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }

    static void LettersHistogram(string text)
    {
        int[] mainLetters = new int[26];
        int[] currLetters;

        string[] words = SplitWord(text);

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
                Console.WriteLine($"Word {(char)(i + 'a')} {i}");
            }
        }
    }

    static string[] SplitWord(string text)
    {
        string[] words = text.Split(new[] { " ",", ",".",":",";","" }, StringSplitOptions.None);
        return words;
    }
}