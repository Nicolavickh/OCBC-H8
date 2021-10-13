using System;

public class Laptop{
    public string merk;
    public int ram, memory;

    public Laptop(string merk, int ram, int memory){
        this.merk = merk;
        this.ram = ram;
        this.memory = memory;
    }

    public void Chatting(){
        Console.WriteLine($"{this.merk} sedang chatting");
        Console.WriteLine($"");
        
    }

    public void Sosmed(){
        Console.WriteLine($"{this.merk} sedang sosmed");
        Console.WriteLine($"");
        
    }

    public void OnlineShop(){
        Console.WriteLine($"{this.merk} sedang online shop");
        Console.WriteLine($"");
        
    }

    public void toString(){
        Console.WriteLine($"Merk laptop adalah: {this.merk}" );
        Console.WriteLine($"Kapasitas Ram ada: {this.ram}");
        Console.WriteLine($"Kapasitas Memory ada: {this.memory}");
        Console.WriteLine($"");
    }
}