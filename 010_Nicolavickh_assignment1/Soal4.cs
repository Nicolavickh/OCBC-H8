using System;

public class Soal4{
    public static void Main(string[] args){
        String n, hasil = "";

        Console.Write($"Enter a number: ");
        n = Console.ReadLine();

        for(int i=n.Length-1; i>=0; i--){
            hasil += n[i];
        }

        Console.WriteLine($"Reversed number: {hasil}");
    }
}