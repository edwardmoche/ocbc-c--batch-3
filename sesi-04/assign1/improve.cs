using System;
using System.Collections.Generic;
using System.Text;

public class logic5{
    public static void Main(){
        int opt;
        Console.WriteLine("Selamat datang di aplikasi MathIs!");
        Console.WriteLine("\n");
        Console.WriteLine("1. Piramida alfabet");
        Console.WriteLine("2. Piramida angka");
        Console.WriteLine("3. faktorial");
        Console.WriteLine("4. balik angka");
        Console.WriteLine("5. convert angka to string");
        Console.WriteLine("6. balik huruf");
        Console.WriteLine("7. tentang saya");
        Console.WriteLine("8. Keluar");
        Console.Write("Fitur manakah yang ingin anda gunakan? ");
        opt = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        
        
        switch(opt){
            case 1:{
                char ch='A';      
                int i, j, k, m;      
                for(i=1; i<=5; i++){      
                    for(j=5; j>=i; j--)      
                        Console.Write(" ");      
                    for(k=1;k<=i;k++)      
                        Console.Write(ch++);      
                        ch--;      
                    for(m=1;m<i;m++)      
                        Console.Write(--ch);      
                        Console.Write("\n");      
                        ch='A';      
                }
                break;
            }
            case 2:{
                int i, j, k, l, n;

                Console.Write("Enter the range=:");
                n = int.Parse(Console.ReadLine());      
                for(i=1; i<=n; i++){          
                    for(j=1; j<=n-i; j++){      
                        Console.Write(" ");      
                    }      
                    for(k=1;k<=i;k++){      
                        Console.Write(k);      
                    }      
                    for(l=i-1;l>=1;l--){      
                        Console.Write(l);      
                    }      
                Console.Write("\n");      
                }
                break;
            }
            case 3:{
                int i, x=1, n;      
                Console.Write("Enter any Number: ");      
                n= int.Parse(Console.ReadLine());     
                for(i=1; i<=n; i++){      
                    x=x*i;      
                }      
                Console.Write("Factorial of " +n+" is: "+x);
                break;
            }
            case 4:{
                string n;

                Console.Write("Enter the number: ");
                n = Console.ReadLine();
                char[] charayy = n.ToCharArray();
                Array.Reverse(charayy);
                n = new string(charayy);
                Console.WriteLine(n);
                break;
            }
            case 5:{
                int val, next, num_digits;
         int[] a = new int[10];
         string[] digits_words = {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"
         };
         Console.Write("Enter the number: ");
         val = int.Parse(Console.ReadLine());
         next = 0;
         num_digits = 0;
         do {
            next = val % 10;
            a[num_digits] = next;
            num_digits++;
            val = val / 10;
         } while (val > 0);
         num_digits--;
         for (; num_digits >= 0; num_digits--)
         Console.Write(digits_words[a[num_digits]] + " ");
         Console.ReadLine();
                break;
            }
            case 6:{
                string n;

                Console.Write("Enter the letter: ");
                n = Console.ReadLine();
                char[] charayy = n.ToCharArray();
                Array.Reverse(charayy);
                n = new string(charayy);
                Console.WriteLine(n);
                break;
                break;
            }
            case 7:{
                Console.WriteLine("Nama         : Mohamad Edward Moche");
                Console.WriteLine("Jenis Kelamin: Pria");
                Console.WriteLine("Alamat       : Perum mampang indah 2");
                Console.WriteLine("Hobi         : bermain");
                Console.WriteLine("Umur         : 22");
                Console.WriteLine("Pekerjaan    : IT Intern OCBC");
                Console.WriteLine("Jurusan      : Teknik Informatika");
                Console.WriteLine("Nama Kampus  : Universitas Gunadarma");
                break;
            }
            case 8:{
                Console.WriteLine("Terimakasih telah menggunakan aplikasi MathIs!");
                break;
            }
        }
    }
}