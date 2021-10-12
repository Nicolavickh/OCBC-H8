using System;

public class logika4{
    public static void Main(string[] args){
        int n;
        Console.Write($"Masukkan Nilai: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(n >= 85 ? "Kamu mendapat grade A" : (n >= 65 ? "Kamu mendapat grade B" : (n >= 45  ? "Kamu mendapat grade C" : ( n <= 25 && n < 100 ? "Kamu mendapat grade D" : "Nilai (0 - 100)"))));
    }
}