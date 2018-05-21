// Mengunakan byte.
using System;

class Mengunakan_bytes {
    static void Main() {
        short x;
        int jum;

        jum = 0;
        for (x = 1; x <= 100; x++)
            jum = jum + x;

        Console.WriteLine("Penjumlahan dari 0-100 adalah " + jum);
    }
}