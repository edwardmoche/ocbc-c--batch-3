using System;

namespace ovrd
{
    class program{
        public int bilangan1, bilangan2;
        
        public void bilangan(int angka1, int angka2){
            bilangan1 = angka1;
            bilangan2 = angka2;
        }

        public virtual void penjumlahanperkaliandll(){
            Console.WriteLine("Overiding 1......----->>>>>>");
            Console.WriteLine("Hasil penjumlahan angka {0} dan {1} = {2}", bilangan1,bilangan2,bilangan1+bilangan2);
            Console.WriteLine("Hasil Perkalian angka {0} dan angka {1} = {2} \n\n", bilangan1, bilangan2, bilangan1 * bilangan2);
        }
    }

    class overide : program{
        public override void penjumlahanperkaliandll()
        {
            Console.WriteLine("Overiding 2......----->>>>>>");
            Console.WriteLine("Hasil pembagian angka {0} dan {1} = {2}", bilangan1,bilangan2,bilangan1 / bilangan2);
            Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2} \n\n", bilangan1, bilangan2, bilangan1 - bilangan2);
        }

        static void Main(string[] args){ 
            overide overide1 = new overide();
            overide1.bilangan(20, 5);
            overide1.penjumlahanperkaliandll();

            program overiding = new program();
            overiding.bilangan(10, 5);
            overiding.penjumlahanperkaliandll();
            overiding = new overide();
            overiding.bilangan(20, 5);
            overiding.penjumlahanperkaliandll();
            Console.Read();
            Console.WriteLine("Overide");

        }
    }
}
