using System.Numerics;



//Recursive methods:
//Fibonacci

//SLOW VERSION, WITH LOTS OF LOOPS:
/*
class Program
{
    public static void Main(string[] args)
    {
        uint n = 10;
        n--; // the first number is always 0
        uint sequence = n;
        Console.WriteLine($"The answer for sequence {sequence} is {Fibonacci(n)}");
    }
 
    private static ulong Fibonacci(uint n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 2) + Fibonacci(n - 1);
    }
}
*/

//FASTER VERSION, USING CACHE:
// Fibonacci 0 1 1 2 3 5 8 13

 
class Program
{
    private static BigInteger[]? cache;

 
    public static void Main(string[] args)
    {
        uint n = 250;
        cache = new BigInteger[n];
        n--; // the first number is always 0
        uint sequence = n;
        Console.WriteLine($"The answer for sequence {sequence + 1} is {Fibonacci(n)}:N0");
    }
 
    private static BigInteger Fibonacci(uint n)
    {
        if (n <= 1)
            return n;
 
        if (cache?[n] != 0)
            return cache[n];
 
 
        BigInteger tempCache = Fibonacci(n - 2) + Fibonacci(n - 1);
        cache[n] = tempCache;
        return tempCache;
    }
}



