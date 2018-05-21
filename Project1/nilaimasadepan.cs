/*
Menggunakan tipe data decimal untuk menghitung
nilai masa depan dari suatu investasi.
*/
using System;

class NilaiMasaDepan {
    static void Main() {
        decimal investasi;
        decimal laju_bunga;
        int tahun, i;

        investasi = 1000.0M;
        laju_bunga = 0.07M;
        tahun = 10;

        Console.WriteLine("Investasi awal: Rp." + investasi .ToString("#,#.00#"));
        Console.WriteLine("Laju bunga: " + laju_bunga);
        Console.WriteLine("Selama " + tahun + " tahun");

        for (i = 0; i < tahun; i++)
            investasi = investasi + (investasi + laju_bunga);
        Console.WriteLine("Nilai masa dengan adalah Rp." + investasi .ToString("#,#.00#"));
    }
}