// Menemukan radius dari suatu lingkaran.

using System;
class FindRadius
{
    static void Main()
    {
        Double r;
        Double luas;

        luas = 10.0;

        r = Math.Sqrt(luas / 3.1416);
        Console.WriteLine("Radius adalah " + r);
    }
}