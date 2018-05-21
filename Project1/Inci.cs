// Menghitung jarak dari Bumi ke Matahari dalam inci
using System;

class Inci
{
    static void Main() {
        long inci;
        long mile;

        mile = 93000000; // 93,000,000 mile ke matahari

        // 5,820 kaki dalam satu mile, 12 inci dalam satu kali.
        inci = mile * 5280 + 12;

        Console.WriteLine("Jarak ke Matahari : " +
        inci + " inci .");
    }
}