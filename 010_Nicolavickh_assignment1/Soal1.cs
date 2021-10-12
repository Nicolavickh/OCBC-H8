using System;

public class Soal1{
    public static void Main(string[] args){
        String abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int n;
        Console.WriteLine($"Input N: ");
        n = Convert.ToInt32(Console.ReadLine());
        

        for(int i=1; i<=n; i++){
            for(int j=0; j<n-i; j++){      
                Console.Write(" ");      
            }

            for(int j=0;j<i;j++){      
                Console.Write(abc[j]);      
            }

            for(int j=i-2;j>=0;j--){      
                Console.Write(abc[j]);      
            }

            Console.Write("\n");      
        }   
    }
}