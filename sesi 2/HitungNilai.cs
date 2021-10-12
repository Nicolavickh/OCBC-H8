using System;

public class HitungNilai{
    public static void Main(string[] args){
        int satu, dua, tiga, total;
        double rata;

        Console.WriteLine("=== Menghitung Nilai ===");
        Console.Write("Masukkan nilai Pertama: ");
        satu = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan nilai Kedua: ");
        dua = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan nilai Ketiga: ");
        tiga = Convert.ToInt32(Console.ReadLine());

        total = satu + dua + tiga;
        rata = total/3;
        Console.WriteLine("Total nilai adalah: " + total);
        Console.WriteLine("Rata-rata nilai adalah: " + rata);
    }
}