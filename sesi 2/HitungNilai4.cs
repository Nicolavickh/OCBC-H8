using System;

public class HitungNilai4{
    public static void Main(string[] args){
        Console.WriteLine($"Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Password: ");
        string password = Console.ReadLine();
        bool isAdult = age > 18;
        bool isPasswordValid = password == "OCBC";

        Console.WriteLine(isPasswordValid && isAdult ? "Welcome to The Club!" : "Sorry, Try Again!");
    }
}