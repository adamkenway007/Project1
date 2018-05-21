// Program ini menciptakan variable.
using System;

class Contoh2
{
    static void Main() {
        int x; // Mendeklarasi sebuah variable
        int y; // Mendeklarasi variable lain

        x = 100; // menugaskan 100 kepada x

        Console.WriteLine ("x memuat " + x);
        y = x / 2;

        Console.Write ("y memuat x / 2: ");
        Console.WriteLine (y);
    }
}