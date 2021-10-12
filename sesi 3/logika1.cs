using System;

public class logika1{
    public static void Main(string[] args){
        int a, b;
        Console.Write($"Masukkan nilai A: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Masukkan nilai B: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a > b ? $"a lebih besar dari b" : (a < b ? "b lebih besar dari a" : "a sama dengan b"));
    }
}