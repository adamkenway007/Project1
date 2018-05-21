// Menggunakan tipe decimal untuk menghitung diskon
using System;

class Diskon2
{
    static void Main() {
        decimal harga;
        decimal diskon;
        decimal harga_diskon;
    
        // menghitung harga setelah diskon.
        harga = 19.00095m;
        string str = harga.ToString("0.00");
        
        diskon = 0.25m; // persen diskon adalah 15%

        harga_diskon = harga - (harga * diskon);
        Console.WriteLine("Harga Jam Emas Rp." + harga.ToString("#,#.00#"));
        Console.WriteLine("Diskon Barang 15%");
        Console.WriteLine("Harga Setelah Diskon: Rp." + harga_diskon.ToString("#,#.00#"));
    }
}