using System;

namespace sesi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Nicoalvickh Yohanes");
            Console.WriteLine("Selamat datang di program bootcamp OCBC");
            Console.WriteLine("Tahap 1 saya akan belajar C#");

            string namaCustomer = "Nicolavickh";
            double harga1 = 10000, harga2 = 5000, harga3 = 20000;
            int jumlah1 = 10, jumlah2 = 7, jumlah3 = 13;

            double total1 = harga1*jumlah1;
            double total2 = harga2*jumlah2;
            double total3 = harga3*jumlah3;

            double subtotal = total1+total2+total3;
            int totalBarang = jumlah1 + jumlah2 + jumlah3;
            
            Console.WriteLine();
            Console.WriteLine("Name Customer: " + namaCustomer);
            Console.WriteLine("Barang 1 berjumlah: " + jumlah1 + " dengan harga " + harga1 + "yang harus dibayar " + total1);
            Console.WriteLine("Barang 1 berjumlah: " + jumlah2 + " dengan harga " + harga2 + "yang harus dibayar " + total2);
            Console.WriteLine("Barang 1 berjumlah: " + jumlah3 + " dengan harga " + harga3 + "yang harus dibayar " + total3);
            Console.WriteLine();
            Console.WriteLine("Jumlah semua barang: " + totalBarang);
            Console.WriteLine("Total semua harga: " + subtotal);
            Console.WriteLine();
        }
    }
}
