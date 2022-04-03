using System;  
    public class faktorial{  
        public static void Main(string[] args){  
        int i, x=1, n;      
        Console.Write("Enter any Number: ");      
        n= int.Parse(Console.ReadLine());     
        for(i=1; i<=n; i++){      
            x=x*i;      
        }      
        Console.Write("Factorial of " +n+" is: "+x);    
    }  
} 