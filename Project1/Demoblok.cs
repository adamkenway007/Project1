// Mendemonstrasikan blok kode.
using System;

class DemoBlok
{
    static void Main() {
        int i, j, d;
        i = 5;
        j = 10;

        // Target dari if ini adalah sebuah blok.
        if (i != 0) {
            Console.WriteLine ("i tidak sama dengan nol");
            d = j / i;
            Console.WriteLine ("j / i adalah " + d);
        }
    }
}