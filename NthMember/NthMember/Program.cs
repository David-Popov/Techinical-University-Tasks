enum Enum
{
    sdasd = 1
}
internal class Program
{
    
    private static void Main(string[] args)
    {
        int nth = int.Parse(Console.ReadLine()!);
        Console.ForegroundColor = ConsoleColor.Green;

        Iteration(nth);
        int nthMember = Recursion(nth);

        Console.WriteLine($"Member `a{nth}`: {nthMember}");


        //int num = int.Parse(Console.ReadLine());
        //int deg = int.Parse(Console.ReadLine());

        //for (int i = 0; i <= deg; i+=2)
        //{
        //    num = num * deg; 
        //}
        //Console.WriteLine(num);
        

    }

    static void Iteration(int nth)
    {
        long[] members = new long[nth];
        long An;
        members[0] = 2;
        members[1] = 4;
        members[2] = 6;

        Console.Write($"Members with Iterative way are: {members[0]}, {members[1]}, {members[2]},");

        for (int i = 3; i < members.Length; i++)
        {
            An = 3 * members[i - 3] + 4 * members[i - 2] - 7 * members[i - 1];
            members[i] = An;
            Console.Write($" {members[i]},");
        }
        Console.WriteLine();
    }

    static int Recursion(int nth)
    {
        if (nth == 1) return 2;

        else if (nth == 2) return 4;

        else if (nth == 3) return 6;

        else return 3 * Recursion(nth - 3) + 4 * Recursion(nth - 2) - 7 * Recursion(nth - 1);
    }
}