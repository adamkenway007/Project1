// Mendemonstrasikan stateman if.
using System;

class Demoif
{

    static void Main()
    {
        int a, b, c;

        a = 2;
        b = 3;

        if (a < b) Console.WriteLine("a kurang dari b");

        // Ini tidak menampilak apapun
        if (a == b) Console.WriteLine("Anda tidak akan melihat ini");

        Console.WriteLine();

        c = a - b; // c memuat - 1

        Console.WriteLine("c memuat -1");
        if (c >= 0) Console.WriteLine("c tak-negatif");
        if (c < 0) Console.WriteLine("c negatif");

        Console.WriteLine();

        c = b - 1; // c sekarang memuat 1
        Console.WriteLine("c memuat 1");
        if (c >= 0) Console.WriteLine("c tak-negatif");
        if (c < 0) Console.WriteLine("c negatif");

    }
}