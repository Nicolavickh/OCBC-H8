using System;

public class gajelas{
    public static void Main(string[] args){
        string uname, pw, jenis_kelamin, status_nikah, jk, nikah;
        int n1, n2, n3, age;

        Console.WriteLine($"=== Masukkan Data ===");
        Console.Write($"Username: ");
        uname = Console.ReadLine();
        Console.Write($"Umur: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Password: ");
        pw = Console.ReadLine();
        Console.Write($"Jenis kelamin (L/P): ");
        jk = Console.ReadLine();
        Console.Write($"Status nikah (Y/n): ");
        nikah = Console.ReadLine();
        Console.WriteLine();
        
        jenis_kelamin = jk == "L" ? "Laki-Laki" : jk == "P" ? "Perempuan" : "Salah Input";
        status_nikah = nikah == "Y" ? "Sudah Menikah" : nikah == "n" ? "Belum Menikah" : "Salah Input";

        
        Console.WriteLine($"=== Aritmatika ===");
        Console.Write($"Nilai ke-1: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Nilai ke-2: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Nilai ke-3: ");
        n3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"");
        
        if(uname == "Nico" && age>18 && pw=="OCBC"){
            Console.Write($"Username: {uname}\n Umur: {age}\n Jenis Kelamin: {jenis_kelamin}\n Status nikah: {status_nikah}\n");
            Console.Write($"Total Nilai: {n1 + n2 + n3}\n Rata-rata Nilai: {(n1 + n2 + n3)/3}");
        }
    }
}