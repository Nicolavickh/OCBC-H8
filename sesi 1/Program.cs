using System;

namespace sesi_1
{
    class Program
    {
        static void Main(string[] args)
        {
        String firstName, lastName, address, birthDate;
        int age;

        Console.Write("First name: ");
        firstName = Console.ReadLine();

        Console.Write("Last name: ");
        lastName = Console.ReadLine();

        Console.Write("Umur: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Alamat: ");
        address = Console.ReadLine();
        
        Console.WriteLine("Tanggal Lahir: ");
        birthDate = Console.ReadLine();

        Console.WriteLine("Full name : " + firstName + " " + lastName);
        Console.WriteLine("Umur : " + age);
        Console.WriteLine("Alamat : " + address);
        Console.WriteLine("Tanggal lahir : " + birthDate);
        }
    }
}
