using System;  
    public class length{  
        static void Main(){  
            int[] angka = new int[10];
            Console.WriteLine("Panjang array angka adalah " + angka.Length);

            for(int i=0; i< angka.Length; i++){
                angka[i]=i*i;
            }

            Console.Write("Berikut adadlah array angka: ");
            for(int i=0; i< angka.Length; i++){
                Console.Write(angka[i] + " ");
            }
            Console.WriteLine();
    }  
} 