using System;

public class array1{
    public static void Main(string[] args){
        string[] contoh = {"Motherboard", "Processor", "Power Supply", "Video Card"};
        Console.WriteLine($"Menampilkan semua data dalam array");
        Console.WriteLine($"");
        
        foreach(string contoh1 in contoh){
            Console.WriteLine($"{contoh1}");
        }

        Console.WriteLine($"Press any key to continue...");
        
    }
}