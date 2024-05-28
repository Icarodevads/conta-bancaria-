using System;

class Program
{
    static void Main()
    {
        int a = 5;  // 5 = 0101 em binário
        int b = 3;  // 3 = 0011 em binário

        // AND bitwise
        int andResult = a & b; // 1 = 0001
        Console.WriteLine("AND: " + andResult);

        // OR bitwise
        int orResult = a | b; // 7 = 0111
        Console.WriteLine("OR: " + orResult);

        // XOR bitwise
        int xorResult = a ^ b; // 6 = 0110
        Console.WriteLine("XOR: " + xorResult);
    }
}