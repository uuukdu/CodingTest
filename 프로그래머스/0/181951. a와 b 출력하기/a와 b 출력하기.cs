using System;

public class Example
{
    public static void Main()
    {
        string[] s;

        s = Console.ReadLine().Split(' ');

        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);

        Console.WriteLine($"a = {s[0]}");
        Console.WriteLine($"b = {s[1]}");
    }
}