﻿using System;
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
        Console.WriteLine("rec(2) + rec(3) = " + newFeature(rec(2), rec(3)));
        Console.WriteLine("INFO: Program finish");
    }

    public static int newFeature(int a, int b)
    {
        return a + b;
    }
    public static void Test()
    {
        return;
    }
}