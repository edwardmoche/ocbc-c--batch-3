using System;

public class logic2{
    public static void Main(){
        int nilai = 75;
        string nama;

        Console.Write("Masukkan nama : ");
        nama = Console.ReadLine();

        if (nilai <60){
            Console.WriteLine($"{nama}");
            Console.WriteLine("Nilai Kamu C");
        }else if (nilai <80){
            Console.WriteLine($"{nama}");
            Console.WriteLine("Nilai Kamu B");
        }else{
            Console.WriteLine($"{nama}");
            Console.WriteLine("Nilai Kamu A");
        }
    }
}