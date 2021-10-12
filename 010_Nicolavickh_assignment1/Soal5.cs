using System;

public class Soal5{
    public static void Main(string[] args){
        String n, hasil = "";

        Console.Write($"Enter the number: ");
        n = Console.ReadLine();
        Console.WriteLine($"");

        for(int i=0; i<n.Length; i++){
            switch(n[i]){
                case('0'):
                    hasil += "zero ";
                    break;
                case('1'):
                    hasil += "one ";
                    break;
                case('2'):
                    hasil += "two ";
                    break;
                case('3'):
                    hasil += "three ";
                    break;
                case('4'):
                    hasil += "four ";
                    break;
                case('5'):
                    hasil += "five ";
                    break;
                case('6'):
                    hasil += "six ";
                    break;
                case('7'):
                    hasil += "seven ";
                    break;
                case('8'):
                    hasil += "eight ";
                    break;
                case('9'):
                    hasil += "nine ";
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(hasil);
    }
}