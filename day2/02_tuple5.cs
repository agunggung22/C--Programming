

using System;
using System.ComponentModel;


class Program
{
    static (int add, int diff, int mul, int div) Calculate (int a, int b)
    {
        int add = a + b;
        int diff = a - b;
        int mul = a * b;
        int div = ( b != 0) ? a / b : -1;
        return (add, diff, mul, div);
    }
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        var t = Calculate(a, b);
        Console.WriteLine($"{t.add}");

        var (add, diff, mul, div)= Calculate(a, b);   // deconstruction
        // (int add, int diff, int mul, int div)
        Console.WriteLine($"{add}");
    }
}