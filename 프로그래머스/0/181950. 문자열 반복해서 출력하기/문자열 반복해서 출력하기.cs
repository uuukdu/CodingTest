using System;

public class Example
{
    public static void Main()
    {
        string[] input;

        input = Console.ReadLine().Split(' ');

        string s = input[0];

        for (int i = int.Parse(input[1]); i > 0; i--)
        {
            Console.Write(s);
        }

    }
}