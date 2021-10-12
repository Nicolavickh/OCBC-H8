using System;

public class Soal3{
    public static void Main(string[] args){
        int n, hasil = 1;
        
        Console.Write($"Enter any number: ");
        n = Convert.ToInt32(Console.ReadLine());

        for(int i=1; i<=n; i++){
            hasil *= i;
        }

        Console.WriteLine($"Factorial of {n} is: {hasil}");
        
    }
}