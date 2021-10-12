using System;

public class HitungNilai3{
    public static void Main(string[] args){
        int nilai1, nilai2 =0;

        Console.Write("Jumlah nilai 1: ");
        nilai1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Jumlah Nilai 2: ");
        nilai2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Hasil perbandingan");
        Console.WriteLine($"nilai1 > nilai2: {nilai1 > nilai2}");
        Console.WriteLine($"nilai >= nilai2: {nilai1 >= nilai2}");
        Console.WriteLine($"nilai1 < nilai2: {nilai1 < nilai2}");
        Console.WriteLine($"nilai1 <= nilai2: {nilai1 <= nilai2}");
        Console.WriteLine($"nilai1 == nilai2: {nilai1 == nilai2}");
        Console.WriteLine($"nilai1 != nilai2: {nilai1 != nilai2}");
        
        
        
    }
}