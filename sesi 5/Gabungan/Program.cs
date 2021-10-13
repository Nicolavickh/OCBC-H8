using System;

namespace Pesawat_Tempur
{
    class Program
    {
        public int bil1, bil2;

        public void bilangan(int angka1, int angka2){
            bil1 = angka1;
            bil2 = angka2;
        }

        public virtual void penjumlahanPerkaliandll(){
            Console.WriteLine($"Overiding......----->>>>>>");
            Console.WriteLine($"Hasil penjumlahan angka {bil1} dan angka {bil2} = {bil1 + bil2} ");
            Console.WriteLine($"Hasil perkalian angka {bil1} dan angka {bil2} = {bil1 * bil2}");
        }

        class overide:Program{
            public override void penjumlahanPerkaliandll(){
                Console.WriteLine($"Overiding 2.....----->>>>>");
                Console.WriteLine($"Hasil pembagian angka {bil1} dan angka {bil2} = {bil1 / bil2}");
                Console.WriteLine($"Hasil pengurangan angka {bil1} dan angka {bil2} = {bil1 - bil2}");
            }
        }

        public static void Main(string[] args)
        {
            int pil;
            string lanjut="";

            do{
                Console.WriteLine($"=== Menu ===");
                Console.WriteLine($"1. Pesawat Tempur");
                Console.WriteLine($"2. Overloading");
                Console.WriteLine($"3. Bilangan");
                Console.WriteLine($"4. About Me");
                Console.WriteLine($"5. Keluar");
                Console.Write($"Pilihan: ");
                pil = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"");

                switch(pil){
                    case(1):
                        Pesawat pesawat = new Pesawat();
                        Pesawat.Pesawat_tempur pTempur = new Pesawat.Pesawat_tempur();

                        Console.Write($"Nama Pesawat: ");
                        pesawat.nama = Console.ReadLine();
                        Console.Write($"Jumlah Roda: ");
                        pesawat.jumlahRoda = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Ketinggian: ");
                        pesawat.ketinggian = Console.ReadLine();
                        Console.Write($"Jumlah Penumpang: ");
                        pesawat.jumlahPenumpang = Console.ReadLine();
                        Console.WriteLine($"");
                        
                        Console.Write($"Nama Pesawat Tempur: ");
                        pTempur.nama = Console.ReadLine();
                        Console.Write($"Jumlah Roda: ");
                        pTempur.jumlahRoda = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Ketinggian: ");
                        pTempur.ketinggian = Console.ReadLine();
                        Console.Write($"Jumlah Penumpang: ");
                        pTempur.jumlahPenumpang = Console.ReadLine();
                        Console.WriteLine($"");
                         
                        pesawat.terbang();
                        pTempur.terbangTinggi();
                        Console.Write($"Kembali ke Menu? (Y/n): ");
                        lanjut = Console.ReadLine();
                        Console.WriteLine($"");
                        break;

                    case(2):
                        string nama;
                        double noTelepon;

                        Overloading o = new Overloading();
                        Console.Write($"Nama: ");
                        nama = Console.ReadLine();
                        Console.Write($"Nomor Telepon: ");
                        noTelepon = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"");
                        
                        o.print(nama);
                        o.print(noTelepon);
                        Console.WriteLine($"");
                        Console.Write($"Kembali ke Menu? (Y/n): ");
                        lanjut = Console.ReadLine();
                        Console.WriteLine($"");
                        break;
                    
                    case(3):
                        int bilA, bilB;
                        Program over = new Program();
                        Console.Write($"Bilangan 1: ");
                        bilA = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Bilangan 2: ");
                        bilB = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"");
            
                        over.bilangan(bilA, bilB);
                        over.penjumlahanPerkaliandll();
                        Console.WriteLine($"");
                        
                        
                        Console.Write($"Bilangan 1: ");
                        bilA = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"Bilangan 2: ");
                        bilB = Convert.ToInt32(Console.ReadLine());
                        over = new overide();
                        over.bilangan(bilA, bilB);
                        over.penjumlahanPerkaliandll();
                        Console.WriteLine($"");

                        Console.Write($"Kembali ke Menu? (Y/n): ");
                        lanjut = Console.ReadLine();
                        Console.WriteLine($"");
                        break;

                        case(4):
                            Console.WriteLine($"Pengalaman saya belajar C# selama pertemuan 1-5 cukup menyenangkan karena dapat mengulang dan memperkuat dasar pemrograman kembali setelah sekain lama tidak coding.");
                            Console.WriteLine($"");
                            break;
                }
            }while(pil != 5 && lanjut != "n");
        }
    }
}