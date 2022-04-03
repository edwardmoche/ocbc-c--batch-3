using System;

namespace pesawat
{
    class program{
    public static void Main(string[] args){
        Pesawat pesawat1=new Pesawat();
        pesawat1.nama = "GARUDAKU";
        pesawat1.Ketinggian = "2500 kaki";

        pesawat1.terbang();
        pesawat1.sudahterbang();
        Console.Read();

    }
}
}
