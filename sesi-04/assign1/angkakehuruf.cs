using System;
using System.Collections.Generic;
using System.Text;

   class digtoword {
      static void Main(string[] args) {
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
      }
   }
