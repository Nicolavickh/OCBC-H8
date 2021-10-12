using System;

public class Penduduk{
    public static void Main(string[] args){
        string nama;
        int umur;

        Console.WriteLine("=== Program Pendaftaran Penduduk ===");
        Console.Write("Masukkan nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukkan alamat: ");
        var alamat = Console.ReadLine();
        Console.Write("Masukkan umur: ");
        umur = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Terimakasih");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {umur}");
        Console.WriteLine("Sudah Disimpan");
    }
}