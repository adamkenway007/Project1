/*
Program ini mengilustrasikan perbedaan
antara interface dan double
*/

using System;
class Contoh3
{
    static void Main()
    {
        int ivar;   // mendeklarasikan sebuah variable int
        double dvar; // mendeklarasikan sebuah variable titik-mengambang

        ivar = 100; // menugaskan 100 kepada ivar

        dvar = 100.0;

        Console.WriteLine("Nilai asli dari ivar: " + ivar);
        Console.WriteLine("Nilai asli dari dvar: " + ivar);
        Console.WriteLine(); // tampilan baris baru

        // Sekarang bagi keduanya dengan 3.
        ivar = ivar / 3;
        dvar = dvar / 3.0;

        Console.WriteLine("ivar setelah pembagian: " + ivar);
        Console.WriteLine("dvar setelah pembagian" + dvar);
    }
}