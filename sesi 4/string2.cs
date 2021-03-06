using System;

public class string2{
    public static void Main(string[] args){
        string str1 = "Untuk pemrograman .NET C# adalah #1.";
        string str2 = "Untuk pemrograman .NET, C# adalah #1.";
        string str3 = "String C# sanagt tangguh.";
        string strAtas, strBawah;
        int hasil, idx;

        Console.WriteLine($"str1: {str1}");
        Console.WriteLine($"Panjang str1: {str1.Length}");
        
        strBawah = str1.ToLower(System.Globalization.CultureInfo.CurrentCulture);
        strAtas = str1.ToUpper(System.Globalization.CultureInfo.CurrentCulture);
        Console.WriteLine($"Versi huruf kecil dari str1:\n {strBawah}");
        Console.WriteLine($"Versi huruf besar dari str1:\n {strAtas}");
        Console.WriteLine($"Text");
        
        Console.WriteLine($"Menampilkan str1, char demi char.");
        for(int i=0; i<str1.Length; i++){
            Console.Write(str1[i]);
        }
        Console.WriteLine($"Text");
        
        Console.WriteLine(str1 == str2 ? "str1 == str2" : "str1 != str2");
        Console.WriteLine(str1 == str3 ? "str1 == str3" : "str1 != str3");

        hasil = string.Compare(str1, str3, StringComparison.CurrentCulture);
        Console.WriteLine(hasil == 0 ? "str1 dan str3 sama" : (hasil < 0) ? "str1 kurang dari str3" : "str1 lebih besar dari str3");
        Console.WriteLine($"Text");
        
        str2 = "Satu Dua Tiga Satu";
        
        idx = str2.IndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine($"Indeks kemunculan pertama dari 'Satu': {idx}");

        idx = str2.LastIndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine($"Indeks kemunculan terakhir dari 'Satu': {idx}");
        
        
    }
}