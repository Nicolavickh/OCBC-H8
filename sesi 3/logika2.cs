using System;

public class logika2{
    public static void Main(string[] args){
        int n;
        Console.Write($"Masukkan Nilai: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(n < 60 ? "Nilai kamu C" : (n < 80 ? "Nilai kamu B" : (n <= 100 ? "Nilai kamu A" : "Nilai (0 - 100)")));
    }
}