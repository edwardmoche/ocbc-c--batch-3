using System;

public class logic1{
    public static void Main(){
        int a;
        int b = 53;
        bool hasil = false;

        Console.Write("Masukkan nilai a: ");
        a = int.Parse(Console.ReadLine());
            if(a>b){
                Console.WriteLine("a lebih besar dari b");
            }else{
                if(1 == a){
                    hasil = true;
                }else{
                    hasil = false;
                }
                if (hasil){
                    Console.WriteLine("Nilai a adalah 1");
                }else{
                    Console.WriteLine("Nilai a lebih besar dari 1");
                }
            }
    }
}