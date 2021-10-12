using System;

public class logika8{
    public static void Main(string[] args){
        int start, finish, n;
        string opt;

        Console.WriteLine("=== Arithmetic Options ===");
        Console.WriteLine("1. +");
        Console.WriteLine("2. -");
        Console.WriteLine("3. *");
        Console.WriteLine("4. /");
        Console.Write("Choose: ");
        opt = Console.ReadLine();
        Console.Write("Start: ");
        start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Finish: ");
        finish = Convert.ToInt32(Console.ReadLine());
        Console.Write("N: ");
        n = Convert.ToInt32(Console.ReadLine());
        

        switch(opt){
            case("1"):
                for(int i=start; i<=finish; i++){
                    Console.WriteLine(i + n);
                }
                break;
            case("2"):
                for(int i=start; i>=finish; i--){
                    Console.WriteLine(i - n);
                }
                break;
            case("3"):
                for(int i=start; i<=finish; i++){
                    Console.WriteLine(i * n);
                }
                break;
            case("4"):
                for(float i=start; i>=finish; i--){
                    Console.WriteLine(i / n);
                }
                break;
            default:
                Console.WriteLine($"Options (1-4)");
                break;
        }
    }
}