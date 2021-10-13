using System;

public class Program{
    public static void Main(){
        string merk;
        int ram, memory;

        Console.WriteLine($"=== Data Laptop ===");
        Console.Write($"Merk Laptop: ");
        merk = Console.ReadLine();
        Console.Write($"Ram Laptop: ");
        ram = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Memory Laptop: ");
        memory = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"");

        Laptop laptop1 = new Laptop(merk, ram, memory);

        laptop1.toString();

        laptop1.Chatting();
        laptop1.Sosmed();
        laptop1.OnlineShop();
    }
}