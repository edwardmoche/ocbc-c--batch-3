using System;  
    public class reverse{  
        public static void Main(string[] args){  
        string n;

        Console.Write("Enter the number: ");
        n = Console.ReadLine();
        char[] charayy = n.ToCharArray();
        Array.Reverse(charayy);
        n = new string(charayy);
        Console.WriteLine(n);
    }  
} 