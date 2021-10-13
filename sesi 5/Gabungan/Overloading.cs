using System;

public class Overloading{
    public string nama;
    public double nomorTelepon;
    
    public void print(string nama){
        this.nama = nama;
        Console.WriteLine($"Namanya adalah: {this.nama}");
    } 

    public void print(double nomorTelepon){
        this.nomorTelepon = nomorTelepon;
        Console.WriteLine($"Nomor HP: {this.nomorTelepon}");
        
    }
}