using System;

class Program
{
    static void Main(string[] args)
    {
        Pesawat pesawat = new Pesawat();
        pesawat.nama = "GARUDAKU";
        pesawat.Ketinggian = "2500 kaki";

        pesawat.terbang();
        pesawat.sudahTerbang();
    }
}
