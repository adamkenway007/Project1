using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double t, d, b;
            Console.Write("Total Belanja = ");
            t = double.Parse(Console.ReadLine());
            if (t < 150000)
            {
                d = t * 0 / 100;
                b = t - d;
                Console.WriteLine("Diskon = " + d.ToString());
                Console.Write("Yang Harus Dibayar = " + b.ToString());
            }
            else if (t < 275000)
            {
                d = t * 10 / 100;
                b = t - d;
                Console.WriteLine("Diskon = " + d.ToString());
                Console.Write("Yang Harus Dibayar = " + b.ToString());
            }
            else if (t < 300000)
            {
                d = t * 15 / 100;
                b = t - d;
                Console.WriteLine("Diskon = " + d.ToString());
                Console.Write("Yang Harus Dibayar = " + b.ToString());
            }
            else if (t < 400000)
            {
                d = t * 20 / 100;
                b = t - d;
                Console.WriteLine("Diskon = " + d.ToString());
                Console.Write("Yang Harus Dibayar = " + b.ToString());
            }
            else
            {
                d = t * 25 / 100;
                b = t - d;
                Console.WriteLine("Diskon = " + d.ToString());
                Console.Write("Yang Harus Dibayar = " + b.ToString());
            }
            Console.WriteLine("\n");
            Console.Write("Terima kasih");
            Console.ReadLine();
        }
    }
}