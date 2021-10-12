using System;

public class Soal1{
    public static void Main(string[] args){
        String abc = "ABCDE";
        int n = 5;

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