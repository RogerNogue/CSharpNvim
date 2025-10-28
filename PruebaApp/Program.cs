namespace DotnetTestApp;

public class Program
{
    public static int Add(int a, int b) => a + b;

    public static void Main(string[] args)
    {
        Console.WriteLine($"2 + 3 = {Add(2, 3)}");
    }
}
