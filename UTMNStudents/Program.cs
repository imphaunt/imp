using System;
public class Program
{

    static int rec(int x)
    {
        if (x == 0)
            return 0;
        return rec(x - 1) + x;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("INFO: Program started");
        Console.WriteLine("123");
        Console.WriteLine("HelloWorld");
        Console.WriteLine("x = " + rec(5));
        int a, b;
        a = 1;
        b = 2;
        int c = a + b;
        Console.WriteLine("INFO: Program finish");
    }

    public static void Test()
    {
        return;
    }
}