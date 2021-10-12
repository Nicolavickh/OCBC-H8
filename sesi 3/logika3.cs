using System;

public class logika3{
    public static void Main(string[] args){
        string uname, pw;

        Console.Write($"Username: ");
        uname = Console.ReadLine();
        Console.Write($"Password: ");
        pw = Console.ReadLine();
        
        Console.WriteLine( uname == "ocbc" ? (pw == "bootcamp" ? $"Anda berhasil Login!" : "Password Anda salah!") : "Username Anda salah!");
    }
}